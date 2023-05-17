using ProjektDziennikMydlo.RejestracjaView.Eventy;
using ProjektDziennikMydlo.RejestracjaView.Modele;
using ProjektDziennikMydlo.RejestracjaView.Serwisy;

namespace ProjektDziennikMydlo.RejestracjaView
{
    public partial class Rejestracja : Form
    {
        private List<Uczeń> UczniowieLista { get; set; } = new();
        public Rejestracja()
        {
            InitializeComponent();
            dataGridViewUczniowie.Columns.Add("Imię", "Imię");
            dataGridViewUczniowie.Columns.Add("Nazwisko", "Nazwisko");
            dataGridViewUczniowie.Columns.Add("Email", "Email");
            dataGridViewUczniowie.Columns.Add("Pesel", "Pesel");
            dataGridViewUczniowie.Columns.Add("DataUrodzenia", "Data Urodzenia");
            dataGridViewUczniowie.Columns.Add("Klasa", "Klasa");
        }

        private void buttonDodajUcznia_Click(object sender, EventArgs e)
        {
            var rejestracjaUzupełnianie = new RejestracjaUzupełnienieDanych();
            rejestracjaUzupełnianie.DodanieUczniaEvent += childForm_MyEvent;
            rejestracjaUzupełnianie.Show();
        }

        private void childForm_MyEvent(object sender, DodanieUczniaEvent e)
        {
            DataGridViewRow newRow = new DataGridViewRow();

            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            cell1.Value = e.Uczeń.Imię;
            newRow.Cells.Add(cell1);

            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
            cell2.Value = e.Uczeń.Nazwisko;
            newRow.Cells.Add(cell2);

            DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
            cell3.Value = e.Uczeń.Email;
            newRow.Cells.Add(cell3);

            DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
            cell4.Value = e.Uczeń.Pesel;
            newRow.Cells.Add(cell4);

            DataGridViewTextBoxCell cell5 = new DataGridViewTextBoxCell();
            cell5.Value = e.Uczeń.DataUrodzenia;
            newRow.Cells.Add(cell5);

            DataGridViewTextBoxCell cell6 = new DataGridViewTextBoxCell();
            cell6.Value = e.Uczeń.Klasa;
            newRow.Cells.Add(cell6);

            UczniowieLista.Add(e.Uczeń);
            dataGridViewUczniowie.Rows.Add(newRow);
        }
        
        private void dataGridViewUczniowie_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
                dataGridViewUczniowie.ContextMenuStrip = contextMenuStrip1;

                ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Usuń");
                menuItem2.Tag = e.RowIndex;
                menuItem2.Click += MenuItem1_Click;
                contextMenuStrip1.Items.Add(menuItem2);
            }
        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            dataGridViewUczniowie.Rows.RemoveAt((int)clickedItem.Tag);
            UczniowieLista.RemoveAt((int)clickedItem.Tag);
        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {
            var rejestracjaSerwis = new RejestracjaSerwis();
            rejestracjaSerwis.ZapiszNowychUczniów(UczniowieLista);
            this.Hide();
            this.Close();
        }
    }
}
