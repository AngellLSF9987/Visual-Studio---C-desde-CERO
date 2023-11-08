using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        // LA SIGUIENTE DECLARACION " #region... " ES DECLARADA CON EL FIN DE SEPARAR TODO EL CÓDIGO
        // SEGÚN SU FUNCIONALIDAD DENTRO DE UN MISMO PROGRAMA. CONTRIBUYE AL ENCAPSULADO DE CADA
        // BLOQUE DE FUNCIONALIDADES PUDIENDO CONTRAERLO Y, ASÍ TENER MÁS DESPEJADA LA INTERFAZ
        // DE LA HERRAMIENTA IDE CON LA QUE ESTAMOS TRABAJANDO.

        #region Funcionalidades y Estilos del formulario 

        Panel p = new Panel();       
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panelNavBar.Controls.Add(p);
            p.BackColor = Color.GreenYellow;
            p.Size = new Size(107, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panelNavBar.Controls.Remove(p);
        }

        Panel pSubArt = new Panel();
        Panel pSubPed = new Panel();
                    
        private void btnMouseEnterSub(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panelSubmenuArticulos.Controls.Add(pSubArt);
            pSubArt.BackColor = Color.GreenYellow;
            pSubArt.Size = new Size(107, 5);
            pSubArt.Location = new Point(btn.Location.X, btn.Location.Y + 40);

            panelSubmenuPedidos.Controls.Add(pSubPed);
            pSubPed.BackColor = Color.GreenYellow;
            pSubPed.Size = new Size(107, 5);
            pSubPed.Location = new Point(btn.Location.X, btn.Location.Y + 40);
        }

        private void btnMouseLeaveSub(object sender, EventArgs e)
        {
            panelNavBar.Controls.Remove(pSubArt);
            panelNavBar.Controls.Remove(pSubPed);
        }
        // "RESIZE": METODO PARA REDIMENSIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION 

        private int tolerance = 12;
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

        // DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }

        // COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.LightGray, sizeGripRectangle);
        }

        // VINCULACION EVENTO CIERRE DE APP A PARTIR DE UN PICTURE_BOX MODIFICADO
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // CAPTURAR POSICION VECTORIAL BOTONES DE EVENTOS DE VENTANA MAXIMIZAR, MINIMIZAR Y RESTAURAR

        int lx, ly;
        int sw, sh;

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // METODO PARA ARRASTRAR EL FORMULARIO. EVENTO VINCULADO EN PANEL SUPERIOR (NAME : panelTop)

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void btnAltaArticulo_Click(object sender, EventArgs e)
        {
            AbrirFormHijo<FormAltaArticulo>();
        }

        private void btnConsultaArticulo_Click(object sender, EventArgs e)
        {
            AbrirFormHijo<FormConsultaArticulo>();
        }

        private void btnDetallePedido_Click(object sender, EventArgs e)
        {
            AbrirFormHijo<FormDetallePedido>();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            panelSubmenuArticulos.Visible = false;
            panelSubmenuArticulos.Visible = true;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            panelSubmenuPedidos.Visible = false;
            panelSubmenuPedidos.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion


        // METODO APERTURA OTROS FORMULARIOS DENTRO DEL PANEL ASIGNADO EN FORMULARIO PRINCIPAL
        // DECLARACION FORMULARIO GENERICO (Padre):
        // - CONSTRUCTOR VACIO DESDE DONDE SON LLAMADOS EL RESTO (Hijos).

        private void AbrirFormHijo<FormPadre>() where FormPadre : Form, new()
        {
            Form fH;

            // BUSCARA EL FORMULARIO EN LA COLECCION DE <FormPadre>
            fH = panelBody.Controls.OfType<FormPadre>().FirstOrDefault();

            // CONTROL DE ERRORES O DE FORMULARIO NO EXISTENTE
            if (fH == null)
            {
                fH = new FormPadre();
                fH.TopLevel = false;
                fH.Dock = DockStyle.Fill;
                panelBody.Controls.Add(fH);
                panelBody.Tag = fH;
                fH.Show();
                fH.BringToFront();
            }
            else
            {
                fH.BringToFront();
            }

        }
    }
}
