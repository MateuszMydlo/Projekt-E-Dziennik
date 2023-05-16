namespace ProjektDziennikMydlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDalej(object sender, EventArgs e)
        {
            if (radioPracownik.Checked)
            {
                this.Hide();
                var logowanieGlowne = new LogowanieGlowne(false);
                logowanieGlowne.ShowDialog();
                this.Close();
            }
            else if (radioUczen.Checked)
            {
                this.Hide();
                var logowanieGlowne = new LogowanieGlowne(true);
                logowanieGlowne.ShowDialog();
                this.Close();
            }
        }

        #region ZMIENNE GLOBALNE
        public static class MyGlobals //zmienne dostêpne globalnie w ca³ym APP
        {
            public static string connSTR = "server=localhost;user=root;database=dziennik;port=3306;password=1234";
            public static int id_uzytkownika = 0;
            public static string adres_ip_serwera = File.ReadAllText("adres_ip_serwera");
            public static string port_serwera = File.ReadAllText("port_serwera");
            public static string imie = "";
            public static string nazwisko = "";
            public static string email = "";
            public static string haslo = "";
            public static int id_klasy = 0;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}