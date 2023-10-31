using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Numeros
{
    public partial class App : Form
    {   
        
        public App()
        {
            InitializeComponent();
        }
        private void screen_Load(object sender, EventArgs e)
        {

        }

        int num;
        private void btnIntroNum_Click(object sender, EventArgs e)
        {
            int[,] listSort = new int[1, 10];
            foreach (int i in listSort)
            {
                textNum.Text = textNum.Text.ToString();

                if (!string.IsNullOrWhiteSpace(textNum.Text) && !
                   listSort.Items.Contains(textNum.Text))
                    listSort.Items.Add(textNum.Text);

            }
        }

        private Media()
        {
            int suma = 0;
            int longitud = num.Length;
            for (int i = 0; i < num.Length; i++)
            {
                suma += num[i];
            }

            double media = (double)suma / longitud;

            textMedia.Text = media.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {    

                if (num % 2 == 0)
                {
                    MessageBox.Show("El número " + num + " es un número primo.");
                }
                else
                {
                    MessageBox.Show("El número " + num + " no es un número primo.");
                }
        }
        private void btnClick1_Click(object sender, EventArgs e)
        {
            textNum.Text += "1";
            num = int.Parse(textNum.Text);
            textNum.Focus();
        }
        private void btnClick2_Click(object sender, EventArgs e)
        {
            textNum.Text += "2";
            num = int.Parse(textNum.Text);
            textNum.Focus();
        }

        private void btnClick3_Click(object sender, EventArgs e)
        {
            textNum.Text += "3";
            num = int.Parse(textNum.Text);
            textNum.Focus();
        }

        private void btnClick4_Click(object sender, EventArgs e)
        {
            textNum.Text += "4";
            num = int.Parse(textNum.Text);
            textNum.Focus();
        }

        private void btnClick5_Click(object sender, EventArgs e)
        {
            textNum.Text += "5";
            num = int.Parse(textNum.Text);
            textNum.Focus();
        }

        private void btnClick6_Click(object sender, EventArgs e)
        {
            textNum.Text += "6";
            num = int.Parse(textNum.Text);
            textNum.Focus();
        }

        private void btnClick7_Click(object sender, EventArgs e)
        {
            textNum.Text += "7";
            num = int.Parse(textNum.Text);
            textNum.Focus();
        }

        private void btnClick8_Click(object sender, EventArgs e)
        {
            textNum.Text += "8";
            num = int.Parse(textNum.Text);
            textNum.Focus();
        }

        private void btnClick9_Click(object sender, EventArgs e)
        {
            textNum.Text += "9";
            num = int.Parse(textNum.Text);
            textNum.Focus();
        }

        private void btnClick0_Click(object sender, EventArgs e)
        {
            textNum.Text += "0";
            num = int.Parse(textNum.Text);
            textNum.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
