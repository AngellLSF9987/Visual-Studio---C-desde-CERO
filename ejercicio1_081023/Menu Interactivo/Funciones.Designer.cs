namespace Menu_Interactivo
{
    partial class Funciones
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFibo = new System.Windows.Forms.Button();
            this.textFibo = new System.Windows.Forms.TextBox();
            this.textResFibo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(117, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(849, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcula la serie FIBONACCI de un número indicado.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(62, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "a. El factorial de ese número. (nº < 15)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(62, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "b. El Fibonacci de ese número.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(63, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teniendo en cuenta lo siguiente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(63, 208);
            this.label5.MaximumSize = new System.Drawing.Size(500, 50);
            this.label5.MinimumSize = new System.Drawing.Size(500, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Los números de Fibonacci f0, f1, f2, f3, ... quedan definidos por las ecuaciones." +
    "..";
            // 
            // btnFibo
            // 
            this.btnFibo.BackColor = System.Drawing.Color.Green;
            this.btnFibo.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnFibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnFibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnFibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFibo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFibo.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFibo.Location = new System.Drawing.Point(282, 375);
            this.btnFibo.Name = "btnFibo";
            this.btnFibo.Size = new System.Drawing.Size(179, 42);
            this.btnFibo.TabIndex = 5;
            this.btnFibo.Text = "FIBONACCI";
            this.btnFibo.UseVisualStyleBackColor = false;
            this.btnFibo.Click += new System.EventHandler(this.btnFibo_Click);
            // 
            // textFibo
            // 
            this.textFibo.BackColor = System.Drawing.Color.LightGray;
            this.textFibo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFibo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textFibo.Location = new System.Drawing.Point(328, 275);
            this.textFibo.MaximumSize = new System.Drawing.Size(90, 90);
            this.textFibo.MinimumSize = new System.Drawing.Size(90, 90);
            this.textFibo.Name = "textFibo";
            this.textFibo.Size = new System.Drawing.Size(90, 35);
            this.textFibo.TabIndex = 6;
            this.textFibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textResFibo
            // 
            this.textResFibo.BackColor = System.Drawing.Color.LightGray;
            this.textResFibo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResFibo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textResFibo.Location = new System.Drawing.Point(557, 255);
            this.textResFibo.MaximumSize = new System.Drawing.Size(300, 200);
            this.textResFibo.MinimumSize = new System.Drawing.Size(300, 200);
            this.textResFibo.Multiline = true;
            this.textResFibo.Name = "textResFibo";
            this.textResFibo.Size = new System.Drawing.Size(300, 200);
            this.textResFibo.TabIndex = 7;
            this.textResFibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(63, 260);
            this.label6.MaximumSize = new System.Drawing.Size(200, 50);
            this.label6.MinimumSize = new System.Drawing.Size(200, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Introduce el número que deseas factorizar";
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
            this.btn_close.Location = new System.Drawing.Point(66, 426);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(90, 29);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Salir";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(905, 523);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textResFibo);
            this.Controls.Add(this.textFibo);
            this.Controls.Add(this.btnFibo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Funciones";
            this.Text = "3.Funciones";
            this.Load += new System.EventHandler(this.Funciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFibo;
        private System.Windows.Forms.TextBox textFibo;
        private System.Windows.Forms.TextBox textResFibo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_close;
    }
}