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
            this.bRellenarFormulario = new System.Windows.Forms.Button();
            this.bProbarSuerte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bRellenarFormulario
            // 
            this.bRellenarFormulario.Location = new System.Drawing.Point(45, 224);
            this.bRellenarFormulario.Name = "bRellenarFormulario";
            this.bRellenarFormulario.Size = new System.Drawing.Size(83, 59);
            this.bRellenarFormulario.TabIndex = 0;
            this.bRellenarFormulario.Text = "rellenar primitiva";
            this.bRellenarFormulario.UseVisualStyleBackColor = true;
            this.bRellenarFormulario.Click += new System.EventHandler(this.bRellenaTuPrimitiva);
            // 
            // bProbarSuerte
            // 
            this.bProbarSuerte.Location = new System.Drawing.Point(230, 224);
            this.bProbarSuerte.Name = "bProbarSuerte";
            this.bProbarSuerte.Size = new System.Drawing.Size(83, 59);
            this.bProbarSuerte.TabIndex = 1;
            this.bProbarSuerte.Text = "Prueba suerte";
            this.bProbarSuerte.UseVisualStyleBackColor = true;
            this.bProbarSuerte.Click += new System.EventHandler(this.bMuestraPremio);
            // 
            // jugarPrimitiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 333);
            this.Controls.Add(this.bProbarSuerte);
            this.Controls.Add(this.bRellenarFormulario);
            this.Name = "jugarPrimitiva";
            this.Text = "jugarPrimitiva";
            this.Load += new System.EventHandler(this.formularioPrimitivaLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bRellenarFormulario;
        private System.Windows.Forms.Button bProbarSuerte;
    }
}

