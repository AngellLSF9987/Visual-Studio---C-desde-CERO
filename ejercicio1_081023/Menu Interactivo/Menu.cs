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

namespace Menu_Interactivo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            app window1 = new app();    
            window1.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            areas window2 = new areas();
            window2.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Funciones window3 = new Funciones();
            window3.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Adivinar window6 = new Adivinar();
            window6.Visible = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Factorial window4 = new Factorial();
            window4.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Exit()
        {
            throw new NotImplementedException();
        }

        
    }
}
