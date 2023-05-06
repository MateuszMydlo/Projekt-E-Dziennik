namespace ProjektDziennikMydlo
{
    partial class LogowanieGlowne
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
            this.butZaloguj = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelHaslo = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butZaloguj
            // 
            this.butZaloguj.Location = new System.Drawing.Point(340, 231);
            this.butZaloguj.Margin = new System.Windows.Forms.Padding(2);
            this.butZaloguj.Name = "butZaloguj";
            this.butZaloguj.Size = new System.Drawing.Size(184, 32);
            this.butZaloguj.TabIndex = 0;
            this.butZaloguj.Text = "Zaloguj";
            this.butZaloguj.UseVisualStyleBackColor = true;
            this.butZaloguj.Click += new System.EventHandler(this.ButtonZaloguj);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(340, 155);
            this.emailInput.Margin = new System.Windows.Forms.Padding(2);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(184, 23);
            this.emailInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(340, 191);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(184, 23);
            this.passwordInput.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogin.Location = new System.Drawing.Point(243, 157);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(89, 15);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login lub email";
            // 
            // labelHaslo
            // 
            this.labelHaslo.AutoSize = true;
            this.labelHaslo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHaslo.Location = new System.Drawing.Point(281, 193);
            this.labelHaslo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHaslo.Name = "labelHaslo";
            this.labelHaslo.Size = new System.Drawing.Size(37, 15);
            this.labelHaslo.TabIndex = 4;
            this.labelHaslo.Text = "Hasło";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(0, 0);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "< ---";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // LogowanieGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(881, 398);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.labelHaslo);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.butZaloguj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogowanieGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button butZaloguj;
        private TextBox emailInput;
        private TextBox passwordInput;
        private Label labelLogin;
        private Label labelHaslo;
        private Button returnButton;
    }
}