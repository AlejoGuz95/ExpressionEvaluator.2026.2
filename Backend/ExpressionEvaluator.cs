using System.Globalization;

namespace Backend;

public static class ExpressionEvaluator
{
    private static readonly HashSet<char> Operators =
        new() { '+', '-', '*', '/', '^' };

    public static double Evalute(string infix)
    {
        if (string.IsNullOrWhiteSpace(infix))
        {
            throw new ArgumentException(
                "La expresión está vacía.");
        }

        List<string> tokens = Tokenize(infix);
        List<string> postfix = ToPostfix(tokens);

        return EvalutePostfix(postfix);
    }

    // Convierte la expresión en números y operadores.
    // Por ejemplo: 12.5+20 -> ["12.5", "+", "20"]
    private static List<string> Tokenize(string infix)
    {
        var tokens = new List<string>();
        int position = 0;

        while (position < infix.Length)
        {
            char current = infix[position];

            // Ignorar espacios.
            if (char.IsWhiteSpace(current))
            {
                position++;
                continue;
            }

            // Detectar signo negativo o positivo en un número.
            bool unarySign =
                (current == '-' || current == '+') &&
                (
                    tokens.Count == 0 ||
                    tokens[^1] == "(" ||
                    IsOperator(tokens[^1])
                );

            bool startsNumber =
                char.IsDigit(current) ||
                current == '.' ||
                current == ',' ||
                (
                    unarySign &&
                    position + 1 < infix.Length &&
                    (
                        char.IsDigit(infix[position + 1]) ||
                        infix[position + 1] == '.' ||
                        infix[position + 1] == ','
                    )
                );

            if (startsNumber)
            {
                int start = position;

                if (unarySign)
                {
                    position++;
                }

                bool decimalFound = false;
                bool digitFound = false;

                while (position < infix.Length)
                {
                    char numberCharacter = infix[position];

                    if (char.IsDigit(numberCharacter))
                    {
                        digitFound = true;
                        position++;
                        continue;
                    }

                    if (numberCharacter == '.' ||
                        numberCharacter == ',')
                    {
                        if (decimalFound)
                        {
                            throw new FormatException(
                                "Un número contiene más de un separador decimal.");
                        }

                        decimalFound = true;
                        position++;
                        continue;
                    }

                    break;
                }

                if (!digitFound)
                {
                    throw new FormatException(
                        "Se encontró un número inválido.");
                }

                string number = infix[start..position]
                    .Replace(',', '.');

                if (!double.TryParse(
                    number,
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out _))
                {
                    throw new FormatException(
                        $"Número inválido: {number}");
                }

                tokens.Add(number);
                continue;
            }

            // Signo negativo antes de paréntesis:
            // -(5+2) se convierte en 0-(5+2).
            if (current == '-' &&
                unarySign &&
                position + 1 < infix.Length &&
                infix[position + 1] == '(')
            {
                tokens.Add("0");
                tokens.Add("-");
                position++;
                continue;
            }

            if (current == '(' ||
                current == ')' ||
                Operators.Contains(current))
            {
                tokens.Add(current.ToString());
                position++;
                continue;
            }

            throw new FormatException(
                $"Carácter no permitido: {current}");
        }

        return tokens;
    }

    // Convierte la expresión infija a postfija mediante una pila.
    private static List<string> ToPostfix(
        List<string> tokens)
    {
        var postfix = new List<string>();
        var stack = new Stack<string>();

        foreach (string token in tokens)
        {
            if (IsNumber(token))
            {
                postfix.Add(token);
            }
            else if (token == "(")
            {
                stack.Push(token);
            }
            else if (token == ")")
            {
                while (
                    stack.Count > 0 &&
                    stack.Peek() != "(")
                {
                    postfix.Add(stack.Pop());
                }

                if (stack.Count == 0)
                {
                    throw new FormatException(
                        "Los paréntesis no están balanceados.");
                }

                // Eliminar el paréntesis izquierdo.
                stack.Pop();
            }
            else if (IsOperator(token))
            {
                while (
                    stack.Count > 0 &&
                    IsOperator(stack.Peek()) &&
                    (
                        Priority(stack.Peek()) >
                        Priority(token) ||

                        Priority(stack.Peek()) ==
                        Priority(token) &&
                        token != "^"
                    )
                )
                {
                    postfix.Add(stack.Pop());
                }

                stack.Push(token);
            }
        }

        while (stack.Count > 0)
        {
            if (stack.Peek() == "(")
            {
                throw new FormatException(
                    "Los paréntesis no están balanceados.");
            }

            postfix.Add(stack.Pop());
        }

        return postfix;
    }

    // Evalúa la expresión postfija mediante una pila.
    private static double EvalutePostfix(
        List<string> postfix)
    {
        var stack = new Stack<double>();

        foreach (string token in postfix)
        {
            if (double.TryParse(
                token,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out double number))
            {
                stack.Push(number);
                continue;
            }

            if (stack.Count < 2)
            {
                throw new FormatException(
                    "La expresión está incompleta.");
            }

            double operand2 = stack.Pop();
            double operand1 = stack.Pop();

            if (token == "/" && operand2 == 0)
            {
                throw new DivideByZeroException(
                    "No se puede dividir entre cero.");
            }

            double result = Calculate(
                operand1,
                operand2,
                token);

            stack.Push(result);
        }

        if (stack.Count != 1)
        {
            throw new FormatException(
                "La expresión no es válida.");
        }

        return stack.Pop();
    }

    private static bool IsNumber(string token)
    {
        return double.TryParse(
            token,
            NumberStyles.Float,
            CultureInfo.InvariantCulture,
            out _);
    }

    private static bool IsOperator(string token)
    {
        return token.Length == 1 &&
               Operators.Contains(token[0]);
    }

    private static int Priority(string operation)
    {
        return operation switch
        {
            "+" => 1,
            "-" => 1,
            "*" => 2,
            "/" => 2,
            "^" => 3,

            _ => throw new FormatException(
                "Operador inválido.")
        };
    }

    private static double Calculate(
        double operand1,
        double operand2,
        string operation)
    {
        return operation switch
        {
            "+" => operand1 + operand2,
            "-" => operand1 - operand2,
            "*" => operand1 * operand2,
            "/" => operand1 / operand2,
            "^" => Math.Pow(operand1, operand2),

            _ => throw new FormatException(
                "Operador inválido.")
        };
    }
}
