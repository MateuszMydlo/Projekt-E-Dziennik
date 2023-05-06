namespace ProjektDziennikMydlo
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
            this.butDalej = new System.Windows.Forms.Button();
            this.radioPracownik = new System.Windows.Forms.RadioButton();
            this.radioUczen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butDalej
            // 
            this.butDalej.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butDalej.Location = new System.Drawing.Point(389, 232);
            this.butDalej.Margin = new System.Windows.Forms.Padding(2);
            this.butDalej.Name = "butDalej";
            this.butDalej.Size = new System.Drawing.Size(126, 39);
            this.butDalej.TabIndex = 1;
            this.butDalej.Text = "Przejdź dalej";
            this.butDalej.UseVisualStyleBackColor = true;
            this.butDalej.Click += new System.EventHandler(this.ButtonDalej);
            // 
            // radioPracownik
            // 
            this.radioPracownik.AutoSize = true;
            this.radioPracownik.Location = new System.Drawing.Point(484, 196);
            this.radioPracownik.Margin = new System.Windows.Forms.Padding(2);
            this.radioPracownik.Name = "radioPracownik";
            this.radioPracownik.Size = new System.Drawing.Size(139, 19);
            this.radioPracownik.TabIndex = 2;
            this.radioPracownik.TabStop = true;
            this.radioPracownik.Text = "Jestem Pracownikiem";
            this.radioPracownik.UseVisualStyleBackColor = true;
            // 
            // radioUczen
            // 
            this.radioUczen.AutoSize = true;
            this.radioUczen.Location = new System.Drawing.Point(304, 196);
            this.radioUczen.Margin = new System.Windows.Forms.Padding(2);
            this.radioUczen.Name = "radioUczen";
            this.radioUczen.Size = new System.Drawing.Size(110, 19);
            this.radioUczen.TabIndex = 3;
            this.radioUczen.TabStop = true;
            this.radioUczen.Text = "Jestem Uczniem";
            this.radioUczen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(323, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-Dziennik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(919, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioUczen);
            this.Controls.Add(this.radioPracownik);
            this.Controls.Add(this.butDalej);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Dziennik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button butDalej;
        private RadioButton radioPracownik;
        private RadioButton radioUczen;
        private Label label1;
    }
}