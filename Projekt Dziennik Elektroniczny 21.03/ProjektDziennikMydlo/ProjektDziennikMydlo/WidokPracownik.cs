using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjektDziennikMydlo
{

    #region FUNKCJE, ZMIANY WIDOKÓW
    public partial class WidokPracownik : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public WidokPracownik()
        {
            InitializeComponent();

        }

        private void hScrollBar1_Scroll(object sender, EventArgs e)
        {
         
        }

        private void WidokPracownik_Load(object sender, EventArgs e)
        {
            button8.Visible = false;
            button7.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            hScrollBar1.Visible = false;

            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            wybierzUczniaDoUwagi();


        }

        private void butPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogowaniePracownik f2 = new LogowaniePracownik();
            f2.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //hScrollBar1.Visible = true;
            panel4.Visible = true;
            panel4.BringToFront();
        }

        private void butKL1a_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
            Form1.MyGlobals.id_klasy = 1;

        }

        private void butKL1b_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
            Form1.MyGlobals.id_klasy = 2;
        }

        private void butKL2a_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
            Form1.MyGlobals.id_klasy = 3;
        }

        private void butKL2b_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
            Form1.MyGlobals.id_klasy = 8;
        }

        private void butKL3a_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
            Form1.MyGlobals.id_klasy = 4;
        }

        private void but3b_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
            Form1.MyGlobals.id_klasy = 5;
        }

        private void butKL4a_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
            Form1.MyGlobals.id_klasy = 6;
        }

        private void butKL4b_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
            Form1.MyGlobals.id_klasy = 7;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    
        private void wybierzUczniaDoUwagi()
        {

            string connectionString = Form1.MyGlobals.connSTR;//pobiera string globalny wymagany do polaczenia sie z DB
            string query = "SELECT * FROM students WHERE class=" + Form1.MyGlobals.id_klasy + "; ";//kwerenda
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
                        //String Item = result.GetString(0) + result.GetString(1);
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(result.GetString(1));
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WidokPracownik_VisibleChanged(object sender, System.EventArgs e)
        {
            wybierzUczniaDoUwagi();
        }
        }
}
