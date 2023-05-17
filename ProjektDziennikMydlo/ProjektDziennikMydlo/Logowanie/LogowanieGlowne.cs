using ProjektDziennikMydlo.Logowanie.Serwisy;

namespace ProjektDziennikMydlo
{
    public partial class LogowanieGlowne : Form
    {
        private readonly bool _czyUczeń;
        public static string mailZalogowanego = "";
        public LogowanieGlowne(bool czyUczeń)
        {
            _czyUczeń = czyUczeń;
            if(_czyUczeń)
            {
                this.Text = "E-Dziennik -> Logowanie Uczeń";
            } else
            {
                this.Text = "E-Dziennik -> Logowanie Pracownik";
            }
            InitializeComponent();
            emailInput.Focus();
        }

        private void ButtonZaloguj(object sender, EventArgs e)
        {
            var emailInput = this.emailInput.Text;
            var passwordInput = this.passwordInput.Text;

            if(String.IsNullOrEmpty(emailInput) || String.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Hasło oraz email nie mogą być puste!");
                this.WyczyśćInputy();
                return;
            }

            var logowanieSerwis = new LogowanieSerwis();
            var logowanieInfo = logowanieSerwis.Zaloguj(emailInput, passwordInput, _czyUczeń);
            if(logowanieInfo.czyZalogowano && _czyUczeń)
            {
                this.Hide();
                var widokUczeń= new WidokUczen();
                mailZalogowanego = emailInput.ToString();
                widokUczeń.ShowDialog();
                this.Close();
                return;
            } else if(logowanieInfo.czyZalogowano && !_czyUczeń)
            {
                this.Hide();
                var widokPracownik = new WidokPracownik(logowanieInfo.Rola);
                widokPracownik.ShowDialog();
                this.Close();
                return;
            }

            this.WyczyśćInputy();
            MessageBox.Show("Hasło lub email nieprawidłowe!");
        }

        private void WyczyśćInputy()
        {
            this.emailInput.Text = String.Empty;
            this.passwordInput.Text = String.Empty;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var widokInicialny = new Form1();
            widokInicialny.ShowDialog();
        }
    }
}
