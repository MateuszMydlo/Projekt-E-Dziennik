using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjektDziennikMydlo
{
    public partial class WidokUczen : Form
    {
        static string connectionString = Form1.MyGlobals.connSTR; //pobiera string globalny wymagany do polaczenia sie z DB
        MySqlConnection conn = new MySqlConnection(connectionString);


        List<Panel> listPanel = new List<Panel>();
        int index;
        public WidokUczen()
        {
            InitializeComponent();
        }

        private void butPowrot1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogowanieGlowne f3 = new LogowanieGlowne(true);
            f3.ShowDialog();
            this.Close();
        }

        #region Frankowe
        private void WidokUczen_Load_1(object sender, EventArgs e)
        {
            string ktoZalogowany = LogowanieGlowne.mailZalogowanego;
            string query = $"SELECT name, surname FROM students WHERE email = '{ktoZalogowany}'";//kwerenda
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

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Open();
            result = exec.ExecuteReader();
            result.Read();

            string studentName = $"{result[0]} {result[1]}";
            powitanieImie.Text = $"Zalogowano jako: {studentName}";
            panelMojeDane.BringToFront();
            conn.Close();
        }

        private void butMojeDane_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            WidokUczen f5 = new WidokUczen();
            f5.ShowDialog();
            this.Close();*/
            panelMojeDane.BringToFront();
            string query = "SELECT name, surname FROM students WHERE id_student = 1";
        }

        private void butPlanLek_Click(object sender, EventArgs e)
        {
            panelPlanLekcji.BringToFront();
        }

        private void butOceny_Click(object sender, EventArgs e)
        {
            panelOceny.BringToFront();

            // Creating a label
            Label label = new Label();
            label.Text = "Polski";

            // Add the label control to the TableLayoutPanel in the second row and third column
            tabelaOceny.Controls.Add(label, 0, 1);
        }

        #endregion

        #region Kamilowe
        //FREKWENCJA

        private void butFrek_Click(object sender, EventArgs e)
        {
            panelFrekwencja.BringToFront();
            //pobieranie id ucznia
            string id_uczen = null;
            string zalogowany_uczen = LogowanieGlowne.mailZalogowanego;
            string sql1 = $"SELECT id_student FROM students WHERE email = '{zalogowany_uczen}'";
            MySqlConnection polaczenie1 = new MySqlConnection(connectionString);
            MySqlCommand cmd1 = new MySqlCommand(sql1, polaczenie1);
            cmd1.CommandTimeout = 60;
            MySqlDataReader result;
            try
            {
                polaczenie1.Open();
                result = cmd1.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {

                    }
                    polaczenie1.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            polaczenie1.Open();
            result = cmd1.ExecuteReader();
            result.Read();
            id_uczen = $"{result[0]}";
            id_label.Text = id_uczen;
            polaczenie1.Close();

            int id_uczeń = int.Parse(id_uczen);
            //pobieranie danych do tabelek
            string sql2 = $"SELECT attendance_date as \"Data\", count(present) as \"Ilość nieobecności\" FROM attendance WHERE present=0 AND student='{id_uczeń}' group by attendance_date;";
            MySqlConnection polaczenie2 = new MySqlConnection(connectionString);
            try
            {
                //otwórz połączenie z bazą danych
                polaczenie2.Open();
                //wykonaj polecenie SQL
                using (MySqlCommand cmd2 = new MySqlCommand(sql2, polaczenie2))
                {
                    MySqlDataReader reader = cmd2.ExecuteReader();
                    frtab.Rows.Clear();
                    while (reader.Read())
                    {
                        frtab.Rows.Add(reader["Data"], reader["Ilość nieobecności"]);
                    }

                    reader.Close();

                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd połączenia z bazą danych");
            }
            polaczenie2.Close();
        }
        private void butTerminy_Click(object sender, EventArgs e)
        {
            panelSprawdziany.BringToFront();

            //pobieranie danych o klasie ucznia
            string klasa_uczen = null;
            string zalogowany_uczen = LogowanieGlowne.mailZalogowanego;
            string sql1 = $"SELECT class FROM students WHERE email = '{zalogowany_uczen}'";
            MySqlConnection polaczenie1 = new MySqlConnection(connectionString);
            MySqlCommand cmd1 = new MySqlCommand(sql1, polaczenie1);
            cmd1.CommandTimeout = 60;
            MySqlDataReader result;
            try
            {
                polaczenie1.Open();
                result = cmd1.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {

                    }
                    polaczenie1.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            polaczenie1.Open();
            result = cmd1.ExecuteReader();
            result.Read();
            klasa_uczen = $"{result[0]}";
            int klasa_uczeń = int.Parse(klasa_uczen);
            polaczenie1.Close();



            string sql2 = $"select sheduled_date as \"Termin sprawdzianu\", entry_date as \"Data wpisania\", subject as \"Przedmiot\", teacher as \"Nauczyciel\", comment as \"Temat\", test_type as \"Typ testu\" from test_schedule where class = '{klasa_uczen}'";
            MySqlConnection polaczenie2 = new MySqlConnection(connectionString);
            try
            {
                //otwórz połączenie z bazą danych
                polaczenie2.Open();
                //wykonaj polecenie SQL
                using (MySqlCommand cmd2 = new MySqlCommand(sql2, polaczenie2))
                {
                    MySqlDataReader reader = cmd2.ExecuteReader();
                    frtab.Rows.Clear();
                    while (reader.Read())
                    {
                        sprawdziany_tabelka.Rows.Add(reader["Termin sprawdzianu"], reader["Data wpisania"], reader["Przedmiot"], reader["Nauczyciel"], reader["Temat"], reader["Typ testu"]);
                    }

                    reader.Close();

                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd połączenia z bazą danych");
            }
            polaczenie2.Close();

        }

        private void uspr_Click(object sender, EventArgs e)
        {
            int id_uczen=int.Parse(id_label.Text);
            int columnIndex = 1;
            DataGridViewRow selectedRow = frtab.CurrentRow;
            string currentValue = selectedRow.Cells[columnIndex].Value.ToString();

            if (currentValue=="1") 
            {
                
                int newValue = 1;
                selectedRow.Cells[columnIndex].Value = 0;
                MySqlConnection polaczenie1 = new MySqlConnection("connectionString");
                string sql1 = $"UPDATE attendance SET present='{newValue}' WHERE id_student='{id_uczen}'";
                try
                {
                    polaczenie1.Open();
                    MySqlCommand cmd1 = new MySqlCommand(sql1, polaczenie1);
                    cmd1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie udało się zmienić wartości w bazie danych");
                }
                polaczenie1.Close();
                
                

                

            }
            else
            {
                MessageBox.Show("Brak godzin do usprawiedliwienia");
            }

        }
        #endregion




    }
}