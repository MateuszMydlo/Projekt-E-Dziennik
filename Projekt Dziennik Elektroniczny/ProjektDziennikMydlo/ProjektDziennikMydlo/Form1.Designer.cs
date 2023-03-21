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
            butDalej = new Button();
            radioPracownik = new RadioButton();
            radioUczen = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // butDalej
            // 
            butDalej.ForeColor = SystemColors.ActiveCaptionText;
            butDalej.Location = new Point(717, 403);
            butDalej.Name = "butDalej";
            butDalej.Size = new Size(180, 65);
            butDalej.TabIndex = 1;
            butDalej.Text = "Przejdź dalej";
            butDalej.UseVisualStyleBackColor = true;
            butDalej.Click += button1_Click_1;
            // 
            // radioPracownik
            // 
            radioPracownik.AutoSize = true;
            radioPracownik.Location = new Point(692, 327);
            radioPracownik.Name = "radioPracownik";
            radioPracownik.Size = new Size(205, 29);
            radioPracownik.TabIndex = 2;
            radioPracownik.TabStop = true;
            radioPracownik.Text = "Jestem Pracownikiem";
            radioPracownik.UseVisualStyleBackColor = true;
            // 
            // radioUczen
            // 
            radioUczen.AutoSize = true;
            radioUczen.Location = new Point(434, 327);
            radioUczen.Name = "radioUczen";
            radioUczen.Size = new Size(163, 29);
            radioUczen.TabIndex = 3;
            radioUczen.TabStop = true;
            radioUczen.Text = "Jestem Uczniem";
            radioUczen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(411, 403);
            button1.Name = "button1";
            button1.Size = new Size(186, 65);
            button1.TabIndex = 4;
            button1.Text = "Pierwszy raz? Zarejestruj się tutaj!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(462, 156);
            label1.Name = "label1";
            label1.Size = new Size(378, 96);
            label1.TabIndex = 5;
            label1.Text = "E-Dziennik";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1313, 664);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(radioUczen);
            Controls.Add(radioPracownik);
            Controls.Add(butDalej);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butDalej;
        private RadioButton radioPracownik;
        private RadioButton radioUczen;
        private Button button1;
        private Label label1;
    }
}