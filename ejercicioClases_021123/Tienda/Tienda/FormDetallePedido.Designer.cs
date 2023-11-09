namespace Tienda
{
    partial class FormDetallePedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetallePedido));
            this.groupBoxDetallePedido = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelecPago = new System.Windows.Forms.ComboBox();
            this.comboBoxSelecArticulos = new System.Windows.Forms.ComboBox();
            this.ListViewDetallePedido = new System.Windows.Forms.ListView();
            this.columnHeaderCodArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrecioUnidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCantidadPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTipoPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescuento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRecargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.timerHoraActual = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTimerTick = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.groupBoxDetallePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTimerTick.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDetallePedido
            // 
            this.groupBoxDetallePedido.Controls.Add(this.label7);
            this.groupBoxDetallePedido.Controls.Add(this.labelTotal);
            this.groupBoxDetallePedido.Controls.Add(this.textBoxCantidad);
            this.groupBoxDetallePedido.Controls.Add(this.label5);
            this.groupBoxDetallePedido.Controls.Add(this.label4);
            this.groupBoxDetallePedido.Controls.Add(this.label1);
            this.groupBoxDetallePedido.Controls.Add(this.comboBoxSelecPago);
            this.groupBoxDetallePedido.Controls.Add(this.comboBoxSelecArticulos);
            this.groupBoxDetallePedido.Location = new System.Drawing.Point(13, 74);
            this.groupBoxDetallePedido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDetallePedido.MaximumSize = new System.Drawing.Size(1198, 615);
            this.groupBoxDetallePedido.Name = "groupBoxDetallePedido";
            this.groupBoxDetallePedido.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDetallePedido.Size = new System.Drawing.Size(1172, 207);
            this.groupBoxDetallePedido.TabIndex = 3;
            this.groupBoxDetallePedido.TabStop = false;
            this.groupBoxDetallePedido.Text = "Pedidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(871, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Pedido/.€";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(949, 99);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(86, 18);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "labelTotal";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxCantidad.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxCantidad.Location = new System.Drawing.Point(601, 99);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(195, 23);
            this.textBoxCantidad.TabIndex = 7;
            this.textBoxCantidad.Text = "...";
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCantidad.Click += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Uds./Artículo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selecciona Tipo de Pago :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona Artículo :";
            // 
            // comboBoxSelecPago
            // 
            this.comboBoxSelecPago.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxSelecPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelecPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSelecPago.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxSelecPago.FormattingEnabled = true;
            this.comboBoxSelecPago.Items.AddRange(new object[] {
            "Tarjeta débito o crédito",
            "PayPal",
            "Transferencia bancaria",
            "Efectivo"});
            this.comboBoxSelecPago.Location = new System.Drawing.Point(39, 125);
            this.comboBoxSelecPago.Name = "comboBoxSelecPago";
            this.comboBoxSelecPago.Size = new System.Drawing.Size(443, 23);
            this.comboBoxSelecPago.TabIndex = 1;
            this.comboBoxSelecPago.Text = "Pinche para elegir Artículo";
            // 
            // comboBoxSelecArticulos
            // 
            this.comboBoxSelecArticulos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxSelecArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelecArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSelecArticulos.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxSelecArticulos.FormattingEnabled = true;
            this.comboBoxSelecArticulos.Items.AddRange(new object[] {
            "Colección Smartphones",
            "Colección PCs Sobremesa",
            "Colección PCs Portátiles"});
            this.comboBoxSelecArticulos.Location = new System.Drawing.Point(39, 56);
            this.comboBoxSelecArticulos.Name = "comboBoxSelecArticulos";
            this.comboBoxSelecArticulos.Size = new System.Drawing.Size(443, 23);
            this.comboBoxSelecArticulos.TabIndex = 0;
            this.comboBoxSelecArticulos.Text = "Pinche para elegir Artículo";
            this.comboBoxSelecArticulos.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelecArticulos_SelectedIndexChanged);
            // 
            // ListViewDetallePedido
            // 
            this.ListViewDetallePedido.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.ListViewDetallePedido.BackColor = System.Drawing.Color.Silver;
            this.ListViewDetallePedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCodArticulo,
            this.columnHeaderArticulo,
            this.columnHeaderPrecioUnidad,
            this.columnHeaderCategoria,
            this.columnHeaderCantidadPedido,
            this.columnHeaderTipoPago,
            this.columnHeaderDescuento,
            this.columnHeaderRecargo,
            this.columnHeaderTotal});
            this.ListViewDetallePedido.ForeColor = System.Drawing.SystemColors.Window;
            this.ListViewDetallePedido.GridLines = true;
            this.ListViewDetallePedido.HideSelection = false;
            this.ListViewDetallePedido.Location = new System.Drawing.Point(12, 329);
            this.ListViewDetallePedido.Name = "ListViewDetallePedido";
            this.ListViewDetallePedido.Size = new System.Drawing.Size(1172, 209);
            this.ListViewDetallePedido.TabIndex = 4;
            this.ListViewDetallePedido.UseCompatibleStateImageBehavior = false;
            this.ListViewDetallePedido.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCodArticulo
            // 
            this.columnHeaderCodArticulo.Text = "Cod. Articulo";
            this.columnHeaderCodArticulo.Width = 105;
            // 
            // columnHeaderArticulo
            // 
            this.columnHeaderArticulo.Text = "Articulo";
            this.columnHeaderArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderArticulo.Width = 153;
            // 
            // columnHeaderPrecioUnidad
            // 
            this.columnHeaderPrecioUnidad.Text = "Ud./€";
            this.columnHeaderPrecioUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPrecioUnidad.Width = 70;
            // 
            // columnHeaderCategoria
            // 
            this.columnHeaderCategoria.DisplayIndex = 8;
            this.columnHeaderCategoria.Text = "Categoría";
            this.columnHeaderCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCategoria.Width = 130;
            // 
            // columnHeaderCantidadPedido
            // 
            this.columnHeaderCantidadPedido.DisplayIndex = 3;
            this.columnHeaderCantidadPedido.Text = "Uds./Pedido";
            this.columnHeaderCantidadPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCantidadPedido.Width = 110;
            // 
            // columnHeaderTipoPago
            // 
            this.columnHeaderTipoPago.DisplayIndex = 4;
            this.columnHeaderTipoPago.Text = "Pago Elegido";
            this.columnHeaderTipoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTipoPago.Width = 150;
            // 
            // columnHeaderDescuento
            // 
            this.columnHeaderDescuento.DisplayIndex = 5;
            this.columnHeaderDescuento.Text = "Descuento Aplicable";
            this.columnHeaderDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDescuento.Width = 160;
            // 
            // columnHeaderRecargo
            // 
            this.columnHeaderRecargo.DisplayIndex = 6;
            this.columnHeaderRecargo.Text = "Recargo Aplicable";
            this.columnHeaderRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderRecargo.Width = 150;
            // 
            // columnHeaderTotal
            // 
            this.columnHeaderTotal.DisplayIndex = 7;
            this.columnHeaderTotal.Text = "Totalización / .€";
            this.columnHeaderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTotal.Width = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Pedido :";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(533, 46);
            this.labelFecha.MinimumSize = new System.Drawing.Size(300, 25);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(300, 25);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "labelFecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Registro de Pedidos";
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.LightCyan;
            this.btnInicio.Location = new System.Drawing.Point(547, 566);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(145, 37);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseCompatibleTextRendering = true;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnRegistrar.Location = new System.Drawing.Point(77, 286);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(145, 37);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnLimpiar.Location = new System.Drawing.Point(240, 286);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 37);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseCompatibleTextRendering = true;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // timerHoraActual
            // 
            this.timerHoraActual.Tick += new System.EventHandler(this.timerHoraActual_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda.Properties.Resources.logoComGreen;
            this.pictureBox1.Location = new System.Drawing.Point(253, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panelTimerTick
            // 
            this.panelTimerTick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTimerTick.Controls.Add(this.labelHora);
            this.panelTimerTick.Controls.Add(this.pictureBox1);
            this.panelTimerTick.Location = new System.Drawing.Point(856, 7);
            this.panelTimerTick.Name = "panelTimerTick";
            this.panelTimerTick.Size = new System.Drawing.Size(328, 67);
            this.panelTimerTick.TabIndex = 12;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelHora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHora.Location = new System.Drawing.Point(12, 22);
            this.labelHora.MinimumSize = new System.Drawing.Size(230, 25);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(230, 25);
            this.labelHora.TabIndex = 13;
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1198, 615);
            this.Controls.Add(this.panelTimerTick);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ListViewDetallePedido);
            this.Controls.Add(this.groupBoxDetallePedido);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1597, 710);
            this.Name = "FormDetallePedido";
            this.Text = "FormDetallePedido";
            this.Load += new System.EventHandler(this.FormDetallePedido_Load);
            this.groupBoxDetallePedido.ResumeLayout(false);
            this.groupBoxDetallePedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTimerTick.ResumeLayout(false);
            this.panelTimerTick.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDetallePedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelecPago;
        private System.Windows.Forms.ComboBox comboBoxSelecArticulos;
        private System.Windows.Forms.ListView ListViewDetallePedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ColumnHeader columnHeaderCodArticulo;
        private System.Windows.Forms.Timer timerHoraActual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTimerTick;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.ColumnHeader columnHeaderArticulo;
        private System.Windows.Forms.ColumnHeader columnHeaderPrecioUnidad;
        private System.Windows.Forms.ColumnHeader columnHeaderCantidadPedido;
        private System.Windows.Forms.ColumnHeader columnHeaderDescuento;
        private System.Windows.Forms.ColumnHeader columnHeaderTipoPago;
        private System.Windows.Forms.ColumnHeader columnHeaderRecargo;
        private System.Windows.Forms.ColumnHeader columnHeaderTotal;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoria;
    }
}