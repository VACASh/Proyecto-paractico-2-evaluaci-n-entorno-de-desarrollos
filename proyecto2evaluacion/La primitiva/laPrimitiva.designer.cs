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
            this.lIngresarNumeros = new System.Windows.Forms.Label();
            this.bReiniciarLaPrimitiva = new System.Windows.Forms.Button();
            this.lInformativo = new System.Windows.Forms.Label();
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
            // lIngresarNumeros
            // 
            this.lIngresarNumeros.AutoSize = true;
            this.lIngresarNumeros.BackColor = System.Drawing.Color.Transparent;
            this.lIngresarNumeros.Location = new System.Drawing.Point(12, 101);
            this.lIngresarNumeros.Name = "lIngresarNumeros";
            this.lIngresarNumeros.Size = new System.Drawing.Size(226, 13);
            this.lIngresarNumeros.TabIndex = 3;
            this.lIngresarNumeros.Text = "Ves ingresnado los números que quieres jugar:";
            this.lIngresarNumeros.Click += new System.EventHandler(this.ingresarNumerosQueJuegas_Click);
            // 
            // bReiniciarLaPrimitiva
            // 
            this.bReiniciarLaPrimitiva.Enabled = false;
            this.bReiniciarLaPrimitiva.Location = new System.Drawing.Point(249, 230);
            this.bReiniciarLaPrimitiva.Name = "bReiniciarLaPrimitiva";
            this.bReiniciarLaPrimitiva.Size = new System.Drawing.Size(83, 59);
            this.bReiniciarLaPrimitiva.TabIndex = 4;
            this.bReiniciarLaPrimitiva.Text = "Reiniciar la Primitiva";
            this.bReiniciarLaPrimitiva.UseVisualStyleBackColor = true;
            this.bReiniciarLaPrimitiva.Click += new System.EventHandler(this.bReiniciarLaPrimitiva_Click);
            // 
            // lInformativo
            // 
            this.lInformativo.AutoSize = true;
            this.lInformativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInformativo.Location = new System.Drawing.Point(12, 22);
            this.lInformativo.Name = "lInformativo";
            this.lInformativo.Size = new System.Drawing.Size(408, 16);
            this.lInformativo.TabIndex = 5;
            this.lInformativo.Text = "Se juega con números del 1 al 49 no validos otros valores";
            // 
            // jugarPrimitiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(427, 333);
            this.Controls.Add(this.lInformativo);
            this.Controls.Add(this.lIngresarNumeros);
            this.Controls.Add(this.bReiniciarLaPrimitiva);
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
        private System.Windows.Forms.Label lIngresarNumeros;
        private System.Windows.Forms.Button bReiniciarLaPrimitiva;
        private System.Windows.Forms.Label lInformativo;
    }
}

