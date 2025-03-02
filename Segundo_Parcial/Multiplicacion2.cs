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
    public partial class Multiplicacion2: Form
    {
        public Multiplicacion2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            for (int i=1; i <= 10; i++) 
            {
                listBox1.Items.Add(n1 + "*" + i + "=" + (n1*i));
            }
        }
    }
}
