using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial
{
    public partial class Menu_XL : Form
    {
        public Menu_XL()
        {
            InitializeComponent();
        }

        private void edadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edad fr = new Edad();
            fr.Show();
            this.Hide();
        }

        private void palabraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Palabra fr = new Palabra();
            fr.Show();
            this.Hide();
        }

        private void numRegresivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num_Regresivos fr = new Num_Regresivos();
            fr.Show();
            this.Hide();
        }

        private void imparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impar fr = new Impar();
            fr.Show();
            this.Hide();
        }

        private void regresivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inversion fr = new Inversion();
            fr.Show();
            this.Hide();
        }
    }
}
