using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Interactivo
{
    public partial class Adivinar : Form
    {


        public Adivinar()
        {
            InitializeComponent();
        }

        int contador = 0;
        int oportunidades = 7;
        private void Adivinar_Load(object sender, EventArgs e)
        {
            generadorNum();
        }

        private void generadorNum()
        {
            Random rnd = new Random();
            textCOM.Text = rnd.Next(0, 70).ToString();
        }
        private void btnCompara_Click(object sender, EventArgs e)
        {
            contador++;
            int opo = oportunidades - contador;
            int a = Convert.ToInt32(textCOM.Text);
            int b = Convert.ToInt32(textUser.Text);

            if (contador < 10)
            {
                if (a == b)
                {
                    MessageBox.Show("Acertaste! " + contador.ToString());
                }
                else
                {
                    if (a > b)
                    {
                        MessageBox.Show("Uy! El número es menor. " + "Ahora te quedan "+opo.ToString()+ " oportunidades");
                        textUser.Clear();
                        textUser.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Vaya! El número que has introducido es mayor. " + "Ahora te quedan " +opo.ToString()+ " oportunidades");
                        textUser.Clear();
                        textUser.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lo siento! Te quedaste sin intentos de acierto");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
