namespace ProjektDziennikMydlo
{
    partial class LogowanieUczen
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
            labelHaslo = new Label();
            labelLogin = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            butZaloguj = new Button();
            SuspendLayout();
            // 
            // labelHaslo
            // 
            labelHaslo.AutoSize = true;
            labelHaslo.ForeColor = SystemColors.ButtonFace;
            labelHaslo.Location = new Point(450, 308);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(58, 25);
            labelHaslo.TabIndex = 9;
            labelHaslo.Text = "Hasło";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.ForeColor = SystemColors.ButtonFace;
            labelLogin.Location = new Point(395, 247);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(133, 25);
            labelLogin.TabIndex = 8;
            labelLogin.Text = "Login lub email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(534, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(534, 244);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 31);
            textBox1.TabIndex = 6;
            // 
            // butZaloguj
            // 
            butZaloguj.Location = new Point(751, 386);
            butZaloguj.Name = "butZaloguj";
            butZaloguj.Size = new Size(112, 34);
            butZaloguj.TabIndex = 5;
            butZaloguj.Text = "Zaloguj";
            butZaloguj.UseVisualStyleBackColor = true;
            butZaloguj.Click += butZaloguj_Click;
            // 
            // LogowanieUczen
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
            Name = "LogowanieUczen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Dziennik Uczeń";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHaslo;
        private Label labelLogin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button butZaloguj;
    }
}