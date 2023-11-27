namespace Tienda
{
    partial class FormConsultaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaArticulo));
            this.label1 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewConsultas = new System.Windows.Forms.ListView();
            this.colCodigoArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategoriaArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExistenciasArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panelTimerTick = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.timerHoraActual = new System.Windows.Forms.Timer(this.components);
            this.radioCodigo = new System.Windows.Forms.RadioButton();
            this.radioNombre = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTimerTick.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Articulos";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(452, 56);
            this.labelFecha.MinimumSize = new System.Drawing.Size(300, 25);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(300, 25);
            this.labelFecha.TabIndex = 35;
            this.labelFecha.Text = "labelFecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // listViewConsultas
            // 
            this.listViewConsultas.BackColor = System.Drawing.Color.Silver;
            this.listViewConsultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCodigoArticulo,
            this.colNombreArticulo,
            this.colCategoriaArticulo,
            this.colPrecioArticulo,
            this.colExistenciasArticulo});
            this.listViewConsultas.GridLines = true;
            this.listViewConsultas.HideSelection = false;
            this.listViewConsultas.Location = new System.Drawing.Point(31, 308);
            this.listViewConsultas.MultiSelect = false;
            this.listViewConsultas.Name = "listViewConsultas";
            this.listViewConsultas.Size = new System.Drawing.Size(1141, 65);
            this.listViewConsultas.TabIndex = 42;
            this.listViewConsultas.UseCompatibleStateImageBehavior = false;
            this.listViewConsultas.View = System.Windows.Forms.View.Details;
            // 
            // colCodigoArticulo
            // 
            this.colCodigoArticulo.Text = "Cod. Artículo";
            this.colCodigoArticulo.Width = 117;
            // 
            // colNombreArticulo
            // 
            this.colNombreArticulo.Text = "Nombre Articulo";
            this.colNombreArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNombreArticulo.Width = 258;
            // 
            // colCategoriaArticulo
            // 
            this.colCategoriaArticulo.Text = "Categoría";
            this.colCategoriaArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCategoriaArticulo.Width = 348;
            // 
            // colPrecioArticulo
            // 
            this.colPrecioArticulo.Text = "Precio (Ud./€)";
            this.colPrecioArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPrecioArticulo.Width = 194;
            // 
            // colExistenciasArticulo
            // 
            this.colExistenciasArticulo.Text = "Existencias Disponibles (Stock)";
            this.colExistenciasArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colExistenciasArticulo.Width = 226;
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
            this.btnLimpiar.Location = new System.Drawing.Point(619, 231);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 37);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseCompatibleTextRendering = true;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxBuscar.ForeColor = System.Drawing.Color.White;
            this.textBoxBuscar.Location = new System.Drawing.Point(365, 146);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(456, 23);
            this.textBoxBuscar.TabIndex = 33;
            this.textBoxBuscar.Text = "Escriba aquí a razón de la opción de búsqueda elegida ...";
            this.textBoxBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBuscar.Enter += new System.EventHandler(this.textBoxBuscar_Enter);
            this.textBoxBuscar.Leave += new System.EventHandler(this.textBoxBuscar_Leave);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnConsultar.Location = new System.Drawing.Point(420, 231);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(145, 37);
            this.btnConsultar.TabIndex = 39;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseCompatibleTextRendering = true;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panelTimerTick
            // 
            this.panelTimerTick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTimerTick.Controls.Add(this.labelHora);
            this.panelTimerTick.Controls.Add(this.pictureBox1);
            this.panelTimerTick.Location = new System.Drawing.Point(849, 14);
            this.panelTimerTick.Name = "panelTimerTick";
            this.panelTimerTick.Size = new System.Drawing.Size(328, 67);
            this.panelTimerTick.TabIndex = 36;
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
            this.btnInicio.Location = new System.Drawing.Point(518, 526);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(145, 37);
            this.btnInicio.TabIndex = 34;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseCompatibleTextRendering = true;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // timerHoraActual
            // 
            this.timerHoraActual.Enabled = true;
            this.timerHoraActual.Tick += new System.EventHandler(this.timerHoraActual_Tick);
            // 
            // radioCodigo
            // 
            this.radioCodigo.AutoSize = true;
            this.radioCodigo.Location = new System.Drawing.Point(132, 121);
            this.radioCodigo.Name = "radioCodigo";
            this.radioCodigo.Size = new System.Drawing.Size(170, 19);
            this.radioCodigo.TabIndex = 43;
            this.radioCodigo.TabStop = true;
            this.radioCodigo.Text = "Búsqueda por Código :";
            this.radioCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioCodigo.UseVisualStyleBackColor = true;
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.Location = new System.Drawing.Point(132, 168);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(176, 19);
            this.radioNombre.TabIndex = 44;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Búsqueda por Nombre :";
            this.radioNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioNombre.UseVisualStyleBackColor = true;
            // 
            // FormConsultaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1198, 615);
            this.Controls.Add(this.radioNombre);
            this.Controls.Add(this.radioCodigo);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.listViewConsultas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.panelTimerTick);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1198, 615);
            this.MinimumSize = new System.Drawing.Size(861, 456);
            this.Name = "FormConsultaArticulo";
            this.Text = "FormConsultaArticulo";
            this.Load += new System.EventHandler(this.FormConsultaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTimerTick.ResumeLayout(false);
            this.panelTimerTick.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewConsultas;
        private System.Windows.Forms.ColumnHeader colCodigoArticulo;
        private System.Windows.Forms.ColumnHeader colNombreArticulo;
        private System.Windows.Forms.ColumnHeader colCategoriaArticulo;
        private System.Windows.Forms.ColumnHeader colPrecioArticulo;
        private System.Windows.Forms.ColumnHeader colExistenciasArticulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panelTimerTick;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Timer timerHoraActual;
        private System.Windows.Forms.RadioButton radioCodigo;
        private System.Windows.Forms.RadioButton radioNombre;
    }
}