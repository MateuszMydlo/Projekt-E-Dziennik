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
    public partial class LogowanieUczen : Form
    {
        public LogowanieUczen()
        {
            InitializeComponent();
        }

        private void butZaloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            WidokUczen f5 = new WidokUczen();
            f5.ShowDialog();
            this.Close();
        }
    }
}
