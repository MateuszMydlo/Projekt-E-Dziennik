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
    public partial class LogowaniePracownik : Form
    {
        public LogowaniePracownik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WidokPracownik f4 = new WidokPracownik();
            f4.ShowDialog();
            this.Close();
        }
    }
}
