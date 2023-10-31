using System;
using System.Windows.Forms;

namespace Menu_Interactivo
{
    public partial class areas : Form
    {
        public areas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.GroupBox();
            this.textPeriC = new System.Windows.Forms.TextBox();
            this.lblPeriC = new System.Windows.Forms.Label();
            this.textAreaCuadrado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCuadrado = new System.Windows.Forms.TextBox();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.lado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rectangulo = new System.Windows.Forms.GroupBox();
            this.textPeriR = new System.Windows.Forms.TextBox();
            this.textAlturaRec = new System.Windows.Forms.TextBox();
            this.lblPeriR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAreaRec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBaseRec = new System.Windows.Forms.TextBox();
            this.btn_Rec = new System.Windows.Forms.Button();
            this.triangulo = new System.Windows.Forms.GroupBox();
            this.textPeriT = new System.Windows.Forms.TextBox();
            this.textAlturaTri = new System.Windows.Forms.TextBox();
            this.lblPeriT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textAreaTri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBaseTri = new System.Windows.Forms.TextBox();
            this.btn_Tri = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.area.SuspendLayout();
            this.rectangulo.SuspendLayout();
            this.triangulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.LemonChiffon;
            this.title.Location = new System.Drawing.Point(102, 37);
            this.title.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(919, 76);
            this.title.TabIndex = 0;
            this.title.Text = "Calcula Rápidamente con esta Calculadora el Área de Figuras Geométricas.";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // area
            // 
            this.area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.area.Controls.Add(this.textPeriC);
            this.area.Controls.Add(this.lblPeriC);
            this.area.Controls.Add(this.textAreaCuadrado);
            this.area.Controls.Add(this.label4);
            this.area.Controls.Add(this.textCuadrado);
            this.area.Controls.Add(this.btnCuadrado);
            this.area.Controls.Add(this.lado);
            this.area.Controls.Add(this.label1);
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.Location = new System.Drawing.Point(12, 122);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(365, 556);
            this.area.TabIndex = 1;
            this.area.TabStop = false;
            this.area.Text = "Area Cuadrado";
            // 
            // textPeriC
            // 
            this.textPeriC.Location = new System.Drawing.Point(66, 470);
            this.textPeriC.Name = "textPeriC";
            this.textPeriC.Size = new System.Drawing.Size(222, 30);
            this.textPeriC.TabIndex = 7;
            // 
            // lblPeriC
            // 
            this.lblPeriC.AutoSize = true;
            this.lblPeriC.Location = new System.Drawing.Point(39, 428);
            this.lblPeriC.Name = "lblPeriC";
            this.lblPeriC.Size = new System.Drawing.Size(152, 25);
            this.lblPeriC.TabIndex = 6;
            this.lblPeriC.Text = "Valor Perímetro:";
            // 
            // textAreaCuadrado
            // 
            this.textAreaCuadrado.Location = new System.Drawing.Point(64, 371);
            this.textAreaCuadrado.Name = "textAreaCuadrado";
            this.textAreaCuadrado.Size = new System.Drawing.Size(222, 30);
            this.textAreaCuadrado.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor Área:";
            // 
            // textCuadrado
            // 
            this.textCuadrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCuadrado.Location = new System.Drawing.Point(64, 175);
            this.textCuadrado.Name = "textCuadrado";
            this.textCuadrado.Size = new System.Drawing.Size(222, 30);
            this.textCuadrado.TabIndex = 3;
            this.textCuadrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.Color.Green;
            this.btnCuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuadrado.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCuadrado.FlatAppearance.BorderSize = 0;
            this.btnCuadrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCuadrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuadrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCuadrado.Location = new System.Drawing.Point(96, 230);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(161, 50);
            this.btnCuadrado.TabIndex = 2;
            this.btnCuadrado.Text = "Calcular";
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lado
            // 
            this.lado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lado.AutoSize = true;
            this.lado.Location = new System.Drawing.Point(39, 116);
            this.lado.Name = "lado";
            this.lado.Size = new System.Drawing.Size(113, 25);
            this.lado.TabIndex = 1;
            this.lado.Text = "Valor Lado:";
            this.lado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.MaximumSize = new System.Drawing.Size(350, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "El cálculo del Área de un Cuadrado se realiza multiplicando lado por lado o lo qu" +
    "e es lo mismo elevando potencialmente un mismo por dos.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rectangulo
            // 
            this.rectangulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangulo.Controls.Add(this.textPeriR);
            this.rectangulo.Controls.Add(this.textAlturaRec);
            this.rectangulo.Controls.Add(this.lblPeriR);
            this.rectangulo.Controls.Add(this.label5);
            this.rectangulo.Controls.Add(this.textAreaRec);
            this.rectangulo.Controls.Add(this.label2);
            this.rectangulo.Controls.Add(this.label8);
            this.rectangulo.Controls.Add(this.label7);
            this.rectangulo.Controls.Add(this.textBaseRec);
            this.rectangulo.Controls.Add(this.btn_Rec);
            this.rectangulo.Location = new System.Drawing.Point(383, 122);
            this.rectangulo.Name = "rectangulo";
            this.rectangulo.Size = new System.Drawing.Size(365, 556);
            this.rectangulo.TabIndex = 2;
            this.rectangulo.TabStop = false;
            this.rectangulo.Text = "Area Rectangulo";
            this.rectangulo.Enter += new System.EventHandler(this.rectangulo_Enter);
            // 
            // textPeriR
            // 
            this.textPeriR.Location = new System.Drawing.Point(67, 470);
            this.textPeriR.Name = "textPeriR";
            this.textPeriR.Size = new System.Drawing.Size(222, 30);
            this.textPeriR.TabIndex = 9;
            // 
            // textAlturaRec
            // 
            this.textAlturaRec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAlturaRec.Location = new System.Drawing.Point(67, 217);
            this.textAlturaRec.Name = "textAlturaRec";
            this.textAlturaRec.Size = new System.Drawing.Size(222, 30);
            this.textAlturaRec.TabIndex = 12;
            this.textAlturaRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPeriR
            // 
            this.lblPeriR.AutoSize = true;
            this.lblPeriR.Location = new System.Drawing.Point(42, 428);
            this.lblPeriR.Name = "lblPeriR";
            this.lblPeriR.Size = new System.Drawing.Size(152, 25);
            this.lblPeriR.TabIndex = 8;
            this.lblPeriR.Text = "Valor Perímetro:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Altura:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAreaRec
            // 
            this.textAreaRec.Location = new System.Drawing.Point(67, 371);
            this.textAreaRec.Name = "textAreaRec";
            this.textAreaRec.Size = new System.Drawing.Size(222, 30);
            this.textAreaRec.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.MaximumSize = new System.Drawing.Size(350, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "El cálculo del Área de un Rectángulo se consigue multiplicando el lado \"Base\" por" +
    " el lado \"Altura\".";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Valor Área:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor Base:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBaseRec
            // 
            this.textBaseRec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBaseRec.Location = new System.Drawing.Point(64, 142);
            this.textBaseRec.Name = "textBaseRec";
            this.textBaseRec.Size = new System.Drawing.Size(222, 30);
            this.textBaseRec.TabIndex = 8;
            this.textBaseRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Rec
            // 
            this.btn_Rec.BackColor = System.Drawing.Color.Green;
            this.btn_Rec.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Rec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_Rec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_Rec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rec.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Rec.Location = new System.Drawing.Point(98, 263);
            this.btn_Rec.Name = "btn_Rec";
            this.btn_Rec.Size = new System.Drawing.Size(161, 50);
            this.btn_Rec.TabIndex = 7;
            this.btn_Rec.Text = "Calcular";
            this.btn_Rec.UseVisualStyleBackColor = false;
            this.btn_Rec.Click += new System.EventHandler(this.btn_Rec_Click);
            // 
            // triangulo
            // 
            this.triangulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triangulo.Controls.Add(this.textPeriT);
            this.triangulo.Controls.Add(this.textAlturaTri);
            this.triangulo.Controls.Add(this.lblPeriT);
            this.triangulo.Controls.Add(this.label6);
            this.triangulo.Controls.Add(this.textAreaTri);
            this.triangulo.Controls.Add(this.label3);
            this.triangulo.Controls.Add(this.label10);
            this.triangulo.Controls.Add(this.label9);
            this.triangulo.Controls.Add(this.textBaseTri);
            this.triangulo.Controls.Add(this.btn_Tri);
            this.triangulo.Location = new System.Drawing.Point(760, 123);
            this.triangulo.Name = "triangulo";
            this.triangulo.Size = new System.Drawing.Size(365, 556);
            this.triangulo.TabIndex = 3;
            this.triangulo.TabStop = false;
            this.triangulo.Text = "Area Triangulo";
            // 
            // textPeriT
            // 
            this.textPeriT.Location = new System.Drawing.Point(75, 469);
            this.textPeriT.Name = "textPeriT";
            this.textPeriT.Size = new System.Drawing.Size(222, 30);
            this.textPeriT.TabIndex = 14;
            // 
            // textAlturaTri
            // 
            this.textAlturaTri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAlturaTri.Location = new System.Drawing.Point(77, 216);
            this.textAlturaTri.Name = "textAlturaTri";
            this.textAlturaTri.Size = new System.Drawing.Size(222, 30);
            this.textAlturaTri.TabIndex = 12;
            this.textAlturaTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPeriT
            // 
            this.lblPeriT.AutoSize = true;
            this.lblPeriT.Location = new System.Drawing.Point(50, 427);
            this.lblPeriT.Name = "lblPeriT";
            this.lblPeriT.Size = new System.Drawing.Size(152, 25);
            this.lblPeriT.TabIndex = 13;
            this.lblPeriT.Text = "Valor Perímetro:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor Altura:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAreaTri
            // 
            this.textAreaTri.Location = new System.Drawing.Point(77, 370);
            this.textAreaTri.Name = "textAreaTri";
            this.textAreaTri.Size = new System.Drawing.Size(222, 30);
            this.textAreaTri.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.MaximumSize = new System.Drawing.Size(355, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 80);
            this.label3.TabIndex = 2;
            this.label3.Text = "El cálculo del Área de un Triángulo Recántagulo  se consigue multiplicando el lad" +
    "o \"Base\" por el lado \"Altura\", divido por 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Valor Área:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Valor Base:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBaseTri
            // 
            this.textBaseTri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBaseTri.Location = new System.Drawing.Point(77, 141);
            this.textBaseTri.Name = "textBaseTri";
            this.textBaseTri.Size = new System.Drawing.Size(222, 30);
            this.textBaseTri.TabIndex = 8;
            this.textBaseTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Tri
            // 
            this.btn_Tri.BackColor = System.Drawing.Color.Green;
            this.btn_Tri.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Tri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_Tri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_Tri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tri.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Tri.Location = new System.Drawing.Point(112, 262);
            this.btn_Tri.Name = "btn_Tri";
            this.btn_Tri.Size = new System.Drawing.Size(161, 50);
            this.btn_Tri.TabIndex = 7;
            this.btn_Tri.Text = "Calcular";
            this.btn_Tri.UseVisualStyleBackColor = false;
            this.btn_Tri.Click += new System.EventHandler(this.btn_Tri_Click);
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
            this.btn_close.Location = new System.Drawing.Point(512, 684);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(106, 31);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Salir";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // areas
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1137, 722);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.triangulo);
            this.Controls.Add(this.rectangulo);
            this.Controls.Add(this.area);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "areas";
            this.Text = "Calculadora Áreas Figuras Geométricas";
            this.Load += new System.EventHandler(this.areas_Load);
            this.area.ResumeLayout(false);
            this.area.PerformLayout();
            this.rectangulo.ResumeLayout(false);
            this.rectangulo.PerformLayout();
            this.triangulo.ResumeLayout(false);
            this.triangulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label title;
        private GroupBox area;
        private GroupBox rectangulo;
        private GroupBox triangulo;

