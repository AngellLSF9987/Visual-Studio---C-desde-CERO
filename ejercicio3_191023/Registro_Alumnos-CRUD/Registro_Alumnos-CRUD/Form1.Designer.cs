namespace Registro_Alumnos_CRUD
{
    partial class Registro_Alumnos
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCurso = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFecNac = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataAlumnos = new System.Windows.Forms.DataGridView();
            this.colCodAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGeneroAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelfAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMailAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbGenAlum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(91, 49);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(53, 15);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso :";
            this.lblCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(61, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre(s) :";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(391, 189);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(122, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contraseña Reg. :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(61, 121);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(84, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido(s) :";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(443, 95);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 15);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono :";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(458, 121);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(55, 15);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "E-mail :";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Nacimiento :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textCurso
            // 
            this.textCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCurso.Location = new System.Drawing.Point(171, 44);
            this.textCurso.MaxLength = 300;
            this.textCurso.Name = "textCurso";
            this.textCurso.Size = new System.Drawing.Size(204, 20);
            this.textCurso.TabIndex = 7;
            // 
            // textEmail
            // 
            this.textEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEmail.Location = new System.Drawing.Point(548, 121);
            this.textEmail.MaxLength = 80;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(203, 20);
            this.textEmail.TabIndex = 8;
            // 
            // textTelefono
            // 
            this.textTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTelefono.Location = new System.Drawing.Point(548, 90);
            this.textTelefono.MaxLength = 10;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(203, 20);
            this.textTelefono.TabIndex = 9;
            // 
            // textApellido
            // 
            this.textApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textApellido.Location = new System.Drawing.Point(171, 116);
            this.textApellido.MaxLength = 60;
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(204, 20);
            this.textApellido.TabIndex = 11;
            // 
            // textNombre
            // 
            this.textNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNombre.Location = new System.Drawing.Point(171, 90);
            this.textNombre.MaxLength = 50;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(204, 20);
            this.textNombre.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(548, 184);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(203, 20);
            this.textBox7.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Género :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateFecNac
            // 
            this.dateFecNac.Location = new System.Drawing.Point(171, 184);
            this.dateFecNac.Name = "dateFecNac";
            this.dateFecNac.Size = new System.Drawing.Size(204, 20);
            this.dateFecNac.TabIndex = 16;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(64, 244);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 30);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar / Actualizar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(639, 244);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 30);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataAlumnos
            // 
            this.dataAlumnos.AllowUserToAddRows = false;
            this.dataAlumnos.AllowUserToDeleteRows = false;
            this.dataAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataAlumnos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodAlum,
            this.colCurso,
            this.colNomAlum,
            this.colApellAlum,
            this.colGeneroAlum,
            this.colFecNac,
            this.colTelfAlum,
            this.colMailAlum});
            this.dataAlumnos.Location = new System.Drawing.Point(12, 280);
            this.dataAlumnos.Name = "dataAlumnos";
            this.dataAlumnos.ReadOnly = true;
            this.dataAlumnos.Size = new System.Drawing.Size(819, 338);
            this.dataAlumnos.TabIndex = 20;
            this.dataAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAlumnos_CellContentClick);
            // 
            // colCodAlum
            // 
            this.colCodAlum.HeaderText = "Código Alumno";
            this.colCodAlum.Name = "colCodAlum";
            this.colCodAlum.ReadOnly = true;
            // 
            // colCurso
            // 
            this.colCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCurso.HeaderText = "Curso / Ciclo";
            this.colCurso.Name = "colCurso";
            this.colCurso.ReadOnly = true;
            this.colCurso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNomAlum
            // 
            this.colNomAlum.HeaderText = "Nombre Alumno";
            this.colNomAlum.Name = "colNomAlum";
            this.colNomAlum.ReadOnly = true;
            // 
            // colApellAlum
            // 
            this.colApellAlum.HeaderText = "Apellidos";
            this.colApellAlum.Name = "colApellAlum";
            this.colApellAlum.ReadOnly = true;
            // 
            // colGeneroAlum
            // 
            this.colGeneroAlum.HeaderText = "Género Alumno";
            this.colGeneroAlum.Name = "colGeneroAlum";
            this.colGeneroAlum.ReadOnly = true;
            // 
            // colFecNac
            // 
            this.colFecNac.HeaderText = "Fecha de Nacimiento";
            this.colFecNac.Name = "colFecNac";
            this.colFecNac.ReadOnly = true;
            // 
            // colTelfAlum
            // 
            this.colTelfAlum.HeaderText = "Teléfono de Contacto";
            this.colTelfAlum.Name = "colTelfAlum";
            this.colTelfAlum.ReadOnly = true;
            // 
            // colMailAlum
            // 
            this.colMailAlum.HeaderText = "E-mail Alumno";
            this.colMailAlum.Name = "colMailAlum";
            this.colMailAlum.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(442, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(309, 24);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Formulario Registro Alumnos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(345, 244);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 30);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbGenAlum
            // 
            this.cmbGenAlum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGenAlum.FormattingEnabled = true;
            this.cmbGenAlum.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No Binario"});
            this.cmbGenAlum.Location = new System.Drawing.Point(170, 153);
            this.cmbGenAlum.Name = "cmbGenAlum";
            this.cmbGenAlum.Size = new System.Drawing.Size(205, 21);
            this.cmbGenAlum.TabIndex = 25;
            this.cmbGenAlum.Text = "Seleccione género";
            // 
            // Registro_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(843, 630);
            this.Controls.Add(this.cmbGenAlum);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataAlumnos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dateFecNac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCurso);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Registro_Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Alumnos";
            this.Load += new System.EventHandler(this.Registro_Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCurso;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFecNac;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dataAlumnos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeneroAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelfAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMailAlum;
        private System.Windows.Forms.ComboBox cmbGenAlum;
    }
}

