namespace Articulos_Clases_
{
    partial class AltasArticulos
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
            this.panelAltasArticulos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAltasArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAltasArticulos
            // 
            this.panelAltasArticulos.BackColor = System.Drawing.Color.LightGray;
            this.panelAltasArticulos.Controls.Add(this.button1);
            this.panelAltasArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAltasArticulos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAltasArticulos.Location = new System.Drawing.Point(0, 0);
            this.panelAltasArticulos.MaximumSize = new System.Drawing.Size(1001, 513);
            this.panelAltasArticulos.Name = "panelAltasArticulos";
            this.panelAltasArticulos.Size = new System.Drawing.Size(1000, 511);
            this.panelAltasArticulos.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(441, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "altas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AltasArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 511);
            this.Controls.Add(this.panelAltasArticulos);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltasArticulos";
            this.Text = "AltasArticulos";
            this.panelAltasArticulos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAltasArticulos;
        private System.Windows.Forms.Button button1;
    }
}