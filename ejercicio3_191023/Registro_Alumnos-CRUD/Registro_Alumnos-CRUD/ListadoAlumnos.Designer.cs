namespace Registro_Alumnos_CRUD
{
    partial class ListadoAlumnos
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colMailAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelfAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGeneroAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlumnos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.Location = new System.Drawing.Point(474, 507);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 34);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Apellido(s) :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(557, 96);
            this.textBox1.MaxLength = 60;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 27;
            // 
            // colMailAlum
            // 
            this.colMailAlum.HeaderText = "E-mail Alumno";
            this.colMailAlum.MinimumWidth = 6;
            this.colMailAlum.Name = "colMailAlum";
            this.colMailAlum.ReadOnly = true;
            this.colMailAlum.Width = 125;
            // 
            // colTelfAlum
            // 
            this.colTelfAlum.HeaderText = "Teléfono de Contacto";
            this.colTelfAlum.MinimumWidth = 6;
            this.colTelfAlum.Name = "colTelfAlum";
            this.colTelfAlum.ReadOnly = true;
            this.colTelfAlum.Width = 125;
            // 
            // colFecNac
            // 
            this.colFecNac.HeaderText = "Fecha de Nacimiento";
            this.colFecNac.MinimumWidth = 6;
            this.colFecNac.Name = "colFecNac";
            this.colFecNac.ReadOnly = true;
            this.colFecNac.Width = 125;
            // 
            // colGeneroAlum
            // 
            this.colGeneroAlum.HeaderText = "Género Alumno";
            this.colGeneroAlum.MinimumWidth = 6;
            this.colGeneroAlum.Name = "colGeneroAlum";
            this.colGeneroAlum.ReadOnly = true;
            this.colGeneroAlum.Width = 125;
            // 
            // colApellAlum
            // 
            this.colApellAlum.HeaderText = "Apellidos";
            this.colApellAlum.MinimumWidth = 6;
            this.colApellAlum.Name = "colApellAlum";
            this.colApellAlum.ReadOnly = true;
            this.colApellAlum.Width = 125;
            // 
            // colNomAlum
            // 
            this.colNomAlum.HeaderText = "Nombre Alumno";
            this.colNomAlum.MinimumWidth = 6;
            this.colNomAlum.Name = "colNomAlum";
            this.colNomAlum.ReadOnly = true;
            this.colNomAlum.Width = 125;
            // 
            // colCurso
            // 
            this.colCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCurso.HeaderText = "Curso / Ciclo";
            this.colCurso.MinimumWidth = 6;
            this.colCurso.Name = "colCurso";
            this.colCurso.ReadOnly = true;
            this.colCurso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCodAlum
            // 
            this.colCodAlum.HeaderText = "Código Alumno";
            this.colCodAlum.MinimumWidth = 6;
            this.colCodAlum.Name = "colCodAlum";
            this.colCodAlum.ReadOnly = true;
            this.colCodAlum.Width = 125;
            // 
            // dataAlumnos
            // 
            this.dataAlumnos.AllowUserToDeleteRows = false;
            this.dataAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataAlumnos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
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
            this.dataAlumnos.Location = new System.Drawing.Point(12, 167);
            this.dataAlumnos.Name = "dataAlumnos";
            this.dataAlumnos.ReadOnly = true;
            this.dataAlumnos.RowHeadersWidth = 51;
            this.dataAlumnos.RowTemplate.ReadOnly = true;
            this.dataAlumnos.Size = new System.Drawing.Size(1036, 334);
            this.dataAlumnos.TabIndex = 21;
            this.dataAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAlumnos_CellContentClick_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(315, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(289, 24);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Histórico Registro Alumnos";
            // 
            // textNombre
            // 
            this.textNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNombre.Location = new System.Drawing.Point(160, 96);
            this.textNombre.MaxLength = 50;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(249, 20);
            this.textNombre.TabIndex = 32;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(59, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 15);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre(s) :";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(886, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListadoAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1060, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataAlumnos);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ListadoAlumnos";
            this.Text = "ListadoAlumnos";
            this.Load += new System.EventHandler(this.ListadoAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMailAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelfAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeneroAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodAlum;
        private System.Windows.Forms.DataGridView dataAlumnos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button1;
    }
}