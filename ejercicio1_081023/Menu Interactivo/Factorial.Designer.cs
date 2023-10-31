namespace Menu_Interactivo
{
    partial class Factorial
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_Fact = new System.Windows.Forms.Button();
            this.textFact = new System.Windows.Forms.TextBox();
            this.textResFact = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(403, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTORIAL.";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(33, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.MaximumSize = new System.Drawing.Size(933, 49);
            this.textBox1.MinimumSize = new System.Drawing.Size(933, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(933, 49);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Para todo entero positivo n, el factorial de n se define como el producto de todo" +
    "s los números enteros positivos desde 1 (es decir, los números naturales) hasta " +
    "n.";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(33, 160);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.MaximumSize = new System.Drawing.Size(933, 40);
            this.textBox2.MinimumSize = new System.Drawing.Size(933, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(933, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "La multiplicación anterior se puede simbolizar también como:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.Location = new System.Drawing.Point(33, 202);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.MaximumSize = new System.Drawing.Size(933, 40);
            this.textBox3.MinimumSize = new System.Drawing.Size(933, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(933, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "n! = 1 x 2 x 3 x 4 x … x (n-1) x n";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.Location = new System.Drawing.Point(49, 245);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.MaximumSize = new System.Drawing.Size(307, 20);
            this.textBox4.MinimumSize = new System.Drawing.Size(307, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(307, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "n        |  0  |  1  |  2  |  3  |  4  |  5  ";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.Location = new System.Drawing.Point(49, 286);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.MaximumSize = new System.Drawing.Size(320, 20);
            this.textBox5.MinimumSize = new System.Drawing.Size(320, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(320, 23);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "n!        |  1  |  1  |  2  |  6  |  24  |  120  ";
            // 
            // btn_Fact
            // 
            this.btn_Fact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fact.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Fact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fact.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fact.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Fact.Location = new System.Drawing.Point(715, 286);
            this.btn_Fact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Fact.Name = "btn_Fact";
            this.btn_Fact.Size = new System.Drawing.Size(195, 48);
            this.btn_Fact.TabIndex = 6;
            this.btn_Fact.Text = "Factorial";
            this.btn_Fact.UseVisualStyleBackColor = false;
            this.btn_Fact.Click += new System.EventHandler(this.btn_Fact_Click_1);
            // 
            // textFact
            // 
            this.textFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFact.BackColor = System.Drawing.Color.SeaShell;
            this.textFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFact.ForeColor = System.Drawing.Color.Maroon;
            this.textFact.Location = new System.Drawing.Point(469, 247);
            this.textFact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFact.MaximumSize = new System.Drawing.Size(133, 80);
            this.textFact.MinimumSize = new System.Drawing.Size(133, 80);
            this.textFact.Name = "textFact";
            this.textFact.Size = new System.Drawing.Size(133, 22);
            this.textFact.TabIndex = 7;
            this.textFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textResFact
            // 
            this.textResFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResFact.BackColor = System.Drawing.Color.SeaShell;
            this.textResFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textResFact.ForeColor = System.Drawing.Color.Maroon;
            this.textResFact.Location = new System.Drawing.Point(69, 377);
            this.textResFact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textResFact.MaximumSize = new System.Drawing.Size(933, 80);
            this.textResFact.MinimumSize = new System.Drawing.Size(933, 80);
            this.textResFact.Name = "textResFact";
            this.textResFact.Size = new System.Drawing.Size(933, 22);
            this.textResFact.TabIndex = 8;
            this.textResFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Beige;
            this.btn_close.Location = new System.Drawing.Point(469, 501);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(133, 38);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Salir";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.textResFact);
            this.Controls.Add(this.textFact);
            this.Controls.Add(this.btn_Fact);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Factorial";
            this.Text = "Factorial";
            this.Load += new System.EventHandler(this.Factorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_Fact;
        private System.Windows.Forms.TextBox textFact;
        private System.Windows.Forms.TextBox textResFact;
        private System.Windows.Forms.Button btn_close;
    }
}