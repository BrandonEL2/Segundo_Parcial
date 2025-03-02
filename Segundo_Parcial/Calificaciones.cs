using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Segundo_Parcial
{
    public partial class Calificaciones: Form
    {
        public Calificaciones()
        {
            InitializeComponent();
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            double m1 = double.Parse(textBox2.Text);
            double m2 = double.Parse(textBox4.Text);
            double m3 = double.Parse(textBox6.Text);
            double m4 = double.Parse(textBox8.Text);
            double m5 = double.Parse(textBox10.Text);
            double P = (m1 + m2 + m3 + m4 + m5) / 5;
            textBox12.Text = P.ToString();
            if (P > 6)
            {
                textBox11.Text += "Aprobado";
            }
            else
            {
                textBox11.Text += "Reprobado";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }
    }
}
