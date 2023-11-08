namespace Tienda
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedorPrincipal = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelBodyBackPic = new System.Windows.Forms.PictureBox();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.logoNav = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSubmenuPedidos = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDetallePedido = new System.Windows.Forms.Button();
            this.panelSubmenuArticulos = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnConsultaArticulo = new System.Windows.Forms.Button();
            this.btnAltaArticulo = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedorPrincipal.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBodyBackPic)).BeginInit();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoNav)).BeginInit();
            this.panelSubmenuPedidos.SuspendLayout();
            this.panelSubmenuArticulos.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorPrincipal
            // 
            this.panelContenedorPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedorPrincipal.Controls.Add(this.panelBody);
            this.panelContenedorPrincipal.Controls.Add(this.panelNavBar);
            this.panelContenedorPrincipal.Controls.Add(this.panelTop);
            this.panelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorPrincipal.MinimumSize = new System.Drawing.Size(650, 650);
            this.panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            this.panelContenedorPrincipal.Size = new System.Drawing.Size(1363, 650);
            this.panelContenedorPrincipal.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.Silver;
            this.panelBody.Controls.Add(this.panelBodyBackPic);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(165, 35);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1198, 615);
            this.panelBody.TabIndex = 2;
            // 
            // panelBodyBackPic
            // 
            this.panelBodyBackPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBodyBackPic.Image = ((System.Drawing.Image)(resources.GetObject("panelBodyBackPic.Image")));
            this.panelBodyBackPic.Location = new System.Drawing.Point(0, 0);
            this.panelBodyBackPic.Name = "panelBodyBackPic";
            this.panelBodyBackPic.Size = new System.Drawing.Size(1198, 615);
            this.panelBodyBackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelBodyBackPic.TabIndex = 0;
            this.panelBodyBackPic.TabStop = false;
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelNavBar.Controls.Add(this.logoNav);
            this.panelNavBar.Controls.Add(this.panel6);
            this.panelNavBar.Controls.Add(this.panel8);
            this.panelNavBar.Controls.Add(this.panel3);
            this.panelNavBar.Controls.Add(this.panelSubmenuPedidos);
            this.panelNavBar.Controls.Add(this.panelSubmenuArticulos);
            this.panelNavBar.Controls.Add(this.btnClientes);
            this.panelNavBar.Controls.Add(this.btnPedidos);
            this.panelNavBar.Controls.Add(this.btnArticulos);
            this.panelNavBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavBar.Location = new System.Drawing.Point(0, 35);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(165, 615);
            this.panelNavBar.TabIndex = 1;
            // 
            // logoNav
            // 
            this.logoNav.Image = ((System.Drawing.Image)(resources.GetObject("logoNav.Image")));
            this.logoNav.Location = new System.Drawing.Point(25, 6);
            this.logoNav.Name = "logoNav";
            this.logoNav.Size = new System.Drawing.Size(118, 101);
            this.logoNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoNav.TabIndex = 0;
            this.logoNav.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.GreenYellow;
            this.panel6.Location = new System.Drawing.Point(13, 319);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 36);
            this.panel6.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.GreenYellow;
            this.panel8.Location = new System.Drawing.Point(12, 490);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(6, 36);
            this.panel8.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GreenYellow;
            this.panel3.Location = new System.Drawing.Point(12, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 32);
            this.panel3.TabIndex = 4;
            // 
            // panelSubmenuPedidos
            // 
            this.panelSubmenuPedidos.Controls.Add(this.panel7);
            this.panelSubmenuPedidos.Controls.Add(this.btnDetallePedido);
            this.panelSubmenuPedidos.Location = new System.Drawing.Point(30, 369);
            this.panelSubmenuPedidos.Name = "panelSubmenuPedidos";
            this.panelSubmenuPedidos.Size = new System.Drawing.Size(131, 49);
            this.panelSubmenuPedidos.TabIndex = 0;
            this.panelSubmenuPedidos.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.GreenYellow;
            this.panel7.Location = new System.Drawing.Point(9, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(6, 36);
            this.panel7.TabIndex = 5;
            // 
            // btnDetallePedido
            // 
            this.btnDetallePedido.FlatAppearance.BorderSize = 0;
            this.btnDetallePedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnDetallePedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetallePedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetallePedido.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDetallePedido.Location = new System.Drawing.Point(21, 3);
            this.btnDetallePedido.Name = "btnDetallePedido";
            this.btnDetallePedido.Size = new System.Drawing.Size(107, 36);
            this.btnDetallePedido.TabIndex = 4;
            this.btnDetallePedido.Text = "Registro Pedidos";
            this.btnDetallePedido.UseVisualStyleBackColor = true;
            this.btnDetallePedido.Click += new System.EventHandler(this.btnDetallePedido_Click);
            this.btnDetallePedido.MouseEnter += new System.EventHandler(this.btnMouseEnterSub);
            this.btnDetallePedido.MouseLeave += new System.EventHandler(this.btnMouseLeaveSub);
            // 
            // panelSubmenuArticulos
            // 
            this.panelSubmenuArticulos.Controls.Add(this.panel4);
            this.panelSubmenuArticulos.Controls.Add(this.panel5);
            this.panelSubmenuArticulos.Controls.Add(this.btnConsultaArticulo);
            this.panelSubmenuArticulos.Controls.Add(this.btnAltaArticulo);
            this.panelSubmenuArticulos.Location = new System.Drawing.Point(30, 177);
            this.panelSubmenuArticulos.Name = "panelSubmenuArticulos";
            this.panelSubmenuArticulos.Size = new System.Drawing.Size(131, 109);
            this.panelSubmenuArticulos.TabIndex = 0;
            this.panelSubmenuArticulos.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.GreenYellow;
            this.panel4.Location = new System.Drawing.Point(9, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 36);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.GreenYellow;
            this.panel5.Location = new System.Drawing.Point(9, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 36);
            this.panel5.TabIndex = 5;
            // 
            // btnConsultaArticulo
            // 
            this.btnConsultaArticulo.FlatAppearance.BorderSize = 0;
            this.btnConsultaArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnConsultaArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaArticulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaArticulo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnConsultaArticulo.Location = new System.Drawing.Point(21, 62);
            this.btnConsultaArticulo.Name = "btnConsultaArticulo";
            this.btnConsultaArticulo.Size = new System.Drawing.Size(107, 36);
            this.btnConsultaArticulo.TabIndex = 2;
            this.btnConsultaArticulo.Text = "Consultas Articulos";
            this.btnConsultaArticulo.UseVisualStyleBackColor = true;
            this.btnConsultaArticulo.Click += new System.EventHandler(this.btnConsultaArticulo_Click);
            this.btnConsultaArticulo.MouseEnter += new System.EventHandler(this.btnMouseEnterSub);
            this.btnConsultaArticulo.MouseLeave += new System.EventHandler(this.btnMouseLeaveSub);
            // 
            // btnAltaArticulo
            // 
            this.btnAltaArticulo.FlatAppearance.BorderSize = 0;
            this.btnAltaArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnAltaArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaArticulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaArticulo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAltaArticulo.Location = new System.Drawing.Point(21, 3);
            this.btnAltaArticulo.Name = "btnAltaArticulo";
            this.btnAltaArticulo.Size = new System.Drawing.Size(107, 36);
            this.btnAltaArticulo.TabIndex = 1;
            this.btnAltaArticulo.Text = "Altas\r\n Articulos";
            this.btnAltaArticulo.UseVisualStyleBackColor = true;
            this.btnAltaArticulo.Click += new System.EventHandler(this.btnAltaArticulo_Click);
            this.btnAltaArticulo.MouseEnter += new System.EventHandler(this.btnMouseEnterSub);
            this.btnAltaArticulo.MouseLeave += new System.EventHandler(this.btnMouseLeaveSub);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnClientes.Location = new System.Drawing.Point(25, 490);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(107, 36);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnPedidos
            // 
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPedidos.Location = new System.Drawing.Point(25, 319);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(107, 36);
            this.btnPedidos.TabIndex = 3;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            this.btnPedidos.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnPedidos.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnArticulos
            // 
            this.btnArticulos.FlatAppearance.BorderSize = 0;
            this.btnArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnArticulos.Location = new System.Drawing.Point(25, 126);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(107, 36);
            this.btnArticulos.TabIndex = 0;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            this.btnArticulos.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnArticulos.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Chartreuse;
            this.panelTop.Controls.Add(this.btnRestaurar);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1363, 35);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1283, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(29, 29);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 0;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1247, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 29);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = global::Tienda.Properties.Resources.maximizarAzul;
            this.btnMaximizar.Location = new System.Drawing.Point(1283, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(29, 29);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1318, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1363, 650);
            this.Controls.Add(this.panelContenedorPrincipal);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1363, 650);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelContenedorPrincipal.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelBodyBackPic)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoNav)).EndInit();
            this.panelSubmenuPedidos.ResumeLayout(false);
            this.panelSubmenuArticulos.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorPrincipal;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnConsultaArticulo;
        private System.Windows.Forms.Button btnAltaArticulo;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnDetallePedido;
        private System.Windows.Forms.Panel panelSubmenuPedidos;
        private System.Windows.Forms.Panel panelSubmenuArticulos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox panelBodyBackPic;
        private System.Windows.Forms.PictureBox logoNav;
    }
}

