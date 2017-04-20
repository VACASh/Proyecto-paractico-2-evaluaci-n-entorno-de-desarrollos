namespace Numeros.Hanoi
{
    partial class torresHanoi
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
            this.bJugarTorres = new System.Windows.Forms.Button();
            this.introducirNumeros = new System.Windows.Forms.TextBox();
            this.labelMovimentos = new System.Windows.Forms.Label();
            this.lNumeroDiscos = new System.Windows.Forms.Label();
            this.cajaMovimientos = new System.Windows.Forms.TextBox();
            this.lMinimoMaximo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bJugarTorres
            // 
            this.bJugarTorres.Enabled = false;
            this.bJugarTorres.Location = new System.Drawing.Point(12, 18);
            this.bJugarTorres.Name = "bJugarTorres";
            this.bJugarTorres.Size = new System.Drawing.Size(75, 23);
            this.bJugarTorres.TabIndex = 0;
            this.bJugarTorres.Text = "Jugar";
            this.bJugarTorres.UseVisualStyleBackColor = true;
            this.bJugarTorres.Click += new System.EventHandler(this.bHanoi);
            // 
            // introducirNumeros
            // 
            this.introducirNumeros.Location = new System.Drawing.Point(135, 20);
            this.introducirNumeros.Name = "introducirNumeros";
            this.introducirNumeros.Size = new System.Drawing.Size(49, 20);
            this.introducirNumeros.TabIndex = 1;
            this.introducirNumeros.TextChanged += new System.EventHandler(this.introducirNumeros_TextChanged);
            // 
            // labelMovimentos
            // 
            this.labelMovimentos.AutoSize = true;
            this.labelMovimentos.Location = new System.Drawing.Point(33, 62);
            this.labelMovimentos.Name = "labelMovimentos";
            this.labelMovimentos.Size = new System.Drawing.Size(0, 13);
            this.labelMovimentos.TabIndex = 2;
            // 
            // lNumeroDiscos
            // 
            this.lNumeroDiscos.AutoSize = true;
            this.lNumeroDiscos.Location = new System.Drawing.Point(205, 18);
            this.lNumeroDiscos.Name = "lNumeroDiscos";
            this.lNumeroDiscos.Size = new System.Drawing.Size(189, 13);
            this.lNumeroDiscos.TabIndex = 3;
            this.lNumeroDiscos.Text = "Numeros de discos con los que juegas";
            this.lNumeroDiscos.Click += new System.EventHandler(this.lNumeroDiscos_Click);
            // 
            // cajaMovimientos
            // 
            this.cajaMovimientos.Location = new System.Drawing.Point(26, 54);
            this.cajaMovimientos.Multiline = true;
            this.cajaMovimientos.Name = "cajaMovimientos";
            this.cajaMovimientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cajaMovimientos.Size = new System.Drawing.Size(400, 336);
            this.cajaMovimientos.TabIndex = 4;
            this.cajaMovimientos.TextChanged += new System.EventHandler(this.tTorresDeHanoiMovimientos_TextChanged);
            // 
            // lMinimoMaximo
            // 
            this.lMinimoMaximo.AutoSize = true;
            this.lMinimoMaximo.Location = new System.Drawing.Point(208, 35);
            this.lMinimoMaximo.Name = "lMinimoMaximo";
            this.lMinimoMaximo.Size = new System.Drawing.Size(178, 13);
            this.lMinimoMaximo.TabIndex = 5;
            this.lMinimoMaximo.Text = "stringHanoi\tMinimo1 ,Máximo 9\tes-ES";
            this.lMinimoMaximo.Click += new System.EventHandler(this.lMinimoMaximo_Click);
            // 
            // torresHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 413);
            this.Controls.Add(this.lMinimoMaximo);
            this.Controls.Add(this.cajaMovimientos);
            this.Controls.Add(this.lNumeroDiscos);
            this.Controls.Add(this.labelMovimentos);
            this.Controls.Add(this.introducirNumeros);
            this.Controls.Add(this.bJugarTorres);
            this.Name = "torresHanoi";
            this.Text = "Torres de Hanoi";
            this.Load += new System.EventHandler(this.formularioTorresDeHanoiLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bJugarTorres;
        private System.Windows.Forms.TextBox introducirNumeros;
        private System.Windows.Forms.Label labelMovimentos;
        private System.Windows.Forms.Label lNumeroDiscos;
        private System.Windows.Forms.TextBox cajaMovimientos;
        private System.Windows.Forms.Label lMinimoMaximo;
    }
}

