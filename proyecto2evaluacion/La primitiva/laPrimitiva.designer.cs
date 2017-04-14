namespace Numeros.Primitiva
{
    partial class jugarPrimitiva
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
            this.bRellenarPrimitiva = new System.Windows.Forms.Button();
            this.bProbarSuerte = new System.Windows.Forms.Button();
            this.tRellenarPrimitiva = new System.Windows.Forms.TextBox();
            this.ingresarNumerosQueJuegas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bRellenarPrimitiva
            // 
            this.bRellenarPrimitiva.Enabled = false;
            this.bRellenarPrimitiva.Location = new System.Drawing.Point(300, 97);
            this.bRellenarPrimitiva.Name = "bRellenarPrimitiva";
            this.bRellenarPrimitiva.Size = new System.Drawing.Size(115, 20);
            this.bRellenarPrimitiva.TabIndex = 0;
            this.bRellenarPrimitiva.Text = "rellenar primitiva";
            this.bRellenarPrimitiva.UseVisualStyleBackColor = true;
            this.bRellenarPrimitiva.Click += new System.EventHandler(this.bRellenaTuPrimitiva);
            // 
            // bProbarSuerte
            // 
            this.bProbarSuerte.Enabled = false;
            this.bProbarSuerte.Location = new System.Drawing.Point(47, 230);
            this.bProbarSuerte.Name = "bProbarSuerte";
            this.bProbarSuerte.Size = new System.Drawing.Size(83, 59);
            this.bProbarSuerte.TabIndex = 1;
            this.bProbarSuerte.Text = "Prueba suerte";
            this.bProbarSuerte.UseVisualStyleBackColor = true;
            this.bProbarSuerte.Click += new System.EventHandler(this.bMuestraPremio);
            // 
            // tRellenarPrimitiva
            // 
            this.tRellenarPrimitiva.Location = new System.Drawing.Point(239, 97);
            this.tRellenarPrimitiva.Name = "tRellenarPrimitiva";
            this.tRellenarPrimitiva.Size = new System.Drawing.Size(37, 20);
            this.tRellenarPrimitiva.TabIndex = 2;
            this.tRellenarPrimitiva.TextChanged += new System.EventHandler(this.tRellenarPrimitiva_TextChanged);
            // 
            // ingresarNumerosQueJuegas
            // 
            this.ingresarNumerosQueJuegas.AutoSize = true;
            this.ingresarNumerosQueJuegas.Location = new System.Drawing.Point(7, 100);
            this.ingresarNumerosQueJuegas.Name = "ingresarNumerosQueJuegas";
            this.ingresarNumerosQueJuegas.Size = new System.Drawing.Size(226, 13);
            this.ingresarNumerosQueJuegas.TabIndex = 3;
            this.ingresarNumerosQueJuegas.Text = "Ves ingresnado los números que quieres jugar:";
            // 
            // jugarPrimitiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 333);
            this.Controls.Add(this.ingresarNumerosQueJuegas);
            this.Controls.Add(this.tRellenarPrimitiva);
            this.Controls.Add(this.bProbarSuerte);
            this.Controls.Add(this.bRellenarPrimitiva);
            this.Name = "jugarPrimitiva";
            this.Text = "jugarPrimitiva";
            this.Load += new System.EventHandler(this.formularioPrimitivaLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRellenarPrimitiva;
        private System.Windows.Forms.Button bProbarSuerte;
        private System.Windows.Forms.TextBox tRellenarPrimitiva;
        private System.Windows.Forms.Label ingresarNumerosQueJuegas;
    }
}

