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
            this.anulujButton = new System.Windows.Forms.Button();
            this.zapiszButton = new System.Windows.Forms.Button();
            this.buttonDodajUcznia = new System.Windows.Forms.Button();
            this.dataGridViewUczniowie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUczniowie)).BeginInit();
            this.SuspendLayout();
            // 
            // anulujButton
            // 
            this.anulujButton.Location = new System.Drawing.Point(621, 415);
            this.anulujButton.Name = "anulujButton";
            this.anulujButton.Size = new System.Drawing.Size(75, 23);
            this.anulujButton.TabIndex = 0;
            this.anulujButton.Text = "Anuluj";
            this.anulujButton.UseVisualStyleBackColor = true;
            this.anulujButton.Click += new System.EventHandler(this.anulujButton_Click);
            // 
            // zapiszButton
            // 
            this.zapiszButton.Location = new System.Drawing.Point(702, 415);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(75, 23);
            this.zapiszButton.TabIndex = 1;
            this.zapiszButton.Text = "Zapisz";
            this.zapiszButton.UseVisualStyleBackColor = true;
            this.zapiszButton.Click += new System.EventHandler(this.zapiszButton_Click);
            // 
            // buttonDodajUcznia
            // 
            this.buttonDodajUcznia.Location = new System.Drawing.Point(621, 16);
            this.buttonDodajUcznia.Name = "buttonDodajUcznia";
            this.buttonDodajUcznia.Size = new System.Drawing.Size(156, 23);
            this.buttonDodajUcznia.TabIndex = 3;
            this.buttonDodajUcznia.Text = "Dodaj ucznia";
            this.buttonDodajUcznia.UseVisualStyleBackColor = true;
            this.buttonDodajUcznia.Click += new System.EventHandler(this.buttonDodajUcznia_Click);
            // 
            // dataGridViewUczniowie
            // 
            this.dataGridViewUczniowie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUczniowie.Location = new System.Drawing.Point(10, 44);
            this.dataGridViewUczniowie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUczniowie.Name = "dataGridViewUczniowie";
            this.dataGridViewUczniowie.RowHeadersWidth = 51;
            this.dataGridViewUczniowie.RowTemplate.Height = 29;
            this.dataGridViewUczniowie.Size = new System.Drawing.Size(766, 365);
            this.dataGridViewUczniowie.TabIndex = 4;
            this.dataGridViewUczniowie.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUczniowie_CellMouseClick);
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 451);
            this.Controls.Add(this.dataGridViewUczniowie);
            this.Controls.Add(this.buttonDodajUcznia);
            this.Controls.Add(this.zapiszButton);
            this.Controls.Add(this.anulujButton);
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUczniowie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button anulujButton;
        private Button zapiszButton;
        private Button buttonDodajUcznia;
        private DataGridView dataGridViewUczniowie;
    }
}