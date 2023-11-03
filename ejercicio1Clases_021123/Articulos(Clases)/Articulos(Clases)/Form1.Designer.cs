namespace Articulos_Clases_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMenuPedidos = new System.Windows.Forms.Button();
            this.btnMenuArticulos = new System.Windows.Forms.Button();
            this.btnIni = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pSubArt = new System.Windows.Forms.Panel();
            this.btnConsultaArticulo = new System.Windows.Forms.Button();
            this.btnAltas = new System.Windows.Forms.Button();
            this.pSubPed = new System.Windows.Forms.Panel();
            this.btnConsultaPedido = new System.Windows.Forms.Button();
            this.panelContenedorForm1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pMenu.SuspendLayout();
            this.pSubArt.SuspendLayout();
            this.pSubPed.SuspendLayout();
            this.panelContenedorForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pMenu.Controls.Add(this.button4);
            this.pMenu.Controls.Add(this.btnMenuPedidos);
            this.pMenu.Controls.Add(this.btnMenuArticulos);
            this.pMenu.Controls.Add(this.btnIni);
            this.pMenu.Controls.Add(this.btnClose);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(1016, 53);
            this.pMenu.TabIndex = 0;
            this.pMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Location = new System.Drawing.Point(650, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Clientes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnMenuPedidos
            // 
            this.btnMenuPedidos.FlatAppearance.BorderSize = 0;
            this.btnMenuPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPedidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPedidos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnMenuPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPedidos.Image")));
            this.btnMenuPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuPedidos.Location = new System.Drawing.Point(483, 6);
            this.btnMenuPedidos.Name = "btnMenuPedidos";
            this.btnMenuPedidos.Size = new System.Drawing.Size(140, 40);
            this.btnMenuPedidos.TabIndex = 4;
            this.btnMenuPedidos.Text = "Pedidos";
            this.btnMenuPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenuPedidos.UseVisualStyleBackColor = true;
            this.btnMenuPedidos.Click += new System.EventHandler(this.btnMenuPedidos_Click);
            this.btnMenuPedidos.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnMenuPedidos.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnMenuArticulos
            // 
            this.btnMenuArticulos.FlatAppearance.BorderSize = 0;
            this.btnMenuArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuArticulos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuArticulos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnMenuArticulos.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuArticulos.Image")));
            this.btnMenuArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuArticulos.Location = new System.Drawing.Point(317, 5);
            this.btnMenuArticulos.Name = "btnMenuArticulos";
            this.btnMenuArticulos.Size = new System.Drawing.Size(140, 40);
            this.btnMenuArticulos.TabIndex = 3;
            this.btnMenuArticulos.Text = "Articulos";
            this.btnMenuArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenuArticulos.UseVisualStyleBackColor = true;
            this.btnMenuArticulos.Click += new System.EventHandler(this.btnMenuArticulos_Click);
            this.btnMenuArticulos.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnMenuArticulos.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnIni
            // 
            this.btnIni.FlatAppearance.BorderSize = 0;
            this.btnIni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIni.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnIni.Location = new System.Drawing.Point(71, 6);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(140, 40);
            this.btnIni.TabIndex = 2;
            this.btnIni.Text = "Inicio";
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            this.btnIni.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnIni.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(957, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelIzq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Location = new System.Drawing.Point(0, 53);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(15, 513);
            this.panelIzq.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1016, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 566);
            this.panel3.TabIndex = 2;
            // 
            // pSubArt
            // 
            this.pSubArt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pSubArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSubArt.Controls.Add(this.btnConsultaArticulo);
            this.pSubArt.Controls.Add(this.btnAltas);
            this.pSubArt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSubArt.Location = new System.Drawing.Point(333, 54);
            this.pSubArt.Name = "pSubArt";
            this.pSubArt.Size = new System.Drawing.Size(139, 101);
            this.pSubArt.TabIndex = 0;
            this.pSubArt.Visible = false;
            // 
            // btnConsultaArticulo
            // 
            this.btnConsultaArticulo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultaArticulo.FlatAppearance.BorderSize = 0;
            this.btnConsultaArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnConsultaArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaArticulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaArticulo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnConsultaArticulo.Location = new System.Drawing.Point(3, 52);
            this.btnConsultaArticulo.Name = "btnConsultaArticulo";
            this.btnConsultaArticulo.Size = new System.Drawing.Size(131, 40);
            this.btnConsultaArticulo.TabIndex = 7;
            this.btnConsultaArticulo.Text = " Consultas";
            this.btnConsultaArticulo.UseVisualStyleBackColor = true;
            this.btnConsultaArticulo.Click += new System.EventHandler(this.btnConsultaArticulo_Click);
            // 
            // btnAltas
            // 
            this.btnAltas.FlatAppearance.BorderSize = 0;
            this.btnAltas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnAltas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltas.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnAltas.Location = new System.Drawing.Point(3, 5);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(131, 40);
            this.btnAltas.TabIndex = 6;
            this.btnAltas.Text = "Altas";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // pSubPed
            // 
            this.pSubPed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSubPed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pSubPed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSubPed.Controls.Add(this.btnConsultaPedido);
            this.pSubPed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSubPed.Location = new System.Drawing.Point(481, -1);
            this.pSubPed.Name = "pSubPed";
            this.pSubPed.Size = new System.Drawing.Size(139, 40);
            this.pSubPed.TabIndex = 8;
            this.pSubPed.Visible = false;
            // 
            // btnConsultaPedido
            // 
            this.btnConsultaPedido.FlatAppearance.BorderSize = 0;
            this.btnConsultaPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnConsultaPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPedido.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnConsultaPedido.Location = new System.Drawing.Point(3, 1);
            this.btnConsultaPedido.Name = "btnConsultaPedido";
            this.btnConsultaPedido.Size = new System.Drawing.Size(131, 34);
            this.btnConsultaPedido.TabIndex = 6;
            this.btnConsultaPedido.Text = "Consultas";
            this.btnConsultaPedido.UseVisualStyleBackColor = true;
            this.btnConsultaPedido.Click += new System.EventHandler(this.btnConsultaPedido_Click);
            // 
            // panelContenedorForm1
            // 
            this.panelContenedorForm1.BackColor = System.Drawing.Color.LightGray;
            this.panelContenedorForm1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedorForm1.Controls.Add(this.pictureBox2);
            this.panelContenedorForm1.Controls.Add(this.pictureBox1);
            this.panelContenedorForm1.Controls.Add(this.pSubPed);
            this.panelContenedorForm1.Location = new System.Drawing.Point(15, 53);
            this.panelContenedorForm1.MaximumSize = new System.Drawing.Size(1001, 566);
            this.panelContenedorForm1.MinimumSize = new System.Drawing.Size(1001, 500);
            this.panelContenedorForm1.Name = "panelContenedorForm1";
            this.panelContenedorForm1.Size = new System.Drawing.Size(1001, 513);
            this.panelContenedorForm1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(427, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(566, 512);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 332);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1031, 566);
            this.Controls.Add(this.panelIzq);
            this.Controls.Add(this.pSubArt);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.panelContenedorForm1);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pMenu.ResumeLayout(false);
            this.pSubArt.ResumeLayout(false);
            this.pSubPed.ResumeLayout(false);
            this.panelContenedorForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMenuPedidos;
        private System.Windows.Forms.Button btnMenuArticulos;
        private System.Windows.Forms.Panel pSubArt;
        private System.Windows.Forms.Button btnConsultaArticulo;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.Panel pSubPed;
        private System.Windows.Forms.Button btnConsultaPedido;
        private System.Windows.Forms.Panel panelContenedorForm1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

