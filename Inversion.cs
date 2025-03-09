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
    public partial class Inversion : Form
    {
        public Inversion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double cantidadInvertir) &&
                double.TryParse(textBox3.Text, out double interesAnual) &&
                int.TryParse(textBox2.Text, out int numeroAnios))
            {
                // Validar que los valores sean mayores que 0
                if (cantidadInvertir <= 0 || interesAnual <= 0 || numeroAnios <= 0)
                {
                    listBox1.Items.Add("Por favor, ingrese valores válidos (mayores que 0).");
                    return;
                }

                // Calcular y mostrar el capital obtenido cada año
                double capital = cantidadInvertir;
                for (int año = 1; año <= numeroAnios; año++)
                {
                    capital *= (1 + interesAnual / 100);
                    listBox1.Items.Add($"Año {año}: {capital:C2}");
                }
            }
            else
            {
                listBox1.Items.Add("Por favor, ingrese valores numéricos válidos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

  

