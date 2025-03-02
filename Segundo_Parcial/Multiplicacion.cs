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
    public partial class Multiplicacion: Form
    {
        public Multiplicacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            for (int i=1; i<=10; i++)
            {
                listBox1.Items.Add(i + "*" + "6" + "=" + (i * 6));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
            listBox1.Items.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
