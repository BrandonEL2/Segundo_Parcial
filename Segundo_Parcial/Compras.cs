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
    public partial class Compras: Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);
            double S = n1+n2+n3+n4+n5;
            double DS = S * 0.10;
            double RD = S - DS;
            double TC = S + RD;
            if (S>2000)
            {
                textBox6.Text += "Toatal de los productos" 
                    + S;
                textBox6.Text += "Total de descuento" 
                    + RD;
                textBox6.Text += "Total de Compra" 
                    + TC;
            }
            else
            {
                textBox6.Text += "Total de compra" 
                    + S;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
