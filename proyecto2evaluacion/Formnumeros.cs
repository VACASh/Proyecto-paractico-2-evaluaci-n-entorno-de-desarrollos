using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros
{
    /// <summary>
    /// Formulario principal donde esta el acceso a los demas formularios
    /// </summary>
    public partial class formNumeros : Form
    {
        /// <summary>
        /// Inicializa el formulario
        /// </summary>
        public formNumeros()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botón que llama al objeto fibonnaci y accede al formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bFibo(object sender, EventArgs e)
        {

            Fibonacci.formFibo oFibo = new Fibonacci.formFibo();
            oFibo.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Botón que llama al objeto primos y accede al formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPrimos(object sender, EventArgs e)
        {
            Primos.formPrimos oPrimos = new Primos.formPrimos();
            oPrimos.ShowDialog();
        }

        /// <summary>
        /// Botón que llama al formulario de las torres de hanoi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bTorresHanoi(object sender, EventArgs e)
        {
            Hanoi.toresHanoi oHanoi = new Hanoi.toresHanoi();
            oHanoi.ShowDialog();
        }
        /// <summary>
        /// Botón que llama al formulario de loteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPrimitiva(object sender, EventArgs e)
        {

            Primitiva.jugarPrimitiva oPrimitiva = new Primitiva.jugarPrimitiva();
            oPrimitiva.ShowDialog();

        }
    }
}