        private void rectangulo_Enter(object sender, EventArgs e)
        {

        }

        private Label label1;
        private Label label2;
        private TextBox textCuadrado;
        private Button btnCuadrado;
        private Label lado;
        private Label label3;
        private Label label4;
        private TextBox textAreaCuadrado;
        private TextBox textAreaRec;
        private Label label8;
        private Label label7;
        private TextBox textBaseRec;
        private Button btn_Rec;
        private TextBox textAreaTri;
        private Label label10;
        private Label label9;
        private TextBox textBaseTri;
        private Button btn_Tri;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private TextBox textAlturaRec;
        private Label label5;
        private TextBox textAlturaTri;
        private Label label6;

        private void Button1_Click(object sender, EventArgs e)
        {
            double lado = double.Parse(textCuadrado.Text);
            textAreaCuadrado.Text = (lado * lado).ToString();
            textPeriC.Text = (lado * 4).ToString();
        }

        private void btn_Rec_Click(object sender, EventArgs e)
        {
            double baseRec = double.Parse(textBaseRec.Text);
            double altRec = double.Parse(textAlturaRec.Text);

            textAreaRec.Text = (baseRec * altRec).ToString();
            textPeriR.Text = (Math.Pow(baseRec,2) + Math.Pow(altRec,2)).ToString();
        }

        private void btn_Tri_Click(object sender, EventArgs e)
        {
            double baseTri = double.Parse(textBaseTri.Text);
            double altTri = double.Parse(textAlturaTri.Text);

            textAreaTri.Text = ((baseTri * altTri) / 2).ToString();

            // Suponiendo que es un triángulo equilaterio
            textPeriT.Text = (baseTri * 3).ToString();

        }

        private Button btn_close;
        private TextBox textPeriC;
        private Label lblPeriC;
        private TextBox textPeriR;
        private Label lblPeriR;
        private TextBox textPeriT;
        private Label lblPeriT;

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close(); ;
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void areas_Load(object sender, EventArgs e)
        {
                
        }
    }
    }

