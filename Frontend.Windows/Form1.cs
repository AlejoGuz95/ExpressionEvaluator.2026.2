using Backend;

namespace Frontend.Windows;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void BtnInput_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        txtDisplay.Text += btn.Text;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtDisplay.Clear();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (txtDisplay.Text.Length > 0)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(
                0,
                txtDisplay.Text.Length - 1);
        }
    }

    private void btnEqual_Click(object sender, EventArgs e)
    {
        try
        {
            var result =
                ExpressionEvaluator.Evalute(
                    txtDisplay.Text);

            txtDisplay.Text = result.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error");
        }
    }
}
