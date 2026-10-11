namespace Frontend.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            button18 = new Button();
            btnEqual = new Button();
            button19 = new Button();
            button20 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.DarkGreen;
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(46, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.ShortcutsEnabled = false;
            txtDisplay.Size = new Size(491, 39);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(46, 82);
            button1.Name = "button1";
            button1.Size = new Size(44, 46);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnInput_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(96, 82);
            button2.Name = "button2";
            button2.Size = new Size(44, 46);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnInput_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(146, 82);
            button3.Name = "button3";
            button3.Size = new Size(44, 46);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BtnInput_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(196, 82);
            button4.Name = "button4";
            button4.Size = new Size(44, 46);
            button4.TabIndex = 4;
            button4.Text = "(";
            button4.UseVisualStyleBackColor = false;
            button4.Click += BtnInput_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(246, 82);
            button5.Name = "button5";
            button5.Size = new Size(44, 46);
            button5.TabIndex = 5;
            button5.Text = ")";
            button5.UseVisualStyleBackColor = false;
            button5.Click += BtnInput_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(46, 134);
            button6.Name = "button6";
            button6.Size = new Size(44, 46);
            button6.TabIndex = 6;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += BtnInput_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(96, 134);
            button7.Name = "button7";
            button7.Size = new Size(44, 46);
            button7.TabIndex = 7;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += BtnInput_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(146, 134);
            button8.Name = "button8";
            button8.Size = new Size(44, 46);
            button8.TabIndex = 8;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += BtnInput_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 128, 0);
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(196, 134);
            button9.Name = "button9";
            button9.Size = new Size(44, 46);
            button9.TabIndex = 9;
            button9.Text = "*";
            button9.UseVisualStyleBackColor = false;
            button9.Click += BtnInput_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(255, 128, 0);
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(246, 134);
            button10.Name = "button10";
            button10.Size = new Size(44, 46);
            button10.TabIndex = 10;
            button10.Text = "/";
            button10.UseVisualStyleBackColor = false;
            button10.Click += BtnInput_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(46, 186);
            button11.Name = "button11";
            button11.Size = new Size(44, 46);
            button11.TabIndex = 11;
            button11.Text = "1";
            button11.UseVisualStyleBackColor = true;
            button11.Click += BtnInput_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(96, 186);
            button12.Name = "button12";
            button12.Size = new Size(44, 46);
            button12.TabIndex = 12;
            button12.Text = "2";
            button12.UseVisualStyleBackColor = true;
            button12.Click += BtnInput_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.Location = new Point(146, 186);
            button13.Name = "button13";
            button13.Size = new Size(44, 46);
            button13.TabIndex = 13;
            button13.Text = "3";
            button13.UseVisualStyleBackColor = true;
            button13.Click += BtnInput_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(255, 128, 0);
            button14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.Location = new Point(196, 186);
            button14.Name = "button14";
            button14.Size = new Size(44, 46);
            button14.TabIndex = 14;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = false;
            button14.Click += BtnInput_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(255, 128, 0);
            button15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.Location = new Point(246, 186);
            button15.Name = "button15";
            button15.Size = new Size(44, 46);
            button15.TabIndex = 15;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = false;
            button15.Click += BtnInput_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(296, 82);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(241, 46);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(296, 134);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(241, 46);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(255, 128, 0);
            button18.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(296, 186);
            button18.Name = "button18";
            button18.Size = new Size(241, 46);
            button18.TabIndex = 18;
            button18.Text = "^";
            button18.UseVisualStyleBackColor = false;
            button18.Click += BtnInput_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 128, 0);
            btnEqual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(196, 238);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(341, 46);
            btnEqual.TabIndex = 21;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.Location = new Point(46, 238);
            button19.Name = "button19";
            button19.Size = new Size(94, 46);
            button19.TabIndex = 22;
            button19.Text = "0";
            button19.UseVisualStyleBackColor = true;
            button19.Click += BtnInput_Click;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button20.Location = new Point(146, 238);
            button20.Name = "button20";
            button20.Size = new Size(44, 46);
            button20.TabIndex = 23;
            button20.Text = ".";
            button20.UseVisualStyleBackColor = true;
            button20.Click += BtnInput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(562, 314);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(btnEqual);
            Controls.Add(button18);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button btnDelete;
        private Button btnClear;
        private Button button18;
        private Button btnEqual;
        private Button button19;
        private Button button20;
    }
}
