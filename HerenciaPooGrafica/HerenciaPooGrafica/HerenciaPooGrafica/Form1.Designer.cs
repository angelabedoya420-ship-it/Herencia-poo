namespace HerenciaPooGrafica
{
    partial class Form1
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
            this.selectorFigura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Radio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Base = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.areaTotal = new System.Windows.Forms.Label();
            this.perimetro = new System.Windows.Forms.Label();
            this.botonDibujar = new System.Windows.Forms.Button();
            this.lblposicionY = new System.Windows.Forms.Label();
            this.posicionY = new System.Windows.Forms.TextBox();
            this.lblposicionX = new System.Windows.Forms.Label();
            this.posicionX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectorFigura
            // 
            this.selectorFigura.FormattingEnabled = true;
            this.selectorFigura.Items.AddRange(new object[] {
            "Circulo",
            "Triangulo Rectangulo",
            "Rectangulo"});
            this.selectorFigura.Location = new System.Drawing.Point(135, 46);
            this.selectorFigura.Name = "selectorFigura";
            this.selectorFigura.Size = new System.Drawing.Size(121, 21);
            this.selectorFigura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione una figura:";
            // 
            // Radio
            // 
            this.Radio.Location = new System.Drawing.Point(281, 46);
            this.Radio.Name = "Radio";
            this.Radio.Size = new System.Drawing.Size(100, 20);
            this.Radio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Radio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base";
            // 
            // Base
            // 
            this.Base.Location = new System.Drawing.Point(281, 92);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(100, 20);
            this.Base.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Altura";
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(281, 141);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(100, 20);
            this.Altura.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(683, 52);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Area Total:";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Perimetro Total:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // areaTotal
            // 
            this.areaTotal.AutoSize = true;
            this.areaTotal.Location = new System.Drawing.Point(772, 52);
            this.areaTotal.Name = "areaTotal";
            this.areaTotal.Size = new System.Drawing.Size(13, 13);
            this.areaTotal.TabIndex = 10;
            this.areaTotal.Text = "0";
            this.areaTotal.Click += new System.EventHandler(this.areaTotal_Click);
            // 
            // perimetro
            // 
            this.perimetro.AutoSize = true;
            this.perimetro.Location = new System.Drawing.Point(772, 76);
            this.perimetro.Name = "perimetro";
            this.perimetro.Size = new System.Drawing.Size(13, 13);
            this.perimetro.TabIndex = 11;
            this.perimetro.Text = "0";
            this.perimetro.Click += new System.EventHandler(this.perimetro_Click);
            // 
            // botonDibujar
            // 
            this.botonDibujar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.botonDibujar.Location = new System.Drawing.Point(466, 37);
            this.botonDibujar.Name = "botonDibujar";
            this.botonDibujar.Size = new System.Drawing.Size(123, 37);
            this.botonDibujar.TabIndex = 12;
            this.botonDibujar.Text = "dibujar";
            this.botonDibujar.UseVisualStyleBackColor = false;
            this.botonDibujar.Click += new System.EventHandler(this.boton_dibujar_click);
            // 
            // lblposicionY
            // 
            this.lblposicionY.AutoSize = true;
            this.lblposicionY.Location = new System.Drawing.Point(9, 73);
            this.lblposicionY.Name = "lblposicionY";
            this.lblposicionY.Size = new System.Drawing.Size(57, 13);
            this.lblposicionY.TabIndex = 16;
            this.lblposicionY.Text = "Posicion Y";
            // 
            // posicionY
            // 
            this.posicionY.Location = new System.Drawing.Point(12, 89);
            this.posicionY.Name = "posicionY";
            this.posicionY.Size = new System.Drawing.Size(106, 20);
            this.posicionY.TabIndex = 15;
            // 
            // lblposicionX
            // 
            this.lblposicionX.AutoSize = true;
            this.lblposicionX.Location = new System.Drawing.Point(9, 27);
            this.lblposicionX.Name = "lblposicionX";
            this.lblposicionX.Size = new System.Drawing.Size(57, 13);
            this.lblposicionX.TabIndex = 14;
            this.lblposicionX.Text = "posicion x:";
            // 
            // posicionX
            // 
            this.posicionX.Location = new System.Drawing.Point(12, 43);
            this.posicionX.Name = "posicionX";
            this.posicionX.Size = new System.Drawing.Size(106, 20);
            this.posicionX.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 487);
            this.Controls.Add(this.lblposicionY);
            this.Controls.Add(this.posicionY);
            this.Controls.Add(this.lblposicionX);
            this.Controls.Add(this.posicionX);
            this.Controls.Add(this.botonDibujar);
            this.Controls.Add(this.perimetro);
            this.Controls.Add(this.areaTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Radio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectorFigura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectorFigura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Base;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label areaTotal;
        private System.Windows.Forms.Label perimetro;
        private System.Windows.Forms.Button botonDibujar;
        private System.Windows.Forms.Label lblposicionY;
        private System.Windows.Forms.TextBox posicionY;
        private System.Windows.Forms.Label lblposicionX;
        private System.Windows.Forms.TextBox posicionX;
    }
}

