using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Menu_Interactivo
{
    public partial class Funciones : Form
 
    {
        /** POO. Variables. */

        List<int> arregloFibo = new List<int>();

        /** La variable "n" es el numero introducido por el usuario
            La variable "ni" el primer numero de la serie Fibonacci.
            La variable "ni" el numero final iesimo mostrado serie Fibonacci. En este caso, acaba mostrandel valor correspondiente al decimo quinto numero
            calculado.
        */

        int n, ni = 0, nfi = 15;
        public Funciones()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Funciones_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnFibo_Click(object sender, EventArgs e)
        {
            if((!Int32.TryParse(textFibo.Text, out n)) || ((n <= ni) || (n >= nfi))) 
            {
                MessageBox.Show("Error fatal! " + " El número introducido " + textFibo.Text + " sale de los límites de intervalo" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                //Limpiar caja de texto
                textFibo.Text = "";
                // Focus en la caja
                textFibo.Focus();
            }
            else
            {   // Limpiar texto mensaje
                textResFibo.Text = "";
                //Calcular la serie con los datos y llenar caja resultado
                for (int i = 0, a = 1, b = 0, c = 0; i < this.n; c = a + b, a = b, b = c, i++) 
                { 
                    arregloFibo.Add(c);
                    textResFibo.Text += c.ToString() + ", ";
                }

            }
        }
    }
}
