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
    public partial class Impar : Form
    {
        public Impar()
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
                listBox1.Items.Add("Números impares:");

                // Bucle para recorrer los números desde 1 hasta el número ingresado
                for (int i = 1; i <= numero; i++)
                {
                    // Verificar si el número es impar
                    if (i % 2 != 0)
                    {
                        // Agregar cada número impar como un elemento individual al ListBox
                        listBox1.Items.Add(i.ToString());
                    }
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
