namespace Numeros.Primos
{
    partial class revisarPrimosMatriz
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
            this.bIngresarNumeros = new System.Windows.Forms.Button();
            this.tMatriz00 = new System.Windows.Forms.TextBox();
            this.tMatriz10 = new System.Windows.Forms.TextBox();
            this.tMatriz01 = new System.Windows.Forms.TextBox();
            this.tMatriz11 = new System.Windows.Forms.TextBox();
            this.lMatrizIngresarNúmeros = new System.Windows.Forms.Label();
            this.lAvisoMatriz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bIngresarNumeros
            // 
            this.bIngresarNumeros.Enabled = false;
            this.bIngresarNumeros.Location = new System.Drawing.Point(149, 232);
            this.bIngresarNumeros.Name = "bIngresarNumeros";
            this.bIngresarNumeros.Size = new System.Drawing.Size(72, 39);
            this.bIngresarNumeros.TabIndex = 0;
            this.bIngresarNumeros.Text = "Ingresar";
            this.bIngresarNumeros.UseVisualStyleBackColor = true;
            this.bIngresarNumeros.Click += new System.EventHandler(this.bPrimos);
            // 
            // tMatriz00
            // 
            this.tMatriz00.Location = new System.Drawing.Point(149, 164);
            this.tMatriz00.Name = "tMatriz00";
            this.tMatriz00.Size = new System.Drawing.Size(33, 20);
            this.tMatriz00.TabIndex = 1;
            this.tMatriz00.TextChanged += new System.EventHandler(this.tMatriz00_TextChanged);
            // 
            // tMatriz10
            // 
            this.tMatriz10.Location = new System.Drawing.Point(149, 190);
            this.tMatriz10.Name = "tMatriz10";
            this.tMatriz10.Size = new System.Drawing.Size(33, 20);
            this.tMatriz10.TabIndex = 2;
            this.tMatriz10.TextChanged += new System.EventHandler(this.tMatriz00_TextChanged);
            // 
            // tMatriz01
            // 
            this.tMatriz01.Location = new System.Drawing.Point(188, 164);
            this.tMatriz01.Name = "tMatriz01";
            this.tMatriz01.Size = new System.Drawing.Size(33, 20);
            this.tMatriz01.TabIndex = 3;
            this.tMatriz01.TextChanged += new System.EventHandler(this.tMatriz00_TextChanged);
            // 
            // tMatriz11
            // 
            this.tMatriz11.Location = new System.Drawing.Point(188, 190);
            this.tMatriz11.Name = "tMatriz11";
            this.tMatriz11.Size = new System.Drawing.Size(33, 20);
            this.tMatriz11.TabIndex = 4;
            this.tMatriz11.TextChanged += new System.EventHandler(this.tMatriz00_TextChanged);
            // 
            // lMatrizIngresarNúmeros
            // 
            this.lMatrizIngresarNúmeros.AutoSize = true;
            this.lMatrizIngresarNúmeros.Location = new System.Drawing.Point(122, 128);
            this.lMatrizIngresarNúmeros.Name = "lMatrizIngresarNúmeros";
            this.lMatrizIngresarNúmeros.Size = new System.Drawing.Size(150, 13);
            this.lMatrizIngresarNúmeros.TabIndex = 5;
            this.lMatrizIngresarNúmeros.Text = "Matriz de 2x2 ingresa números";
            // 
            // lAvisoMatriz
            // 
            this.lAvisoMatriz.AutoSize = true;
            this.lAvisoMatriz.Location = new System.Drawing.Point(243, 181);
            this.lAvisoMatriz.Name = "lAvisoMatriz";
            this.lAvisoMatriz.Size = new System.Drawing.Size(121, 13);
            this.lAvisoMatriz.TabIndex = 6;
            this.lAvisoMatriz.Text = "Solo del 1 hacia delante";
            // 
            // revisarPrimosMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 341);
            this.Controls.Add(this.lAvisoMatriz);
            this.Controls.Add(this.lMatrizIngresarNúmeros);
            this.Controls.Add(this.tMatriz11);
            this.Controls.Add(this.tMatriz01);
            this.Controls.Add(this.tMatriz10);
            this.Controls.Add(this.tMatriz00);
            this.Controls.Add(this.bIngresarNumeros);
            this.Name = "revisarPrimosMatriz";
            this.Text = "numerosPrimos";
            this.Load += new System.EventHandler(this.formularioPrimosLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bIngresarNumeros;
        private System.Windows.Forms.TextBox tMatriz00;
        private System.Windows.Forms.TextBox tMatriz10;
        private System.Windows.Forms.TextBox tMatriz01;
        private System.Windows.Forms.TextBox tMatriz11;
        private System.Windows.Forms.Label lMatrizIngresarNúmeros;
        private System.Windows.Forms.Label lAvisoMatriz;
    }
}

