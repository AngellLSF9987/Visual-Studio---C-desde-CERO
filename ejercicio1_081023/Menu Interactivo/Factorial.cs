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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Fact_Click_1(object sender, EventArgs e)
        {
            int n, i, fac=1;
            
            n = Convert.ToInt32(textFact.Text);

            for (i=1; i <= n; i++)
            {
                fac *= i;
            }
            textResFact.Text = fac.ToString();
        }

        private void Factorial_Load(object sender, EventArgs e)
        {

        }
    }
}
