namespace Numeros
{
    partial class tNumeros
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
            this.lFibonacci = new System.Windows.Forms.Label();
            this.lTorresDeHanoiFormulario = new System.Windows.Forms.Label();
            this.lNumerosPrimosFormulario = new System.Windows.Forms.Label();
            this.lPrimitivaFormulario = new System.Windows.Forms.Label();
            this.bPrimitivaFormulario = new System.Windows.Forms.Button();
            this.bNumerosPrimosFormulario = new System.Windows.Forms.Button();
            this.bTorresDeHanoiFormulario = new System.Windows.Forms.Button();
            this.bFormularioFibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lFibonacci
            // 
            this.lFibonacci.AutoSize = true;
            this.lFibonacci.Location = new System.Drawing.Point(61, 27);
            this.lFibonacci.Name = "lFibonacci";
            this.lFibonacci.Size = new System.Drawing.Size(53, 13);
            this.lFibonacci.TabIndex = 4;
            this.lFibonacci.Text = "Fibonacci";
            // 
            // lTorresDeHanoiFormulario
            // 
            this.lTorresDeHanoiFormulario.AutoSize = true;
            this.lTorresDeHanoiFormulario.Location = new System.Drawing.Point(430, 27);
            this.lTorresDeHanoiFormulario.Name = "lTorresDeHanoiFormulario";
            this.lTorresDeHanoiFormulario.Size = new System.Drawing.Size(83, 13);
            this.lTorresDeHanoiFormulario.TabIndex = 5;
            this.lTorresDeHanoiFormulario.Text = "Torres de Hanoi";
            // 
            // lNumerosPrimosFormulario
            // 
            this.lNumerosPrimosFormulario.AutoSize = true;
            this.lNumerosPrimosFormulario.Location = new System.Drawing.Point(61, 285);
            this.lNumerosPrimosFormulario.Name = "lNumerosPrimosFormulario";
            this.lNumerosPrimosFormulario.Size = new System.Drawing.Size(82, 13);
            this.lNumerosPrimosFormulario.TabIndex = 6;
            this.lNumerosPrimosFormulario.Text = "Numeros primos";
            // 
            // lPrimitivaFormulario
            // 
            this.lPrimitivaFormulario.AutoSize = true;
            this.lPrimitivaFormulario.Location = new System.Drawing.Point(430, 285);
            this.lPrimitivaFormulario.Name = "lPrimitivaFormulario";
            this.lPrimitivaFormulario.Size = new System.Drawing.Size(46, 13);
            this.lPrimitivaFormulario.TabIndex = 7;
            this.lPrimitivaFormulario.Text = "Primitiva";
            // 
            // bPrimitivaFormulario
            // 
            //this.bPrimitivaFormulario.BackgroundImage = global::proyecto2evaluacion.Properties.Resources.primitiva;
            this.bPrimitivaFormulario.Location = new System.Drawing.Point(433, 199);
            this.bPrimitivaFormulario.Name = "bPrimitivaFormulario";
            this.bPrimitivaFormulario.Size = new System.Drawing.Size(87, 74);
            this.bPrimitivaFormulario.TabIndex = 3;
            this.bPrimitivaFormulario.UseVisualStyleBackColor = true;
            this.bPrimitivaFormulario.Click += new System.EventHandler(this.bPrimitiva);
            // 
            // bNumerosPrimosFormulario
            // 
            //this.bNumerosPrimosFormulario.Image = global::proyecto2evaluacion.Properties.Resources.primos;
            this.bNumerosPrimosFormulario.Location = new System.Drawing.Point(61, 199);
            this.bNumerosPrimosFormulario.Name = "bNumerosPrimosFormulario";
            this.bNumerosPrimosFormulario.Size = new System.Drawing.Size(87, 74);
            this.bNumerosPrimosFormulario.TabIndex = 2;
            this.bNumerosPrimosFormulario.UseVisualStyleBackColor = true;
            this.bNumerosPrimosFormulario.Click += new System.EventHandler(this.bPrimos);
            // 
            // bTorresDeHanoiFormulario
            // 
            //this.bTorresDeHanoiFormulario.Image = global::proyecto2evaluacion.Properties.Resources.hanoi;
            this.bTorresDeHanoiFormulario.Location = new System.Drawing.Point(433, 61);
            this.bTorresDeHanoiFormulario.Name = "bTorresDeHanoiFormulario";
            this.bTorresDeHanoiFormulario.Size = new System.Drawing.Size(87, 74);
            this.bTorresDeHanoiFormulario.TabIndex = 1;
            this.bTorresDeHanoiFormulario.UseVisualStyleBackColor = true;
            this.bTorresDeHanoiFormulario.Click += new System.EventHandler(this.bTorresHanoi);
            // 
            // bFormularioFibonacci
            // 
            //this.bFormularioFibonacci.Image = global::proyecto2evaluacion.Properties.Resources.fibonnaci1;
            this.bFormularioFibonacci.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bFormularioFibonacci.Location = new System.Drawing.Point(61, 61);
            this.bFormularioFibonacci.Name = "bFormularioFibonacci";
            this.bFormularioFibonacci.Size = new System.Drawing.Size(87, 74);
            this.bFormularioFibonacci.TabIndex = 0;
            this.bFormularioFibonacci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bFormularioFibonacci.UseVisualStyleBackColor = true;
            this.bFormularioFibonacci.Click += new System.EventHandler(this.bFibo);
            // 
            // tNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::proyecto2evaluacion.Properties.Resources.numeros;
            this.ClientSize = new System.Drawing.Size(601, 326);
            this.Controls.Add(this.lPrimitivaFormulario);
            this.Controls.Add(this.lNumerosPrimosFormulario);
            this.Controls.Add(this.lTorresDeHanoiFormulario);
            this.Controls.Add(this.lFibonacci);
            this.Controls.Add(this.bPrimitivaFormulario);
            this.Controls.Add(this.bNumerosPrimosFormulario);
            this.Controls.Add(this.bTorresDeHanoiFormulario);
            this.Controls.Add(this.bFormularioFibonacci);
            this.Name = "tNumeros";
            this.Text = "Números";
            this.Load += new System.EventHandler(this.forNumerosLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFormularioFibonacci;
        private System.Windows.Forms.Button bTorresDeHanoiFormulario;
        private System.Windows.Forms.Button bNumerosPrimosFormulario;
        private System.Windows.Forms.Button bPrimitivaFormulario;
        private System.Windows.Forms.Label lFibonacci;
        private System.Windows.Forms.Label lTorresDeHanoiFormulario;
        private System.Windows.Forms.Label lNumerosPrimosFormulario;
        private System.Windows.Forms.Label lPrimitivaFormulario;
    }
}

