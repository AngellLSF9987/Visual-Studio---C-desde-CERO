using System;
using System.Drawing;
using System.Windows.Forms;

namespace Articulos_Clases_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnIni_Click(null, e);  // Incluye y muestra formulario Inicial en el arranque de programa
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedorForm1.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void AbrirFormHijo(object formHijo)
        {
            if (this.panelContenedorForm1.Controls.Count > 0)
                this.panelContenedorForm1.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            panelContenedorForm1.Controls.Add(fh);
            panelContenedorForm1.Tag = fh;
            fh.Show();
        }

        Panel p = new Panel();
       /** Panel p2 = new Panel();
        Panel p3 = new Panel(); */
        private void btnMouseEnter(object sender, EventArgs e)
        {
            // Evento visual para la transformacion de los botones del panel superior (pMenu)
            // en cuanto a tamaño y simular una línea inferior
            Button btn = sender as Button;
           
            pMenu.Controls.Add(p);
            
            p.BackColor = Color.GreenYellow;
            p.ForeColor = Color.GreenYellow;
            p.Size = new Size(140,5);
            p.Location = new Point(btn.Location.X, btn.Location.Y+40);
        /**    
            pSubArt.Controls.Add(p2);
           
            p2.BackColor = Color.GreenYellow;
            p2.ForeColor = Color.GreenYellow;
            p2.Size = new Size(140, 5);
            p2.Location = new Point(btn.Location.X, btn.Location.Y + 40);

            pSubPed.Controls.Add(p3);

            p3.BackColor = Color.GreenYellow;
            p3.ForeColor = Color.GreenYellow;
            p3.Size = new Size(140, 5);
            p3.Location = new Point(btn.Location.X, btn.Location.Y + 40);*/
        }
            // Evento que finaliza la transformacion del panel superior cuando el cursor no lo está enfocando 
        private void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p);
        /**    pSubArt.Controls.Remove(p2);
            pSubPed.Controls.Remove(p3);*/
        }           
        private void btnMenuArticulos_Click(object sender, EventArgs e)
        {
            if(!pSubArt.Visible)
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
    
        private void btnIni_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Inicial());
        }
        private void btnConsultaPedido_Click(object sender, EventArgs e)
        {           
            AbrirFormHijo(new ConsultaPedidos());
        }
        private void btnAltas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new AltasArticulos());
        }
        private void btnConsultaArticulo_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ConsultaArticulos());
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
