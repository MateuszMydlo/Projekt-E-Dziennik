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
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjektDziennikMydlo
{
    public partial class WidokUczen : Form
    {
        static string connectionString = Form1.MyGlobals.connSTR; //pobiera string globalny wymagany do polaczenia sie z DB
        MySqlConnection conn = new MySqlConnection(connectionString);
        //private string ktoZalogowany = LogowanieGlowne.mailZalogowanego;  //miało pobierać maila ale z jakiegoś powodu nie działa na poziomie klasy

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
            conn.Close();

            query = $"SELECT grade, type FROM grades INNER JOIN students ON grades.student = students.id_student WHERE students.email = '{ktoZalogowany}'";
            exec = new MySqlCommand(query, conn);
            exec.CommandTimeout = 60;
            conn.Open();
            result = exec.ExecuteReader();
            result.Read();
            for (int i = 0; i < 2; i++)
            {

                testWypisania.AppendText($"{result[i]} ");

            }
            result.Read();
            for (int i = 0; i < 2; i++)
            {

                testWypisania.AppendText($"{result[i]} ");

            }
            conn.Close();

            panelMojeDane.BringToFront();

        }

        private void butMojeDane_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            WidokUczen f5 = new WidokUczen();
            f5.ShowDialog();
            this.Close();*/
            panelMojeDane.BringToFront();
            //string query = "SELECT name, surname FROM students WHERE id_student = 1";
        }
        private void butPlanLek_Click(object sender, EventArgs e)
        {
            panelPlanLekcji.BringToFront();
            string ktoZalogowany = LogowanieGlowne.mailZalogowanego;
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
            panelOceny.BringToFront();
            string ktoZalogowany = LogowanieGlowne.mailZalogowanego;
            /*
                        // Creating a label
                        Label label = new Label();
                        label.Text = "Polski";

                        // Add the label control to the TableLayoutPanel in the second row and third column
                        tabelaOceny.Controls.Add(label, 0, 1);
            */

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
                    //label.Enabled = false;
                    label.BorderStyle = BorderStyle.None;
                    label.SelectionColor = Color.WhiteSmoke;
                    label.SelectionFont = new Font(label.Font.FontFamily, rozmiarCzcionki);
                    /*int lineHeight = label.GetPositionFromCharIndex(label.Text.Length - 1).Y;
                    int verticalOffset = (label.Height - lineHeight) / 2;
                    label.SelectedRtf = @"{\rtf1\ansi\par \pard\sa" + verticalOffset + @"\qc" + label.Text + @"\par}";*/
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
                    /*int lineHeight = label.GetPositionFromCharIndex(label.Text.Length - 1).Y;
                    int verticalOffset = (label.Height - lineHeight) / 2;
                    label.SelectedRtf = @"{\rtf1\ansi\par \pard\sa" + verticalOffset + @"\qc" + label.Text + @"\par}";*/
                    //label.Text = "";
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

                    /*query = $"SELECT COUNT(grade) FROM grades INNER JOIN students ON grades.student = students.id_student WHERE students.email = '{ktoZalogowany}'";
                    exec = new MySqlCommand(query, conn);
                    conn.Open();
                    result = exec.ExecuteReader();
                    result.Read();
                    int zIluPrzedmiotow = result.GetInt32(0);
                    conn.Close();*/

                    /*query = $"SELECT grade, type FROM grades INNER JOIN students ON grades.student = students.id_student WHERE students.email = '{ktoZalogowany}'";
                    exec = new MySqlCommand(query, conn);
                    conn.Open();
                    result = exec.ExecuteReader();
                    if (!czyPusta(ileOcen[i], label))
                    {
                        result.Read();
                        switch (result[1])
                        {
                            case "S":
                                label.Text += $"<span style='color:red'>{result[0]}, </span>";
                                break;
                            case "K":
                                label.Text += $"<span style='color:DeepSkyBlue'>{result[0]}, </span>";
                                break;
                            case "O":
                                label.Text += $"<span style='color:white'>{result[0]}, </span>";
                                break;
                            case "P":
                                label.Text += $"<span style='color:YellowGreen'>{result[0]}, </span>";
                                break;
                        }

                    }
                    conn.Close();*/

                    //conn.Close();

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

        }

        #endregion

        #region Kamilowe

        #endregion
    }
}