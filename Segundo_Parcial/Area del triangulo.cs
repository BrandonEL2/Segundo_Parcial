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
    public partial class Area_del_triangulo: Form
    {
        public Area_del_triangulo()
        {
            InitializeComponent();
        }

        private void Area_del_triangulo_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            int B1 = int.Parse(textBox1.Text);
            int B2 = int.Parse(textBox2.Text);
            int R = (B1 + B2) / 2;
            textBox3.Text=R.ToString();
        }
    }
}
