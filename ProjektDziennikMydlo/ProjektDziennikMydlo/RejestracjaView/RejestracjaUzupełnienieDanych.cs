using MySql.Data.MySqlClient;
using ProjektDziennikMydlo.RejestracjaView.Eventy;
using ProjektDziennikMydlo.RejestracjaView.Modele;

namespace ProjektDziennikMydlo.RejestracjaView
{
    public partial class RejestracjaUzupełnienieDanych : Form
    {
        public event EventHandler<DodanieUczniaEvent> DodanieUczniaEvent;

        public RejestracjaUzupełnienieDanych()
        {
            InitializeComponent();
            textBoxImie.Focus();
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
            DodajUcznia();
        }

        private void DodajUcznia()
        {
            var imie = this.textBoxImie.Text;
            var nazwisko = this.textBoxNazwisko.Text;
            var pesel = this.textBoxPesel.Text;
            var email = this.textBoxEmail.Text;
            var dataUrodzenia = this.dateTimePickerDataUrodzenia.Value;
            var klasa = this.comboBoxKlasa.SelectedValue as Klasa;

            var gdzieDaneNieprawidłowe = new List<string>();
            if (String.IsNullOrEmpty(imie))
            {
                gdzieDaneNieprawidłowe.Add("Imie");
            }

            if (String.IsNullOrEmpty(nazwisko))
            {
                gdzieDaneNieprawidłowe.Add("Nazwisko");
            }

            if (!IsEmailValid(email))
            {
                gdzieDaneNieprawidłowe.Add("Email");
            }

            if (String.IsNullOrEmpty(pesel) || pesel.Length != 11)
            {
                gdzieDaneNieprawidłowe.Add("Pesel");
            }

            if (this.comboBoxKlasa.SelectedValue == null)
            {
                gdzieDaneNieprawidłowe.Add("Klasa");
            }

            if (gdzieDaneNieprawidłowe.Any())
            {
                var nieprawidłowedaneString = string.Join("\n- ", gdzieDaneNieprawidłowe);
                MessageBox.Show($"Nieprawidłowe dane w: \n- {nieprawidłowedaneString}");
                return;
            }

            var uczeń = new Uczeń()
            {
                Imię = imie,
                Nazwisko = nazwisko,
                Email = email,
                Pesel = pesel,
                DataUrodzenia = $"{dataUrodzenia.Year}-{dataUrodzenia.Month}-{dataUrodzenia.Day}",
                Klasa = Int32.Parse(klasa.Id),
            };

            DodanieUczniaEvent?.Invoke(this, new DodanieUczniaEvent(uczeń));
            this.Hide();
            this.Close();
        }

        private void textBoxPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private bool IsEmailValid(string email)
        {
            try
            {
                new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
