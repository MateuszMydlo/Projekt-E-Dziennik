﻿using System;
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
    public partial class WidokUczen : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public WidokUczen()
        {
            InitializeComponent();
        }

        private void butPowrot1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogowanieGlowne f2 = new LogowanieGlowne(true);
            //Logowanie f3 = new Logowanie();
            f2.ShowDialog();
            this.Close();
        }

        private void butPlanLek_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void butOceny_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void butFrek_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void butTerminy_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
        }

        private void WidokUczen_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            panel1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butPowrot1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var widokInicialny = new Form1();
            widokInicialny.ShowDialog();
        }
    }
}
