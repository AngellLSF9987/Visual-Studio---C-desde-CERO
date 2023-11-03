using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Articulos_Clases_
{
    public partial class ConsultaArticulos : Form
    {
        public ConsultaArticulos()
        {
            InitializeComponent();
        }
/*
        Panel p = new Panel();
        Panel p2 = new Panel();
        Panel p3 = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            // Evento visual que hará la transformacion de los botones del panel superior (pMenu)
            // en cuanto a tamaño y simular una línea inferior
            Button btn = sender as Button;

            pMenu.Controls.Add(p);

            p.BackColor = Color.GreenYellow;
            p.ForeColor = Color.GreenYellow;
            p.Size = new Size(140, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40);

            pSubArt.Controls.Add(p2);

            p2.BackColor = Color.GreenYellow;
            p2.ForeColor = Color.GreenYellow;
            p2.Size = new Size(140, 5);
            p2.Location = new Point(btn.Location.X, btn.Location.Y + 40);

            pSubPed.Controls.Add(p3);

            p3.BackColor = Color.GreenYellow;
            p3.ForeColor = Color.GreenYellow;
            p3.Size = new Size(140, 5);
            p3.Location = new Point(btn.Location.X, btn.Location.Y + 40);
        }
        // Evento que finaliza la transformacion del panel superior cuando el cursor no lo está enfocando 
        private void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p);
            pSubArt.Controls.Remove(p2);
            pSubPed.Controls.Remove(p3);
        }

        private void btnMenuArticulos_Click(object sender, EventArgs e)
        {
            if (!pSubArt.Visible)
            {
                pSubArt.Visible = true;
            }
            else
            {
                pSubArt.Visible = false;
            }
        }

        private void btnMenuPedidos_Click(object sender, EventArgs e)
        {
            if (!pSubPed.Visible)
            {
                pSubPed.Visible = true;
            }
            else
            {
                pSubPed.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
*/
    }
}
