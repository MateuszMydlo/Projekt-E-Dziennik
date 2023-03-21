namespace ProjektDziennikMydlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogowaniePracownik f2 = new LogowaniePracownik();
            f2.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioPracownik.Checked)
            {
                this.Hide();
                LogowaniePracownik f2 = new LogowaniePracownik();
                f2.ShowDialog();
                this.Close();
            }
            else if (radioUczen.Checked)
            {
                this.Hide();
                LogowanieUczen f3 = new LogowanieUczen();
                f3.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Rejestracja f7 = new Rejestracja();
            f7.ShowDialog();
            this.Close();

        }
    }
}