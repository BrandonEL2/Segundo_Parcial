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
    public partial class Cuadratica: Form
    {
        public Cuadratica()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = float.Parse(textBox3.Text);
            float r = 2;
            float r2 = 1 / r;
            double x1 = (((-1) * (b)) + (Math.Pow(((Math.Pow(b,2))-(4*(a*c))),r)))/(2*a);
            double x2 = (((-1)*(b)) -(Math.Pow(((Math.Pow(b,2))-(4*(a*c))), r2)))/(2*a);
            textBox4.Text = x1.ToString() + x2.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
