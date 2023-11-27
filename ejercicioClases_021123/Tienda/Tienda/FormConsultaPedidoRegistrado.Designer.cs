namespace Tienda
{
    partial class FormConsultaPedidoRegistrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaPedidoRegistrado));
            this.panelTimerTick = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.timerHoraActual = new System.Windows.Forms.Timer(this.components);
            this.labelCodigoPedido = new System.Windows.Forms.Label();
            this.labelCantidadPedido = new System.Windows.Forms.Label();
            this.labelCodigoCliente = new System.Windows.Forms.Label();
            this.labelListaDetalleArticulosPedido = new System.Windows.Forms.Label();
            this.labelTipoPago = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPrecioSinDescuentoRecargo = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelPrecioFinal = new System.Windows.Forms.Label();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.lblCantidadPedido = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblPorcentajeDescuentoRecargo = new System.Windows.Forms.Label();
            this.lblPrecioSinDescuentoRecargo = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.listViewArticulosPedido = new System.Windows.Forms.ListView();
            this.colCodigoArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioUnidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidadUnidadesPrecioFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTimerTick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTimerTick
            // 
            this.panelTimerTick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTimerTick.Controls.Add(this.labelHora);
            this.panelTimerTick.Controls.Add(this.pictureBox1);
            this.panelTimerTick.Location = new System.Drawing.Point(293, 20);
            this.panelTimerTick.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelTimerTick.Name = "panelTimerTick";
            this.panelTimerTick.Size = new System.Drawing.Size(436, 76);
            this.panelTimerTick.TabIndex = 21;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelHora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHora.Location = new System.Drawing.Point(16, 25);
            this.labelHora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHora.MinimumSize = new System.Drawing.Size(306, 29);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(306, 29);
            this.labelHora.TabIndex = 13;
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "Detalle Pedido";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(159, 110);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFecha.MinimumSize = new System.Drawing.Size(400, 29);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(400, 29);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "labelFecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerHoraActual
            // 
            this.timerHoraActual.Tick += new System.EventHandler(this.timerHoraActual_Tick);
            // 
            // labelCodigoPedido
            // 
            this.labelCodigoPedido.AutoSize = true;
            this.labelCodigoPedido.Location = new System.Drawing.Point(22, 170);
            this.labelCodigoPedido.Name = "labelCodigoPedido";
            this.labelCodigoPedido.Size = new System.Drawing.Size(92, 15);
            this.labelCodigoPedido.TabIndex = 22;
            this.labelCodigoPedido.Text = "Cod. Pedido :";
            // 
            // labelCantidadPedido
            // 
            this.labelCantidadPedido.AutoSize = true;
            this.labelCantidadPedido.Location = new System.Drawing.Point(22, 208);
            this.labelCantidadPedido.Name = "labelCantidadPedido";
            this.labelCantidadPedido.Size = new System.Drawing.Size(98, 15);
            this.labelCantidadPedido.TabIndex = 23;
            this.labelCantidadPedido.Text = "Uds. / Pedido :";
            // 
            // labelCodigoCliente
            // 
            this.labelCodigoCliente.AutoSize = true;
            this.labelCodigoCliente.Location = new System.Drawing.Point(359, 170);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(94, 15);
            this.labelCodigoCliente.TabIndex = 24;
            this.labelCodigoCliente.Text = "Cod. Cliente :";
            // 
            // labelListaDetalleArticulosPedido
            // 
            this.labelListaDetalleArticulosPedido.AutoSize = true;
            this.labelListaDetalleArticulosPedido.Location = new System.Drawing.Point(22, 396);
            this.labelListaDetalleArticulosPedido.Name = "labelListaDetalleArticulosPedido";
            this.labelListaDetalleArticulosPedido.Size = new System.Drawing.Size(213, 15);
            this.labelListaDetalleArticulosPedido.TabIndex = 25;
            this.labelListaDetalleArticulosPedido.Text = "Detalle Lista Artículos / Pedido :";
            // 
            // labelTipoPago
            // 
            this.labelTipoPago.AutoSize = true;
            this.labelTipoPago.Location = new System.Drawing.Point(22, 319);
            this.labelTipoPago.Name = "labelTipoPago";
            this.labelTipoPago.Size = new System.Drawing.Size(306, 15);
            this.labelTipoPago.TabIndex = 26;
            this.labelTipoPago.Text = "Descuento o Recargo Aplicado / Tipo de Pago :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tipo de Pago :";
            // 
            // labelPrecioSinDescuentoRecargo
            // 
            this.labelPrecioSinDescuentoRecargo.AutoSize = true;
            this.labelPrecioSinDescuentoRecargo.Location = new System.Drawing.Point(429, 257);
            this.labelPrecioSinDescuentoRecargo.Name = "labelPrecioSinDescuentoRecargo";
            this.labelPrecioSinDescuentoRecargo.Size = new System.Drawing.Size(202, 15);
            this.labelPrecioSinDescuentoRecargo.TabIndex = 28;
            this.labelPrecioSinDescuentoRecargo.Text = "Precio sin Aplicables / PVP .€ :";
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Location = new System.Drawing.Point(359, 208);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(116, 15);
            this.labelNombreCliente.TabIndex = 29;
            this.labelNombreCliente.Text = "Nombre Cliente :";
            // 
            // labelPrecioFinal
            // 
            this.labelPrecioFinal.AutoSize = true;
            this.labelPrecioFinal.Location = new System.Drawing.Point(429, 357);
            this.labelPrecioFinal.Name = "labelPrecioFinal";
            this.labelPrecioFinal.Size = new System.Drawing.Size(144, 15);
            this.labelPrecioFinal.TabIndex = 30;
            this.labelPrecioFinal.Text = "Precio Final / PVP .€ :";
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Location = new System.Drawing.Point(159, 170);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(23, 15);
            this.lblCodigoPedido.TabIndex = 31;
            this.lblCodigoPedido.Text = "....";
            // 
            // lblCantidadPedido
            // 
            this.lblCantidadPedido.AutoSize = true;
            this.lblCantidadPedido.Location = new System.Drawing.Point(159, 208);
            this.lblCantidadPedido.Name = "lblCantidadPedido";
            this.lblCantidadPedido.Size = new System.Drawing.Size(19, 15);
            this.lblCantidadPedido.TabIndex = 32;
            this.lblCantidadPedido.Text = "...";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Location = new System.Drawing.Point(488, 170);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(19, 15);
            this.lblCodigoCliente.TabIndex = 33;
            this.lblCodigoCliente.Text = "...";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(488, 208);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(19, 15);
            this.lblNombreCliente.TabIndex = 34;
            this.lblNombreCliente.Text = "...";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(159, 274);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(19, 15);
            this.lblTipoPago.TabIndex = 35;
            this.lblTipoPago.Text = "...";
            // 
            // lblPorcentajeDescuentoRecargo
            // 
            this.lblPorcentajeDescuentoRecargo.AutoSize = true;
            this.lblPorcentajeDescuentoRecargo.Location = new System.Drawing.Point(334, 319);
            this.lblPorcentajeDescuentoRecargo.Name = "lblPorcentajeDescuentoRecargo";
            this.lblPorcentajeDescuentoRecargo.Size = new System.Drawing.Size(19, 15);
            this.lblPorcentajeDescuentoRecargo.TabIndex = 36;
            this.lblPorcentajeDescuentoRecargo.Text = "...";
            // 
            // lblPrecioSinDescuentoRecargo
            // 
            this.lblPrecioSinDescuentoRecargo.AutoSize = true;
            this.lblPrecioSinDescuentoRecargo.Location = new System.Drawing.Point(646, 257);
            this.lblPrecioSinDescuentoRecargo.Name = "lblPrecioSinDescuentoRecargo";
            this.lblPrecioSinDescuentoRecargo.Size = new System.Drawing.Size(19, 15);
            this.lblPrecioSinDescuentoRecargo.TabIndex = 37;
            this.lblPrecioSinDescuentoRecargo.Text = "...";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(646, 357);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(19, 15);
            this.lblPrecioFinal.TabIndex = 38;
            this.lblPrecioFinal.Text = "...";
            // 
            // listViewArticulosPedido
            // 
            this.listViewArticulosPedido.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewArticulosPedido.BackColor = System.Drawing.Color.Silver;
            this.listViewArticulosPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCodigoArticulo,
            this.colNombreArticulo,
            this.colNombreCategoria,
            this.colPrecioUnidad,
            this.colCantidadUnidadesPrecioFinal});
            this.listViewArticulosPedido.FullRowSelect = true;
            this.listViewArticulosPedido.GridLines = true;
            this.listViewArticulosPedido.HideSelection = false;
            this.listViewArticulosPedido.Location = new System.Drawing.Point(25, 423);
            this.listViewArticulosPedido.Name = "listViewArticulosPedido";
            this.listViewArticulosPedido.Size = new System.Drawing.Size(725, 164);
            this.listViewArticulosPedido.TabIndex = 39;
            this.listViewArticulosPedido.UseCompatibleStateImageBehavior = false;
            this.listViewArticulosPedido.View = System.Windows.Forms.View.Details;
            // 
            // colCodigoArticulo
            // 
            this.colCodigoArticulo.Text = "Cod. Articulo";
            this.colCodigoArticulo.Width = 100;
            // 
            // colNombreArticulo
            // 
            this.colNombreArticulo.Text = "Nombre Articulo";
            this.colNombreArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNombreArticulo.Width = 220;
            // 
            // colNombreCategoria
            // 
            this.colNombreCategoria.Text = "Categoria";
            this.colNombreCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNombreCategoria.Width = 220;
            // 
            // colPrecioUnidad
            // 
            this.colPrecioUnidad.Text = "Ud. / €";
            this.colPrecioUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPrecioUnidad.Width = 80;
            // 
            // colCantidadUnidadesPrecioFinal
            // 
            this.colCantidadUnidadesPrecioFinal.Text = "Uds. / .€";
            this.colCantidadUnidadesPrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCantidadUnidadesPrecioFinal.Width = 100;
            // 
            // FormConsultaPedidoRegistrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(781, 625);
            this.Controls.Add(this.listViewArticulosPedido);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblPrecioSinDescuentoRecargo);
            this.Controls.Add(this.lblPorcentajeDescuentoRecargo);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.lblCantidadPedido);
            this.Controls.Add(this.lblCodigoPedido);
            this.Controls.Add(this.labelPrecioFinal);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.labelPrecioSinDescuentoRecargo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTipoPago);
            this.Controls.Add(this.labelListaDetalleArticulosPedido);
            this.Controls.Add(this.labelCodigoCliente);
            this.Controls.Add(this.labelCantidadPedido);
            this.Controls.Add(this.labelCodigoPedido);
            this.Controls.Add(this.panelTimerTick);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelFecha);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormConsultaPedidoRegistrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaPedidoRegistrado";
            this.Load += new System.EventHandler(this.FormConsultaPedidoRegistrado_Load);
            this.panelTimerTick.ResumeLayout(false);
            this.panelTimerTick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTimerTick;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer timerHoraActual;
        private System.Windows.Forms.Label labelCodigoPedido;
        private System.Windows.Forms.Label labelCantidadPedido;
        private System.Windows.Forms.Label labelCodigoCliente;
        private System.Windows.Forms.Label labelListaDetalleArticulosPedido;
        private System.Windows.Forms.Label labelTipoPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPrecioSinDescuentoRecargo;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Label labelPrecioFinal;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.Label lblCantidadPedido;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblPorcentajeDescuentoRecargo;
        private System.Windows.Forms.Label lblPrecioSinDescuentoRecargo;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.ListView listViewArticulosPedido;
        private System.Windows.Forms.ColumnHeader colCodigoArticulo;
        private System.Windows.Forms.ColumnHeader colNombreArticulo;
        private System.Windows.Forms.ColumnHeader colNombreCategoria;
        private System.Windows.Forms.ColumnHeader colPrecioUnidad;
        private System.Windows.Forms.ColumnHeader colCantidadUnidadesPrecioFinal;
    }
}