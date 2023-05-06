using ProjektDziennikMydlo.Logowanie.Serwisy;

namespace ProjektDziennikMydlo
{
    public partial class LogowanieGlowne : Form
    {
        private bool _czyUczeń { get; set; }
        public LogowanieGlowne(bool czyUczeń)
        {
            _czyUczeń = czyUczeń;
            InitializeComponent();
        }

        private void ButtonZaloguj(object sender, EventArgs e)
        {
            var logowanieSerwis = new LogowanieSerwis();
            var logowanieInfo = logowanieSerwis.Zaloguj("username", "password", _czyUczeń);

            if(logowanieInfo.czyZalogowano && _czyUczeń)
            {
                this.Hide();
                var widokUczeń= new WidokUczen();
                widokUczeń.ShowDialog();
                this.Close();
            } else
            {
                this.Hide();
                var widokPracownik = new WidokPracownik();
                widokPracownik.ShowDialog();
                this.Close();
            }
        }

        private void LogowanieGlowne_Load(object sender, EventArgs e)
        {

        }
    }
}
