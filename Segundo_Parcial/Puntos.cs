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
    public partial class Puntos: Form
    {
        public Puntos()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(textBox1.Text);
            double x2 = double.Parse(textBox2.Text);
            double y1 = double.Parse(textBox3.Text);
            double y2 = double.Parse(textBox4.Text);
            float r = 2;
            float r2 = 1 / r;
            double D = Math.Pow((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)), r2);
            textBox5.Text = D.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
