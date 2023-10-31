using System;
using System.Windows.Forms;

namespace Menu_Interactivo
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }
        double num1, num2, result;  
        string op;
       

        private void Minicalculadora_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            screen.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            screen.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            screen.Text += "3";
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            screen.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            screen.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            screen.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            screen.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            screen.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            screen.Text += "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            screen.Text += ".";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            screen.Text += "0";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            screen.Text += ",";
        }
        protected void button13_Click(object sender, EventArgs e)
        {
            screen.Clear();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            op = "+";
            num1 = double.Parse(screen.Text);
            screen.Clear();
            screen.Focus();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            op = "*";
            num1 = double.Parse(screen.Text);
            screen.Clear();
            screen.Focus();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            op = "-";
            num1 = double.Parse(screen.Text);
            screen.Clear();
            screen.Focus();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            op = "/";
            num1 = double.Parse(screen.Text);
            screen.Clear();
            screen.Focus();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            op = "%";
            num1 = double.Parse(screen.Text);
            screen.Clear();
            screen.Focus();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(screen.Text);
            switch (op)
            {
                case "+":
                    screen.Text = Convert.ToString(num2 + num1);
                    break;

                case "-":
                    screen.Text = Convert.ToString(-num1 + num2);
                    screen.Text = Convert.ToString(-num2 + num1);
                    break;

                case "*":
                    screen.Text = Convert.ToString(num2 * num1);
                    break;

                case "/":
                    screen.Text = Convert.ToString(num2 / num1);
                    break;

                case "%":
                    screen.Text = Convert.ToString(num2 % num1);
                    break;

                default:
                    Console.WriteLine("¡Algo ha fallado!");
                    break;
                    
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
