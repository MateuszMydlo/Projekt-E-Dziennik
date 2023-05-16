using System.Runtime.CompilerServices;

namespace ProjektDziennikMydlo
{
    partial class WidokUczen
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            butPlanLek = new Button();
            butOceny = new Button();
            butFrek = new Button();
            butTerminy = new Button();
            butPowrot1 = new Button();
            panel4 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label145 = new Label();
            label146 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label50 = new Label();
            butMojeDane = new Button();
            planLekcjiText = new TextBox();
            panelPlanLekcji = new FlowLayoutPanel();
            tabelaPlanLekcji = new TableLayoutPanel();
            panelMojeDane = new FlowLayoutPanel();
            powitanieImie = new TextBox();
            dataCzas = new TextBox();
            panelOceny = new FlowLayoutPanel();
            ocenkiText = new TextBox();
            tabelaOceny = new TableLayoutPanel();
            richLegenda = new RichTextBox();
            TextboxFrekwencja = new TextBox();
            frtab = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Ilość_nieobecności = new DataGridViewTextBoxColumn();
            panelFrekwencja = new FlowLayoutPanel();
            uspr = new Button();
            panelSprawdziany = new FlowLayoutPanel();
            SPRtext = new TextBox();
            sprawdziany_tabelka = new DataGridView();
            sheduled_date = new DataGridViewTextBoxColumn();
            entry_date = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            teacher = new DataGridViewTextBoxColumn();
            comment = new DataGridViewTextBoxColumn();
            test_type = new DataGridViewTextBoxColumn();
            id_label = new Label();
            loading = new FlowLayoutPanel();
            tableLayoutPanel4.SuspendLayout();
            panelPlanLekcji.SuspendLayout();
            panelMojeDane.SuspendLayout();
            panelOceny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frtab).BeginInit();
            panelFrekwencja.SuspendLayout();
            panelSprawdziany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sprawdziany_tabelka).BeginInit();
            SuspendLayout();
            // 
            // butPlanLek
            // 
            butPlanLek.ForeColor = SystemColors.ActiveCaptionText;
            butPlanLek.Location = new Point(286, 654);
            butPlanLek.Margin = new Padding(2);
            butPlanLek.Name = "butPlanLek";
            butPlanLek.Size = new Size(145, 31);
            butPlanLek.TabIndex = 0;
            butPlanLek.Text = "Plan Lekcji";
            butPlanLek.UseVisualStyleBackColor = true;
            butPlanLek.Click += butPlanLek_Click;
            // 
            // butOceny
            // 
            butOceny.ForeColor = SystemColors.ActiveCaptionText;
            butOceny.Location = new Point(435, 654);
            butOceny.Margin = new Padding(2);
            butOceny.Name = "butOceny";
            butOceny.Size = new Size(148, 31);
            butOceny.TabIndex = 1;
            butOceny.Text = "Oceny";
            butOceny.UseVisualStyleBackColor = true;
            butOceny.Click += butOceny_Click;
            // 
            // butFrek
            // 
            butFrek.ForeColor = SystemColors.ActiveCaptionText;
            butFrek.Location = new Point(587, 654);
            butFrek.Margin = new Padding(2);
            butFrek.Name = "butFrek";
            butFrek.Size = new Size(158, 31);
            butFrek.TabIndex = 2;
            butFrek.Text = "Frekwencja";
            butFrek.UseVisualStyleBackColor = true;
            butFrek.Click += butFrek_Click;
            // 
            // butTerminy
            // 
            butTerminy.ForeColor = SystemColors.ActiveCaptionText;
            butTerminy.Location = new Point(749, 654);
            butTerminy.Margin = new Padding(2);
            butTerminy.Name = "butTerminy";
            butTerminy.Size = new Size(166, 31);
            butTerminy.TabIndex = 3;
            butTerminy.Text = "Terminy sprawdzianów";
            butTerminy.UseVisualStyleBackColor = true;
            butTerminy.Click += butTerminy_Click;
            // 
            // butPowrot1
            // 
            butPowrot1.ForeColor = SystemColors.ActiveCaptionText;
            butPowrot1.Location = new Point(12, 11);
            butPowrot1.Margin = new Padding(2);
            butPowrot1.Name = "butPowrot1";
            butPowrot1.Size = new Size(78, 30);
            butPowrot1.TabIndex = 4;
            butPowrot1.Text = "< Wyloguj";
            butPowrot1.UseVisualStyleBackColor = true;
            butPowrot1.Click += butPowrot1_Click_1;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.Controls.Add(label145, 5, 7);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 8;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label145
            // 
            label145.AutoSize = true;
            label145.Location = new Point(168, 0);
            label145.Name = "label145";
            label145.Size = new Size(29, 30);
            label145.TabIndex = 47;
            label145.Text = "label145";
            // 
            // label146
            // 
            label146.AutoSize = true;
            label146.Location = new Point(135, 0);
            label146.Name = "label146";
            label146.Size = new Size(25, 150);
            label146.TabIndex = 46;
            label146.Text = "label146";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 11;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(3, 0);
            label50.Name = "label50";
            label50.Size = new Size(56, 50);
            label50.TabIndex = 0;
            label50.Text = "Przedmiot";
            // 
            // butMojeDane
            // 
            butMojeDane.ForeColor = SystemColors.ActiveCaptionText;
            butMojeDane.Location = new Point(94, 11);
            butMojeDane.Margin = new Padding(2);
            butMojeDane.Name = "butMojeDane";
            butMojeDane.Size = new Size(130, 30);
            butMojeDane.TabIndex = 9;
            butMojeDane.Text = "Moje Dane";
            butMojeDane.UseVisualStyleBackColor = true;
            butMojeDane.Click += butMojeDane_Click;
            // 
            // planLekcjiText
            // 
            planLekcjiText.BackColor = Color.DimGray;
            planLekcjiText.BorderStyle = BorderStyle.None;
            planLekcjiText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            planLekcjiText.ForeColor = SystemColors.MenuBar;
            planLekcjiText.Location = new Point(3, 3);
            planLekcjiText.Multiline = true;
            planLekcjiText.Name = "planLekcjiText";
            planLekcjiText.ReadOnly = true;
            planLekcjiText.Size = new Size(831, 34);
            planLekcjiText.TabIndex = 10;
            planLekcjiText.Text = "Plan lekcji\r\n";
            // 
            // panelPlanLekcji
            // 
            panelPlanLekcji.AccessibleName = "planLekcji";
            panelPlanLekcji.Controls.Add(planLekcjiText);
            panelPlanLekcji.Controls.Add(tabelaPlanLekcji);
            panelPlanLekcji.Location = new Point(12, 46);
            panelPlanLekcji.Name = "panelPlanLekcji";
            panelPlanLekcji.Size = new Size(1157, 603);
            panelPlanLekcji.TabIndex = 11;
            // 
            // tabelaPlanLekcji
            // 
            tabelaPlanLekcji.BackgroundImageLayout = ImageLayout.None;
            tabelaPlanLekcji.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tabelaPlanLekcji.ColumnCount = 6;
            tabelaPlanLekcji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tabelaPlanLekcji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tabelaPlanLekcji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tabelaPlanLekcji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tabelaPlanLekcji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tabelaPlanLekcji.Location = new Point(3, 43);
            tabelaPlanLekcji.Name = "tabelaPlanLekcji";
            tabelaPlanLekcji.RowCount = 10;
            tabelaPlanLekcji.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelaPlanLekcji.Size = new Size(1154, 560);
            tabelaPlanLekcji.TabIndex = 11;
            // 
            // panelMojeDane
            // 
            panelMojeDane.AccessibleName = "mojeDane";
            panelMojeDane.Controls.Add(powitanieImie);
            panelMojeDane.Controls.Add(dataCzas);
            panelMojeDane.Location = new Point(12, 46);
            panelMojeDane.Name = "panelMojeDane";
            panelMojeDane.Size = new Size(1157, 603);
            panelMojeDane.TabIndex = 12;
            // 
            // powitanieImie
            // 
            powitanieImie.BackColor = Color.DimGray;
            powitanieImie.BorderStyle = BorderStyle.None;
            powitanieImie.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            powitanieImie.ForeColor = SystemColors.MenuBar;
            powitanieImie.Location = new Point(3, 3);
            powitanieImie.Multiline = true;
            powitanieImie.Name = "powitanieImie";
            powitanieImie.ReadOnly = true;
            powitanieImie.Size = new Size(529, 121);
            powitanieImie.TabIndex = 10;
            powitanieImie.Text = "Zalogowano jako: Imie Nazwisko";
            // 
            // dataCzas
            // 
            dataCzas.BackColor = Color.DimGray;
            dataCzas.BorderStyle = BorderStyle.None;
            dataCzas.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataCzas.ForeColor = SystemColors.MenuBar;
            dataCzas.Location = new Point(538, 3);
            dataCzas.Multiline = true;
            dataCzas.Name = "dataCzas";
            dataCzas.ReadOnly = true;
            dataCzas.Size = new Size(616, 121);
            dataCzas.TabIndex = 11;
            dataCzas.Text = "Zalogowano jako: Imie Nazwisko";
            dataCzas.TextAlign = HorizontalAlignment.Right;
            // 
            // panelOceny
            // 
            panelOceny.AccessibleName = "planLekcji";
            panelOceny.Controls.Add(ocenkiText);
            panelOceny.Controls.Add(tabelaOceny);
            panelOceny.Controls.Add(richLegenda);
            panelOceny.Location = new Point(12, 46);
            panelOceny.Name = "panelOceny";
            panelOceny.Size = new Size(1157, 603);
            panelOceny.TabIndex = 12;
            // 
            // ocenkiText
            // 
            ocenkiText.BackColor = Color.DimGray;
            ocenkiText.BorderStyle = BorderStyle.None;
            ocenkiText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ocenkiText.ForeColor = SystemColors.MenuBar;
            ocenkiText.Location = new Point(3, 3);
            ocenkiText.Multiline = true;
            ocenkiText.Name = "ocenkiText";
            ocenkiText.ReadOnly = true;
            ocenkiText.Size = new Size(685, 34);
            ocenkiText.TabIndex = 10;
            ocenkiText.Text = "Ocenki";
            // 
            // tabelaOceny
            // 
            tabelaOceny.BackColor = Color.DimGray;
            tabelaOceny.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tabelaOceny.ColumnCount = 3;
            tabelaOceny.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tabelaOceny.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tabelaOceny.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabelaOceny.Location = new Point(3, 43);
            tabelaOceny.Name = "tabelaOceny";
            tabelaOceny.RowCount = 13;
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tabelaOceny.Size = new Size(637, 560);
            tabelaOceny.TabIndex = 11;
            // 
            // richLegenda
            // 
            richLegenda.BackColor = Color.DimGray;
            richLegenda.BorderStyle = BorderStyle.None;
            richLegenda.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            richLegenda.ForeColor = Color.WhiteSmoke;
            richLegenda.Location = new Point(646, 43);
            richLegenda.Name = "richLegenda";
            richLegenda.ReadOnly = true;
            richLegenda.Size = new Size(448, 208);
            richLegenda.TabIndex = 12;
            richLegenda.Text = "LEGENDA\nS - sprawdzian\nK - kartkówka\nO - odpowiedź ustna\nP - praca domowa\n";
            // 
            // TextboxFrekwencja
            // 
            TextboxFrekwencja.BackColor = SystemColors.ControlDarkDark;
            TextboxFrekwencja.BorderStyle = BorderStyle.FixedSingle;
            TextboxFrekwencja.Dock = DockStyle.Top;
            TextboxFrekwencja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TextboxFrekwencja.ForeColor = SystemColors.HighlightText;
            TextboxFrekwencja.Location = new Point(3, 3);
            TextboxFrekwencja.Name = "TextboxFrekwencja";
            TextboxFrekwencja.Size = new Size(799, 35);
            TextboxFrekwencja.TabIndex = 12;
            TextboxFrekwencja.Text = "Frekwencja";
            // 
            // frtab
            // 
            dataGridViewCellStyle1.NullValue = null;
            frtab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            frtab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            frtab.Columns.AddRange(new DataGridViewColumn[] { Data, Ilość_nieobecności });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            frtab.DefaultCellStyle = dataGridViewCellStyle4;
            frtab.Dock = DockStyle.Bottom;
            frtab.GridColor = SystemColors.ActiveBorder;
            frtab.Location = new Point(3, 44);
            frtab.Name = "frtab";
            frtab.ReadOnly = true;
            frtab.RowTemplate.Height = 25;
            frtab.Size = new Size(763, 552);
            frtab.TabIndex = 12;
            // 
            // Data
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            Data.DefaultCellStyle = dataGridViewCellStyle2;
            Data.Frozen = true;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.Resizable = DataGridViewTriState.False;
            Data.Width = 360;
            // 
            // Ilość_nieobecności
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            Ilość_nieobecności.DefaultCellStyle = dataGridViewCellStyle3;
            Ilość_nieobecności.Frozen = true;
            Ilość_nieobecności.HeaderText = "Ilość nieobecności";
            Ilość_nieobecności.Name = "Ilość_nieobecności";
            Ilość_nieobecności.ReadOnly = true;
            Ilość_nieobecności.Resizable = DataGridViewTriState.False;
            Ilość_nieobecności.Width = 360;
            // 
            // panelFrekwencja
            // 
            panelFrekwencja.BackColor = SystemColors.ControlDarkDark;
            panelFrekwencja.Controls.Add(TextboxFrekwencja);
            panelFrekwencja.Controls.Add(frtab);
            panelFrekwencja.Controls.Add(uspr);
            panelFrekwencja.ForeColor = SystemColors.ActiveCaptionText;
            panelFrekwencja.Location = new Point(12, 46);
            panelFrekwencja.Name = "panelFrekwencja";
            panelFrekwencja.Size = new Size(1157, 612);
            panelFrekwencja.TabIndex = 13;
            // 
            // uspr
            // 
            uspr.Location = new Point(772, 44);
            uspr.Name = "uspr";
            uspr.Size = new Size(252, 68);
            uspr.TabIndex = 13;
            uspr.Text = "Usprawiedliwienie godzin";
            uspr.UseVisualStyleBackColor = true;
            uspr.Click += uspr_Click;
            // 
            // panelSprawdziany
            // 
            panelSprawdziany.Controls.Add(SPRtext);
            panelSprawdziany.Controls.Add(sprawdziany_tabelka);
            panelSprawdziany.Location = new Point(12, 46);
            panelSprawdziany.Name = "panelSprawdziany";
            panelSprawdziany.Size = new Size(1157, 612);
            panelSprawdziany.TabIndex = 13;
            // 
            // SPRtext
            // 
            SPRtext.BackColor = SystemColors.ControlDarkDark;
            SPRtext.BorderStyle = BorderStyle.None;
            SPRtext.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SPRtext.ForeColor = SystemColors.MenuBar;
            SPRtext.Location = new Point(3, 3);
            SPRtext.Name = "SPRtext";
            SPRtext.Size = new Size(1095, 28);
            SPRtext.TabIndex = 1;
            SPRtext.Text = "Terminy sprawdzianów";
            // 
            // sprawdziany_tabelka
            // 
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            sprawdziany_tabelka.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            sprawdziany_tabelka.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sprawdziany_tabelka.Columns.AddRange(new DataGridViewColumn[] { sheduled_date, entry_date, subject, teacher, comment, test_type });
            sprawdziany_tabelka.Location = new Point(3, 37);
            sprawdziany_tabelka.Name = "sprawdziany_tabelka";
            sprawdziany_tabelka.RowTemplate.Height = 25;
            sprawdziany_tabelka.Size = new Size(1154, 559);
            sprawdziany_tabelka.TabIndex = 0;
            // 
            // sheduled_date
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            sheduled_date.DefaultCellStyle = dataGridViewCellStyle6;
            sheduled_date.Frozen = true;
            sheduled_date.HeaderText = "Termin sprawdzianu";
            sheduled_date.Name = "sheduled_date";
            sheduled_date.ReadOnly = true;
            sheduled_date.Width = 185;
            // 
            // entry_date
            // 
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            entry_date.DefaultCellStyle = dataGridViewCellStyle7;
            entry_date.Frozen = true;
            entry_date.HeaderText = "Data wpisania";
            entry_date.Name = "entry_date";
            entry_date.ReadOnly = true;
            entry_date.Width = 185;
            // 
            // subject
            // 
            dataGridViewCellStyle8.ForeColor = Color.Black;
            subject.DefaultCellStyle = dataGridViewCellStyle8;
            subject.Frozen = true;
            subject.HeaderText = "Przedmiot";
            subject.Name = "subject";
            subject.ReadOnly = true;
            subject.Width = 185;
            // 
            // teacher
            // 
            dataGridViewCellStyle9.ForeColor = Color.Black;
            teacher.DefaultCellStyle = dataGridViewCellStyle9;
            teacher.Frozen = true;
            teacher.HeaderText = "Nauczyciel";
            teacher.Name = "teacher";
            teacher.ReadOnly = true;
            teacher.Width = 185;
            // 
            // comment
            // 
            dataGridViewCellStyle10.ForeColor = Color.Black;
            comment.DefaultCellStyle = dataGridViewCellStyle10;
            comment.Frozen = true;
            comment.HeaderText = "Temat sprawdzianu";
            comment.Name = "comment";
            comment.ReadOnly = true;
            comment.Width = 185;
            // 
            // test_type
            // 
            dataGridViewCellStyle11.ForeColor = Color.Black;
            test_type.DefaultCellStyle = dataGridViewCellStyle11;
            test_type.Frozen = true;
            test_type.HeaderText = "Typ sprawdzianu";
            test_type.Name = "test_type";
            test_type.ReadOnly = true;
            test_type.Width = 185;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.ForeColor = Color.DimGray;
            id_label.Location = new Point(471, 9);
            id_label.Name = "id_label";
            id_label.Size = new Size(38, 15);
            id_label.TabIndex = 14;
            id_label.Text = "label1";
            // 
            // loading
            // 
            loading.AccessibleName = "mojeDane";
            loading.Location = new Point(9, 46);
            loading.Name = "loading";
            loading.Size = new Size(1160, 603);
            loading.TabIndex = 13;
            // 
            // WidokUczen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1181, 696);
            Controls.Add(id_label);
            Controls.Add(butMojeDane);
            Controls.Add(butPowrot1);
            Controls.Add(butTerminy);
            Controls.Add(butFrek);
            Controls.Add(butOceny);
            Controls.Add(butPlanLek);
            Controls.Add(panelFrekwencja);
            Controls.Add(panelSprawdziany);
            Controls.Add(loading);
            Controls.Add(panelMojeDane);
            Controls.Add(panelOceny);
            Controls.Add(panelPlanLekcji);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "WidokUczen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "E-Dziennik Uczeń";
            Load += WidokUczen_Load_1;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panelPlanLekcji.ResumeLayout(false);
            panelPlanLekcji.PerformLayout();
            panelMojeDane.ResumeLayout(false);
            panelMojeDane.PerformLayout();
            panelOceny.ResumeLayout(false);
            panelOceny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)frtab).EndInit();
            panelFrekwencja.ResumeLayout(false);
            panelFrekwencja.PerformLayout();
            panelSprawdziany.ResumeLayout(false);
            panelSprawdziany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sprawdziany_tabelka).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butPlanLek;
        private Button butOceny;
        private Button butFrek;
        private Button butTerminy;
        private Button butPowrot1;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label145;
        private Label label146;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label50;
        private Button butMojeDane;
        private TextBox planLekcjiText;
        private FlowLayoutPanel panelPlanLekcji;
        private FlowLayoutPanel panelMojeDane;
        private TextBox powitanieImie;
        private FlowLayoutPanel panelOceny;
        private TextBox ocenkiText;
        private TableLayoutPanel tabelaOceny;

        private DataGridView frtab;
        private FlowLayoutPanel panelFrekwencja;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Ilość_nieobecności;
        private TextBox TextboxFrekwencja;
        private FlowLayoutPanel panelSprawdziany;
        private DataGridView sprawdziany_tabelka;
        private TextBox SPRtext;
        private DataGridViewTextBoxColumn sheduled_date;
        private DataGridViewTextBoxColumn entry_date;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn teacher;
        private DataGridViewTextBoxColumn comment;
        private DataGridViewTextBoxColumn test_type;
        private Button uspr;
        private Label id_label;

        private RichTextBox richLegenda;
        private TableLayoutPanel tabelaPlanLekcji;
        private TextBox dataCzas;
        private FlowLayoutPanel loading;
    }
}