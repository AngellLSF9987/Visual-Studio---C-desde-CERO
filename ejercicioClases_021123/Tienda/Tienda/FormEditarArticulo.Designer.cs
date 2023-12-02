namespace Tienda
{
    partial class FormEditarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarArticulo));
            this.label6 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.panelTimerTick = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidadArticulo = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.ComboBoxNuevaCategoria = new System.Windows.Forms.ComboBox();
            this.TextBoxNuevoNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerHoraActual = new System.Windows.Forms.Timer(this.components);
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panelTimerTick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "Editar Artículo";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(167, 111);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFecha.MinimumSize = new System.Drawing.Size(400, 29);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(400, 29);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "labelFecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTimerTick
            // 
            this.panelTimerTick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTimerTick.Controls.Add(this.labelHora);
            this.panelTimerTick.Controls.Add(this.pictureBox1);
            this.panelTimerTick.Location = new System.Drawing.Point(285, 22);
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
            // TextBoxCantidad
            // 
            this.TextBoxCantidad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxCantidad.ForeColor = System.Drawing.Color.White;
            this.TextBoxCantidad.Location = new System.Drawing.Point(100, 295);
            this.TextBoxCantidad.Name = "TextBoxCantidad";
            this.TextBoxCantidad.Size = new System.Drawing.Size(205, 23);
            this.TextBoxCantidad.TabIndex = 31;
            this.TextBoxCantidad.Text = "Define Cantidad Disponible ...";
            // 
            // labelCantidadArticulo
            // 
            this.labelCantidadArticulo.AutoSize = true;
            this.labelCantidadArticulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadArticulo.Location = new System.Drawing.Point(81, 258);
            this.labelCantidadArticulo.Name = "labelCantidadArticulo";
            this.labelCantidadArticulo.Size = new System.Drawing.Size(208, 18);
            this.labelCantidadArticulo.TabIndex = 37;
            this.labelCantidadArticulo.Text = "Cantidad (Uds./Articulo) :";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTotal.Location = new System.Drawing.Point(438, 295);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(2, 20);
            this.LabelTotal.TabIndex = 36;
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxNuevaCategoria
            // 
            this.ComboBoxNuevaCategoria.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxNuevaCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxNuevaCategoria.ForeColor = System.Drawing.Color.White;
            this.ComboBoxNuevaCategoria.FormattingEnabled = true;
            this.ComboBoxNuevaCategoria.Items.AddRange(new object[] {
            "Colección Smartphones",
            "Colección PCs Sobremesa",
            "Colección PCs Portátiles"});
            this.ComboBoxNuevaCategoria.Location = new System.Drawing.Point(438, 195);
            this.ComboBoxNuevaCategoria.Name = "ComboBoxNuevaCategoria";
            this.ComboBoxNuevaCategoria.Size = new System.Drawing.Size(276, 23);
            this.ComboBoxNuevaCategoria.TabIndex = 35;
            this.ComboBoxNuevaCategoria.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNuevaCategoria_SelectedIndexChanged);
            // 
            // TextBoxNuevoNombre
            // 
            this.TextBoxNuevoNombre.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxNuevoNombre.ForeColor = System.Drawing.Color.White;
            this.TextBoxNuevoNombre.Location = new System.Drawing.Point(51, 195);
            this.TextBoxNuevoNombre.Name = "TextBoxNuevoNombre";
            this.TextBoxNuevoNombre.Size = new System.Drawing.Size(296, 23);
            this.TextBoxNuevoNombre.TabIndex = 38;
            this.TextBoxNuevoNombre.Text = "Escriba aquí el Nombre del Nuevo Artículo ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Precio (Ud./€) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Categoria Articulo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre Articulo :";
            // 
            // timerHoraActual
            // 
            this.timerHoraActual.Tick += new System.EventHandler(this.timerHoraActual_Tick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(170, 353);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(377, 65);
            this.btnConfirmar.TabIndex = 39;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FormEditarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(746, 451);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.TextBoxCantidad);
            this.Controls.Add(this.labelCantidadArticulo);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.ComboBoxNuevaCategoria);
            this.Controls.Add(this.TextBoxNuevoNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.panelTimerTick);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(746, 451);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FormEditarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarArticulo";
            this.Load += new System.EventHandler(this.FormEditarArticulo_Load);
            this.panelTimerTick.ResumeLayout(false);
            this.panelTimerTick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Panel panelTimerTick;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBoxCantidad;
        private System.Windows.Forms.Label labelCantidadArticulo;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.ComboBox ComboBoxNuevaCategoria;
        private System.Windows.Forms.TextBox TextBoxNuevoNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerHoraActual;
        private System.Windows.Forms.Button btnConfirmar;
    }
}