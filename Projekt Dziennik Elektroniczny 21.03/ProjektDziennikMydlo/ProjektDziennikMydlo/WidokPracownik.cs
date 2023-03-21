using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektDziennikMydlo
{
    public partial class WidokPracownik : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public WidokPracownik()
        {
            InitializeComponent();


            hScrollBar1.Value = panel4.HorizontalScroll.Value;
            hScrollBar1.Minimum = panel4.HorizontalScroll.Minimum;
            hScrollBar1.Maximum = panel4.HorizontalScroll.Maximum;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
        }

        private void hScrollBar1_Scroll(object sender, EventArgs e)
        {
            panel4.HorizontalScroll.Value = hScrollBar1.Value;
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

        }

        private void butKL1b_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
        }

        private void butKL2a_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
        }

        private void butKL2b_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
        }

        private void butKL3a_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
        }

        private void but3b_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
        }

        private void butKL4a_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
        }

        private void butKL4b_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
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
    }
}
