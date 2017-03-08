namespace Numeros.Hanoi
{
    partial class toresHanoi
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
            this.button1 = new System.Windows.Forms.Button();
            this.introducirNumeros = new System.Windows.Forms.TextBox();
            this.labelMovimentos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cajaMovimientos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bHanoi);
            // 
            // introducirNumeros
            // 
            this.introducirNumeros.Location = new System.Drawing.Point(135, 20);
            this.introducirNumeros.Name = "introducirNumeros";
            this.introducirNumeros.Size = new System.Drawing.Size(49, 20);
            this.introducirNumeros.TabIndex = 1;
            // 
            // labelMovimentos
            // 
            this.labelMovimentos.AutoSize = true;
            this.labelMovimentos.Location = new System.Drawing.Point(33, 62);
            this.labelMovimentos.Name = "labelMovimentos";
            this.labelMovimentos.Size = new System.Drawing.Size(0, 13);
            this.labelMovimentos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numeros de discos con los que juegas";
            // 
            // textBox1
            // 
            this.cajaMovimientos.Location = new System.Drawing.Point(26, 54);
            this.cajaMovimientos.Multiline = true;
            this.cajaMovimientos.Name = "textBox1";
            this.cajaMovimientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cajaMovimientos.Size = new System.Drawing.Size(400, 336);
            this.cajaMovimientos.TabIndex = 4;
            this.cajaMovimientos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // toresHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 413);
            this.Controls.Add(this.cajaMovimientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMovimentos);
            this.Controls.Add(this.introducirNumeros);
            this.Controls.Add(this.button1);
            this.Name = "toresHanoi";
            this.Text = "Torres de Hanoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox introducirNumeros;
        private System.Windows.Forms.Label labelMovimentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajaMovimientos;
    }
}

