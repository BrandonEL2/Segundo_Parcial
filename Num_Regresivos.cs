using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Segundo_Parcial
{
    public partial class Num_Regresivos : Form
    {
        public Num_Regresivos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero) && numero > 0)
            {
                // Limpiar el ListBox antes de agregar nuevos elementos
                listBox1.Items.Clear();

                // Agregar un título al ListBox
                listBox1.Items.Add("Cuenta regresiva:");

                // Bucle para recorrer los números desde el número ingresado hasta 1
                for (int i = numero; i >= 1; i--)
                {
                    // Agregar cada número de la cuenta regresiva como un elemento individual al ListBox
                    listBox1.Items.Add(i.ToString());
                }
            }
            else
            {
                // Si el número no es válido o no es positivo, mostrar mensaje de error
                listBox1.Items.Clear(); // Limpiar el ListBox
                listBox1.Items.Add("Por favor, ingresa un número entero positivo.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
