namespace ProjektDziennikMydlo
{
    partial class LogowaniePracownik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            butZaloguj = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelLogin = new Label();
            labelHaslo = new Label();
            SuspendLayout();
            // 
            // butZaloguj
            // 
            butZaloguj.Location = new Point(703, 400);
            butZaloguj.Name = "butZaloguj";
            butZaloguj.Size = new Size(112, 34);
            butZaloguj.TabIndex = 0;
            butZaloguj.Text = "Zaloguj";
            butZaloguj.UseVisualStyleBackColor = true;
            butZaloguj.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(486, 258);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(486, 319);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 31);
            textBox2.TabIndex = 2;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.ForeColor = SystemColors.ButtonFace;
            labelLogin.Location = new Point(347, 261);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(133, 25);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Login lub email";
            // 
            // labelHaslo
            // 
            labelHaslo.AutoSize = true;
            labelHaslo.ForeColor = SystemColors.ButtonFace;
            labelHaslo.Location = new Point(402, 322);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(58, 25);
            labelHaslo.TabIndex = 4;
            labelHaslo.Text = "Hasło";
            // 
            // LogowaniePracownik
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1258, 664);
            Controls.Add(labelHaslo);
            Controls.Add(labelLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(butZaloguj);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LogowaniePracownik";
            StartPosition = FormStartPosition.CenterParent;
            Text = "E-Dziennik Pracownik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butZaloguj;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelLogin;
        private Label labelHaslo;
    }
}