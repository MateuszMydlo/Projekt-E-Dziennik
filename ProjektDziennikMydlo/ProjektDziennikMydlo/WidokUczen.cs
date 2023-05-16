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
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;



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

        private System.Windows.Forms.Timer timer;
        private void autoUpdateCzasu()
        {
            dataCzas.Text = DateTime.Now.ToString();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Update every second
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            dataCzas.Text = DateTime.Now.ToString();
        }
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
            conn.Close();

            autoUpdateCzasu();
            timer.Start();

            panelMojeDane.BringToFront();

        }
        private void butMojeDane_Click(object sender, EventArgs e)
        {
            panelMojeDane.BringToFront();
        }
        private void butPlanLek_Click(object sender, EventArgs e)
        {
            loading.BringToFront();
            //panelPlanLekcji.BringToFront();
            string ktoZalogowany = LogowanieGlowne.mailZalogowanego;
            Control cellControl;

            string query;
            MySqlCommand exec;
            MySqlDataReader result;

            int jakiDzien = 0; ;

            //dni tygodnia
            for (int i = 0; i < 6; i++)
            {
                cellControl = tabelaPlanLekcji.GetControlFromPosition(i, 0);
                if (!(cellControl is RichTextBox))
                {
                    RichTextBox label = new RichTextBox();
                    label.Dock = DockStyle.Fill;
                    label.BackColor = Color.DimGray;
                    label.ReadOnly = true;
                    //label.Enabled = false;
                    label.BorderStyle = BorderStyle.None;
                    label.SelectionColor = Color.WhiteSmoke;
                    label.SelectionFont = new Font(label.Font.FontFamily, 16);

                    label.SelectionAlignment = HorizontalAlignment.Center;
                    switch (i)
                    {
                        case 0:
                            label.AppendText($"Godzina");
                            break;
                        case 1:
                            label.AppendText($"Poniedziałek");
                            break;
                        case 2:
                            label.AppendText($"Wtorek");
                            break;
                        case 3:
                            label.AppendText($"Środa");
                            break;
                        case 4:
                            label.AppendText($"Czwartek");
                            break;
                        case 5:
                            label.AppendText($"Piątek");
                            break;
                    }
                    tabelaPlanLekcji.Controls.Add(label, i, 0);
                    tabelaPlanLekcji.Controls.Remove(cellControl);

                }
            }

            //godziny
            for (int i = 1; i < 10; i++)
            {
                cellControl = tabelaPlanLekcji.GetControlFromPosition(0, i);
                if (!(cellControl is RichTextBox))
                {
                    RichTextBox label = new RichTextBox();
                    label.Dock = DockStyle.Fill;
                    label.BackColor = Color.DimGray;
                    label.ReadOnly = true;
                    //label.Enabled = false;
                    label.BorderStyle = BorderStyle.None;
                    label.SelectionColor = Color.WhiteSmoke;
                    label.SelectionFont = new Font(label.Font.FontFamily, 16);

                    label.SelectionAlignment = HorizontalAlignment.Center;
                    switch (i)
                    {
                        case 1:
                            label.AppendText($"7:00");
                            break;
                        case 2:
                            label.AppendText($"8:00");
                            break;
                        case 3:
                            label.AppendText($"9:00");
                            break;
                        case 4:
                            label.AppendText($"10:00");
                            break;
                        case 5:
                            label.AppendText($"11:00");
                            break;
                        case 6:
                            label.AppendText($"12:00");
                            break;
                        case 7:
                            label.AppendText($"13:00");
                            break;
                        case 8:
                            label.AppendText($"14:00");
                            break;
                        case 9:
                            label.AppendText($"15:00");
                            break;
                    }
                    tabelaPlanLekcji.Controls.Add(label, 0, i);
                    tabelaPlanLekcji.Controls.Remove(cellControl);

                }
            }

            //plan lekcji
            for (int i = 1; i < 6; i++) //przechodzi po kolumnach
            {
                switch (i)
                {
                    case 1:
                        jakiDzien = 2;
                        break;
                    case 2:
                        jakiDzien = 3;
                        break;
                    case 3:
                        jakiDzien = 4;
                        break;
                    case 4:
                        jakiDzien = 5;
                        break;
                    case 5:
                        jakiDzien = 6;
                        break;
                } //ustala jaki jest dzień
                for (int j = 1; j < 10; j++) //przechodzi po wierszach
                {
                    cellControl = tabelaPlanLekcji.GetControlFromPosition(i, j);
                    if (!(cellControl is RichTextBox))
                    {
                        RichTextBox label = new RichTextBox();
                        label.Dock = DockStyle.Fill;
                        label.BackColor = Color.Gray;
                        label.ReadOnly = true;
                        label.BorderStyle = BorderStyle.None;
                        label.SelectionColor = Color.WhiteSmoke;
                        label.SelectionFont = new Font(label.Font.FontFamily, 12);
                        label.SelectionAlignment = HorizontalAlignment.Center;
                        int godzina = j + 6;
                        query = $"SELECT subjects.name, teachers.name, teachers.surname FROM timetable "
                            + $"INNER JOIN classes ON timetable.class = classes.id_class "
                            + $"INNER JOIN students ON classes.id_class = students.class "
                            + $"INNER JOIN teachers ON timetable.teacher = teachers.id_teacher "
                            + $"INNER JOIN subjects ON timetable.subject = subjects.id_subject "
                            + $"WHERE day_of_the_week = {jakiDzien} AND students.email = '{ktoZalogowany}' AND hour = {godzina}";

                        exec = new MySqlCommand(query, conn);
                        conn.Open();
                        result = exec.ExecuteReader();
                        if (result.HasRows)
                        {
                            result.Read();
                            label.AppendText($"{result[0]}\n{result[1]} {result[2]}");
                            tabelaPlanLekcji.Controls.Add(label, i, j);
                            tabelaPlanLekcji.Controls.Remove(cellControl);
                        }
                        conn.Close();
                    }

                }
            }

            panelPlanLekcji.BringToFront();
        }
        public int[] ileMaOcen(string ktoZalogowany)
        {
            string query;
            MySqlCommand exec;
            MySqlDataReader result;

            int[] ileOcen = new int[12];

            //zlicza ile ocen jest z dalego przedmiotu i wpisuje do tablicy
            for (int i = 0; i < ileOcen.Length; i++)
            {
                query = $"SELECT COUNT(grade) FROM grades INNER JOIN students ON grades.student = students.id_student WHERE students.email = '{ktoZalogowany}' AND subject={i + 3}";
                exec = new MySqlCommand(query, conn);
                conn.Open();
                result = exec.ExecuteReader();
                result.Read();
                ileOcen[i] = result.GetInt32(0);
                conn.Close();
            }
            return ileOcen;
        }
        public bool czyPusta(int ocenki, RichTextBox label)
        {
            if (ocenki == 0)
            {
                label.SelectionColor = Color.WhiteSmoke;
                label.AppendText("Brak ocen.");
                return true;
            }
            return false;
        }
        private void butOceny_Click(object sender, EventArgs e)
        {
            loading.BringToFront();
            string ktoZalogowany = LogowanieGlowne.mailZalogowanego;

            #region Legenda
            richLegenda.Dock = DockStyle.Fill;

            richLegenda.Text = "";

            richLegenda.SelectionFont = new Font(richLegenda.Font.FontFamily, 20);
            richLegenda.SelectionColor = Color.WhiteSmoke;
            richLegenda.AppendText("   LEGENDA\n");

            richLegenda.SelectionFont = new Font(richLegenda.Font.FontFamily, 15);
            richLegenda.SelectionColor = Color.Red;
            richLegenda.AppendText("     S");
            richLegenda.SelectionColor = Color.WhiteSmoke;
            richLegenda.AppendText(" - Sprawdzian\n");

            richLegenda.SelectionColor = Color.DeepSkyBlue;
            richLegenda.AppendText("    K");
            richLegenda.SelectionColor = Color.WhiteSmoke;
            richLegenda.AppendText(" - Kartkówka\n");

            richLegenda.SelectionColor = Color.White;
            richLegenda.AppendText("    O");
            richLegenda.SelectionColor = Color.WhiteSmoke;
            richLegenda.AppendText(" - Odpowiedź ustna\n");

            richLegenda.SelectionColor = Color.YellowGreen;
            richLegenda.AppendText("    P");
            richLegenda.SelectionColor = Color.WhiteSmoke;
            richLegenda.AppendText(" - Praca domowa");
            #endregion

            #region wypełnienie tabeli

            string query;
            MySqlCommand exec;
            MySqlDataReader result;

            int[] ileOcen = new int[12];
            ileOcen = ileMaOcen(ktoZalogowany);

            //int rozmiar = ileOcen.Count(n => n != 0);
            int rozmiar = 0;
            foreach (int i in ileOcen)
            {
                rozmiar += i;
            } //ogarnia ile łącznie jest ocen ze wszystkich przedmiotów 

            string[,] wagaOceny = new string[rozmiar, 2]; //zapisuje jaka jest waga danej oceny, potrzebne do obliczenia średniej
            int[] jakiPrzedmiot = new int[rozmiar]; //tutaj są trzymane wiersze w których średnia ma być obliczana 
            int index = 0;
            int rozmiarCzcionki = 12;

            // do tablicy wagaOceny jest wpisywana ocena i obok jej waga, a w tablicy jakiPrzedmiot jest numer rzędu w którym jest ten przedmiot
            // pętla przechodzi po tablicy jakiPrzedmiot, i tak długo jak numer wiersza zgadza sie z zawartością tablicy, dodawane są ważone oceny i potem liczona średnia 
            // jak zmieni sie numer wiersza w jakiPrzedmiot, pętla sie przerywa i średnia jest normalnie wpisywana do tabeli

            Control cellControl;

            //Wypełnia nazwy kolumn
            for (int i = 0; i < 3; i++)
            {
                cellControl = tabelaOceny.GetControlFromPosition(i, 0);
                if (!(cellControl is RichTextBox))
                {
                    RichTextBox label = new RichTextBox();
                    label.Dock = DockStyle.Fill;
                    label.BackColor = Color.DimGray;
                    label.ReadOnly = true;
                    label.BorderStyle = BorderStyle.None;
                    label.SelectionColor = Color.WhiteSmoke;
                    label.SelectionFont = new Font(label.Font.FontFamily, rozmiarCzcionki);
                    label.SelectionAlignment = HorizontalAlignment.Center;
                    switch (i)
                    {
                        case 0:
                            label.AppendText($"Nazwa Przedmiotu");
                            break;
                        case 1:
                            label.AppendText($"Ocena");
                            break;
                        case 2:
                            label.AppendText($"Średnia");
                            break;
                    }
                    tabelaOceny.Controls.Add(label, i, 0);
                    tabelaOceny.Controls.Remove(cellControl);

                }
            }

            //Wypełnienie nazw przedmiotów
            for (int i = 1; i < 13; i++)
            {
                cellControl = tabelaOceny.GetControlFromPosition(0, i);
                if (!(cellControl is RichTextBox))
                {
                    RichTextBox label = new RichTextBox();
                    label.Dock = DockStyle.Fill;
                    label.BackColor = Color.DimGray;
                    label.ReadOnly = true;
                    label.BorderStyle = BorderStyle.None;
                    label.SelectionColor = Color.WhiteSmoke;
                    label.SelectionFont = new Font(label.Font.FontFamily, rozmiarCzcionki);
                    label.SelectionAlignment = HorizontalAlignment.Center;

                    switch (i)
                    {
                        case 1:
                            label.AppendText($"Matematyka");
                            break;
                        case 2:
                            label.AppendText($"Język Angielski");
                            break;
                        case 3:
                            label.AppendText($"Język Polski");
                            break;
                        case 4:
                            label.AppendText($"Język Niemiecki");
                            break;
                        case 5:
                            label.AppendText($"Chemia");
                            break;
                        case 6:
                            label.AppendText($"Biologia");
                            break;
                        case 7:
                            label.AppendText($"Geografia");
                            break;
                        case 8:
                            label.AppendText($"Fizyka");
                            break;
                        case 9:
                            label.AppendText($"Informatyka");
                            break;
                        case 10:
                            label.AppendText($"WF");
                            break;
                        case 11:
                            label.AppendText($"Historia");
                            break;
                        case 12:
                            label.AppendText($"Godzina Wychowawcza");
                            break;
                    }
                    tabelaOceny.Controls.Add(label, 0, i);
                    tabelaOceny.Controls.Remove(cellControl);

                }
            }

            //Wypisanie ocen
            #region SQL stuff
            query = $"SELECT grade, type FROM grades INNER JOIN students ON grades.student = students.id_student WHERE students.email = '{ktoZalogowany}' ORDER BY subject";
            exec = new MySqlCommand(query, conn);
            conn.Open();
            result = exec.ExecuteReader();
            #endregion
            for (int i = 0; i < 12; i++)
            {
                cellControl = tabelaOceny.GetControlFromPosition(1, i + 1);
                if (!(cellControl is RichTextBox))
                {
                    RichTextBox label = new RichTextBox();
                    label.Dock = DockStyle.Fill;
                    label.ReadOnly = true;
                    //label.Enabled = false;
                    label.SelectionColor = Color.WhiteSmoke;
                    label.BackColor = Color.DimGray;
                    label.BorderStyle = BorderStyle.None;
                    label.SelectionFont = new Font(label.Font.FontFamily, rozmiarCzcionki);
                    label.SelectionAlignment = HorizontalAlignment.Center;
                    int j = 0;

                    //pętla przechodzi po każdym przedmiocie tyle razy ile jest w nim ocen
                    //jeśli jest 0 to wpisuje brak ocen i idzie dalej
                    do
                    {
                        if (!czyPusta(ileOcen[i], label))
                        {
                            result.Read();
                            switch (result[1])
                            {
                                case "S":
                                    label.SelectionColor = Color.Red;
                                    label.AppendText($"{result[0]}");
                                    label.SelectionColor = Color.WhiteSmoke;
                                    label.AppendText($"  ");
                                    wagaOceny[index, 0] = result[0].ToString();
                                    wagaOceny[index, 1] = "5";
                                    jakiPrzedmiot[index] = i + 1;
                                    break;
                                case "K":
                                    label.SelectionColor = Color.DeepSkyBlue;
                                    label.AppendText($"{result[0]}");
                                    label.SelectionColor = Color.WhiteSmoke;
                                    label.AppendText($"  ");
                                    wagaOceny[index, 0] = result[0].ToString();
                                    wagaOceny[index, 1] = "3";
                                    jakiPrzedmiot[index] = i + 1;
                                    break;
                                case "O":
                                    label.SelectionColor = Color.White;
                                    label.AppendText($"{result[0]}");
                                    label.SelectionColor = Color.WhiteSmoke;
                                    label.AppendText($"  ");
                                    wagaOceny[index, 0] = result[0].ToString();
                                    wagaOceny[index, 1] = "2";
                                    jakiPrzedmiot[index] = i + 1;
                                    break;
                                case "P":
                                    label.SelectionColor = Color.YellowGreen;
                                    label.AppendText($"{result[0]}");
                                    label.SelectionColor = Color.WhiteSmoke;
                                    label.AppendText($"  ");
                                    wagaOceny[index, 0] = result[0].ToString();
                                    wagaOceny[index, 1] = "1";
                                    jakiPrzedmiot[index] = i + 1;
                                    break;
                            }
                            index++;
                        }
                        j++;
                    } while (j < ileOcen[i]);

                    tabelaOceny.Controls.Add(label, 1, i + 1);
                    tabelaOceny.Controls.Remove(cellControl);

                }
            }
            conn.Close();

            //Obliczenie i wypisanie średnej
            float srednia;
            int index2 = 0;
            for (int i = 1; i <= 12; i++)
            {
                cellControl = tabelaOceny.GetControlFromPosition(2, i);
                if (!(cellControl is RichTextBox))
                {
                    RichTextBox label = new RichTextBox();
                    label.Dock = DockStyle.Fill;
                    label.BackColor = Color.DimGray;
                    label.ReadOnly = true;
                    label.BorderStyle = BorderStyle.None;
                    label.SelectionColor = Color.WhiteSmoke;
                    label.SelectionFont = new Font(label.Font.FontFamily, rozmiarCzcionki);
                    label.SelectionAlignment = HorizontalAlignment.Center;

                    if (tabelaOceny.GetControlFromPosition(1, i).Text == "Brak ocen.")
                    {
                        label.AppendText("Brak ocen.");
                    }
                    else
                    {
                        int suma = 0;
                        int liczbaOcen = 0;
                        for (int j = 0; j < ileOcen[i - 1]; j++)
                        {
                            suma += int.Parse(wagaOceny[index2, 0]) * int.Parse(wagaOceny[index2, 1]); //sumuje oceny uwzględniając wagę 
                            liczbaOcen += int.Parse(wagaOceny[index2, 1]); //liczy ile jest ocen uwzględniając wagę
                            index2++;
                        }
                        srednia = (float)suma / liczbaOcen;
                        label.AppendText(Math.Round(srednia, 2).ToString("0.00"));
                    }
                    tabelaOceny.Controls.Add(label, 2, i);
                    tabelaOceny.Controls.Remove(cellControl);

                }
            }

            #endregion
            panelOceny.BringToFront();

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
                polaczenie2.Open();
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

        // Terminy sprawdzianów
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
                    sprawdziany_tabelka.Rows.Clear();
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
        // Przycisk do usprawiedliwiania godziń
        private void uspr_Click(object sender, EventArgs e)
        {
            int newValue = 1;
            int id_uczen = int.Parse(id_label.Text);
            MySqlConnection polaczenie1 = new MySqlConnection(connectionString);
            string sql1 = $"UPDATE attendance SET present='{newValue}' WHERE student='{id_uczen}'";
            MySqlCommand cmd1 = new MySqlCommand(sql1, polaczenie1);
            try
            {
                polaczenie1.Open();
                cmd1.Parameters.AddWithValue("@newValue", newValue);
                cmd1.CommandText = sql1;
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Twoje godziny zostały usprawiedliwione :-D");
                MessageBox.Show("Odświerz stronę w celu zaktualizowania danych");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                polaczenie1.Close();
            }
           

        }
        
        

        #endregion





    }
}