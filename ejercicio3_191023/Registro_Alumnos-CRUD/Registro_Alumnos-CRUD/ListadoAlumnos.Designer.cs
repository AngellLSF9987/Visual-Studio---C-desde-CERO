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
            this.dataAlumnos = new System.Windows.Forms.DataGridView();
            this.colCodAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGeneroAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelfAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMailAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).BeginInit();
            this.SuspendLayout();
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
            this.dataAlumnos.Location = new System.Drawing.Point(12, 12);
            this.dataAlumnos.Name = "dataAlumnos";
            this.dataAlumnos.ReadOnly = true;
            this.dataAlumnos.RowHeadersWidth = 51;
            this.dataAlumnos.Size = new System.Drawing.Size(925, 465);
            this.dataAlumnos.TabIndex = 21;
            this.dataAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAlumnos_CellContentClick_1);
            // 
            // colCodAlum
            // 
            this.colCodAlum.HeaderText = "Código Alumno";
            this.colCodAlum.MinimumWidth = 6;
            this.colCodAlum.Name = "colCodAlum";
            this.colCodAlum.ReadOnly = true;
            this.colCodAlum.Width = 125;
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
            // colNomAlum
            // 
            this.colNomAlum.HeaderText = "Nombre Alumno";
            this.colNomAlum.MinimumWidth = 6;
            this.colNomAlum.Name = "colNomAlum";
            this.colNomAlum.ReadOnly = true;
            this.colNomAlum.Width = 125;
            // 
            // colApellAlum
            // 
            this.colApellAlum.HeaderText = "Apellidos";
            this.colApellAlum.MinimumWidth = 6;
            this.colApellAlum.Name = "colApellAlum";
            this.colApellAlum.ReadOnly = true;
            this.colApellAlum.Width = 125;
            // 
            // colGeneroAlum
            // 
            this.colGeneroAlum.HeaderText = "Género Alumno";
            this.colGeneroAlum.MinimumWidth = 6;
            this.colGeneroAlum.Name = "colGeneroAlum";
            this.colGeneroAlum.ReadOnly = true;
            this.colGeneroAlum.Width = 125;
            // 
            // colFecNac
            // 
            this.colFecNac.HeaderText = "Fecha de Nacimiento";
            this.colFecNac.MinimumWidth = 6;
            this.colFecNac.Name = "colFecNac";
            this.colFecNac.ReadOnly = true;
            this.colFecNac.Width = 125;
            // 
            // colTelfAlum
            // 
            this.colTelfAlum.HeaderText = "Teléfono de Contacto";
            this.colTelfAlum.MinimumWidth = 6;
            this.colTelfAlum.Name = "colTelfAlum";
            this.colTelfAlum.ReadOnly = true;
            this.colTelfAlum.Width = 125;
            // 
            // colMailAlum
            // 
            this.colMailAlum.HeaderText = "E-mail Alumno";
            this.colMailAlum.MinimumWidth = 6;
            this.colMailAlum.Name = "colMailAlum";
            this.colMailAlum.ReadOnly = true;
            this.colMailAlum.Width = 125;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.Location = new System.Drawing.Point(418, 507);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 34);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ListadoAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(949, 563);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataAlumnos);
            this.Name = "ListadoAlumnos";
            this.Text = "ListadoAlumnos";
            this.Load += new System.EventHandler(this.ListadoAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeneroAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelfAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMailAlum;
        private System.Windows.Forms.Button btnCerrar;
    }
}