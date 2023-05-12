namespace ProjektDziennikMydlo.RejestracjaView
{
    partial class Rejestracja
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
            anulujButton = new Button();
            zapiszButton = new Button();
            buttonDodajUcznia = new Button();
            dataGridViewUczniowie = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUczniowie).BeginInit();
            SuspendLayout();
            // 
            // anulujButton
            // 
            anulujButton.Location = new Point(710, 553);
            anulujButton.Margin = new Padding(3, 4, 3, 4);
            anulujButton.Name = "anulujButton";
            anulujButton.Size = new Size(86, 31);
            anulujButton.TabIndex = 0;
            anulujButton.Text = "Anuluj";
            anulujButton.UseVisualStyleBackColor = true;
            anulujButton.Click += anulujButton_Click;
            // 
            // zapiszButton
            // 
            zapiszButton.Location = new Point(802, 553);
            zapiszButton.Margin = new Padding(3, 4, 3, 4);
            zapiszButton.Name = "zapiszButton";
            zapiszButton.Size = new Size(86, 31);
            zapiszButton.TabIndex = 1;
            zapiszButton.Text = "Zapisz";
            zapiszButton.UseVisualStyleBackColor = true;
            zapiszButton.Click += zapiszButton_Click;
            // 
            // buttonDodajUcznia
            // 
            buttonDodajUcznia.Location = new Point(710, 21);
            buttonDodajUcznia.Margin = new Padding(3, 4, 3, 4);
            buttonDodajUcznia.Name = "buttonDodajUcznia";
            buttonDodajUcznia.Size = new Size(178, 31);
            buttonDodajUcznia.TabIndex = 3;
            buttonDodajUcznia.Text = "Dodaj ucznia";
            buttonDodajUcznia.UseVisualStyleBackColor = true;
            buttonDodajUcznia.Click += buttonDodajUcznia_Click;
            // 
            // dataGridViewUczniowie
            // 
            dataGridViewUczniowie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUczniowie.Location = new Point(12, 59);
            dataGridViewUczniowie.Name = "dataGridViewUczniowie";
            dataGridViewUczniowie.RowHeadersWidth = 51;
            dataGridViewUczniowie.RowTemplate.Height = 29;
            dataGridViewUczniowie.Size = new Size(876, 487);
            dataGridViewUczniowie.TabIndex = 4;
            dataGridViewUczniowie.CellMouseClick += dataGridViewUczniowie_CellMouseClick;
            // 
            // Rejestracja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 601);
            Controls.Add(dataGridViewUczniowie);
            Controls.Add(buttonDodajUcznia);
            Controls.Add(zapiszButton);
            Controls.Add(anulujButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Rejestracja";
            Text = "Rejestracja";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUczniowie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button anulujButton;
        private Button zapiszButton;
        private Button buttonDodajUcznia;
        private DataGridView dataGridViewUczniowie;
    }
}