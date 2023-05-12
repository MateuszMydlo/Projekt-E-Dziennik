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

        #endregion
    }
}