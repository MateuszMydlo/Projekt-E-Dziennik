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
        public WidokPracownik()
        {
            InitializeComponent();
        }

        private void WidokPracownik_Load(object sender, EventArgs e)
        {
            button8.Visible = false;
            button7.Visible = false;
            button6.Visible = false;
            button5.Visible = false;

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
    }
}
