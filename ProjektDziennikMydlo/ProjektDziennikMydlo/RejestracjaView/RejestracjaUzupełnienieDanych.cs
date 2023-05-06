using MySql.Data.MySqlClient;
using ProjektDziennikMydlo.RejestracjaView.Modele;

namespace ProjektDziennikMydlo.RejestracjaView
{
    public partial class RejestracjaUzupełnienieDanych : Form
    {
        public event EventHandler MyEvent;

        public RejestracjaUzupełnienieDanych()
        {
            InitializeComponent();
            var klasy = this.pobierzKlasy();

            comboBoxKlasa.ValueMember = null;
            comboBoxKlasa.DisplayMember = "Name";
            comboBoxKlasa.DataSource = klasy;
        }

        private List<Klasa> pobierzKlasy()
        {
            var listaKlas = new List<Klasa>();
            string connectionString = Form1.MyGlobals.connSTR;//pobiera string globalny wymagany do polaczenia sie z DB

            string query = $"SELECT id_class, year, subclass FROM classes";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand exec = new MySqlCommand(query, conn);
            exec.CommandTimeout = 60;
            MySqlDataReader result;
            try
            {
                conn.Open();
                result = exec.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {

                        var idKlasy = result.GetString(0);
                        var klasa = result.GetString(1);
                        var subklasa = result.GetString(2);

                        listaKlas.Add(new Klasa()
                        {
                            Id = idKlasy,
                            Name = $"{klasa} {subklasa}"
                        });
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                return listaKlas;
            }
            return listaKlas;
        }
        

        private void ButtonDodajUcznia_Click(object sender, EventArgs e)
        {
            var imie = this.textBoxImie.Text;
            var nazwisko = this.textBoxNazwisko.Text;
            var pesel = this.textBoxPesel.Text;
            var email = this.textBoxEmail.Text;
            var dataUrodzenia = this.dateTimePickerDataUrodzenia.Value;
            var klasa = this.comboBoxKlasa.SelectedValue as Klasa;

            var uczeń = new Uczeń()
            {
                 Imię=imie,
                 Nazwisko=nazwisko,
                 Email=email,
                 Pesel=pesel,
                 DataUrodzenia=$"{dataUrodzenia.Year}-{dataUrodzenia.Month}-{dataUrodzenia.Day}",
                 Klasa=Int32.Parse(klasa.Id),
            };

            MyEvent(this, e);
            this.Hide();
            this.Close();
        }
    }

    public class SomeEventHandler
    {
    }
}
