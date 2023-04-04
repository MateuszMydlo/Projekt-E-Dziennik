using System.Data.SqlClient;

namespace ProjektDziennikMydlo
{
    #region FUNKCJE
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
        #endregion
        #region ZMIENNE GLOBALNE

        public static class MyGlobals //zmienne dostêpne globalnie w ca³ym APP
        {
            public static string connSTR = "datasource=" + File.ReadAllText("adres_ip_serwera") + ";port=" + File.ReadAllText("port_serwera") + ";username=root;password=;database=dziennik; Convert Zero Datetime=True; ";
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
    }

}