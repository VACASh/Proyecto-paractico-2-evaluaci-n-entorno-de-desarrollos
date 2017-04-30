namespace Numeros.Fibonacci
{
    partial class numFibonacci
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
            this.bMostrar = new System.Windows.Forms.Button();
            this.tFibo = new System.Windows.Forms.TextBox();
            this.lFibonacci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bMostrar
            // 
            this.bMostrar.Location = new System.Drawing.Point(165, 167);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(75, 70);
            this.bMostrar.TabIndex = 0;
            this.bMostrar.Text = "mostrar";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Click += new System.EventHandler(this.bFibo);
            // 
            // tFibo
            // 
            this.tFibo.Location = new System.Drawing.Point(165, 39);
            this.tFibo.Name = "tFibo";
            this.tFibo.Size = new System.Drawing.Size(75, 20);
            this.tFibo.TabIndex = 1;
            this.tFibo.TextChanged += new System.EventHandler(this.tFibo_TextChanged);
            // 
            // lFibonacci
            // 
            this.lFibonacci.AutoSize = true;
            this.lFibonacci.Location = new System.Drawing.Point(32, 39);
            this.lFibonacci.Name = "lFibonacci";
            this.lFibonacci.Size = new System.Drawing.Size(53, 13);
            this.lFibonacci.TabIndex = 2;
            this.lFibonacci.Text = "Fibonacci";
            // 
            // numFibonacci
            // 
            this.ClientSize = new System.Drawing.Size(465, 336);
            this.Controls.Add(this.lFibonacci);
            this.Controls.Add(this.tFibo);
            this.Controls.Add(this.bMostrar);
            this.Name = "numFibonacci";
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Formfibonacci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        
        private System.Windows.Forms.Button bMostrar;
        private System.Windows.Forms.TextBox tFibo;
        private System.Windows.Forms.Label lFibonacci;
    }
}

