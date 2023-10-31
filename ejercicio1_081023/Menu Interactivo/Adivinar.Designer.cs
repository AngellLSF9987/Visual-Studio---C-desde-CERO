namespace Menu_Interactivo
{
    partial class Adivinar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompara = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.textCOM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(272, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adivina el número!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.MaximumSize = new System.Drawing.Size(700, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(659, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "La computadora a elegido un número aleatorio entre 0 y 100. ¿Será capaz de adivin" +
    "ar cuál? Dispones de 7 intentos. Prueba suerte!";
            // 
            // textUser
            // 
            this.textUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUser.BackColor = System.Drawing.Color.Gold;
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textUser.ForeColor = System.Drawing.Color.Green;
            this.textUser.Location = new System.Drawing.Point(183, 241);
            this.textUser.MaximumSize = new System.Drawing.Size(80, 80);
            this.textUser.MinimumSize = new System.Drawing.Size(80, 80);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(80, 80);
            this.textUser.TabIndex = 2;
            this.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(56, 188);
            this.label3.MaximumSize = new System.Drawing.Size(700, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Introduce tu número y prueba suerte...";
            // 
            // btnCompara
            // 
            this.btnCompara.BackColor = System.Drawing.Color.Green;
            this.btnCompara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompara.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompara.ForeColor = System.Drawing.Color.Gold;
            this.btnCompara.Location = new System.Drawing.Point(354, 265);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(121, 38);
            this.btnCompara.TabIndex = 4;
            this.btnCompara.Text = "Adivinar!!";
            this.btnCompara.UseVisualStyleBackColor = false;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_close.Location = new System.Drawing.Point(371, 365);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(90, 29);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Salir";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // textCOM
            // 
            this.textCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCOM.BackColor = System.Drawing.Color.Gold;
            this.textCOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textCOM.ForeColor = System.Drawing.Color.Green;
            this.textCOM.Location = new System.Drawing.Point(564, 241);
            this.textCOM.MaximumSize = new System.Drawing.Size(80, 80);
            this.textCOM.MinimumSize = new System.Drawing.Size(80, 80);
            this.textCOM.Name = "textCOM";
            this.textCOM.Size = new System.Drawing.Size(80, 80);
            this.textCOM.TabIndex = 5;
            this.textCOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCOM.Visible = false;
            // 
            // Adivinar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.textCOM);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Olive;
            this.Name = "Adivinar";
            this.Text = "4.Adivinar";
            this.Load += new System.EventHandler(this.Adivinar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox textCOM;
    }
}