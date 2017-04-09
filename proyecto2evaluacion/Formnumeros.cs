using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// espacio de nombres de la clase números
/// </summary>
namespace Numeros
{
    /// <summary>
    /// Formulario principal donde esta el acceso a los demas formularios
    /// </summary>
    public partial class tNumeros : Form
    {
        /// <summary>
        /// Inicializa el formulario
        /// </summary>
        public tNumeros()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botón que llama al objeto fibonnaci y accede al formulario
        /// </summary>
        /// <param name="sender">Lanza el  botón bFibo</param>
        /// <param name="e">sin uso</param>
        private void bFibo(object sender, EventArgs e)
        {

            MessageBox.Show("Esta aplicacion calcula los números fibonacci desde el 0 hasta el número que insertas");
            Fibonacci.numFibonacci oFibo = new Fibonacci.numFibonacci();
            oFibo.ShowDialog();

        }


        /// <summary>
        /// Carga el formulario
        /// </summary>
        /// <param name="sender">Lanza el evento que carga el formulario</param>
        /// <param name="e">sin uso</param>
        private void forNumerosLoad(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Botón que llama al objeto primos y accede al formulario
        /// </summary>
        /// <param name="sender">Lanza el  botón bPrimos</param>
        /// <param name="e">sin uso</param>
        private void bPrimos(object sender, EventArgs e)
        {

            MessageBox.Show("Este aplicacion te pide que ingreses números en una matriz y te dice cuales son primos y que posicion ocupan en la matriz");
            Primos.revisarPrimosMatriz oPrimos = new Primos.revisarPrimosMatriz();
            oPrimos.ShowDialog();

        }

        /// <summary>
        /// Botón que llama al formulario de las torres de hanoi
        /// </summary>
        /// <param name="sender">lanza el  boton bTorresHanoi</param>
        /// <param name="e">sin uso</param>
        private void bTorresHanoi(object sender, EventArgs e)
        {

            MessageBox.Show("Esta aplicacion te pide que ingreses un números de discos para jugar a torres de hanoi y te te indica cuales son los movimientos que debes hacer");
            Hanoi.torresHanoi oHanoi = new Hanoi.torresHanoi();
            oHanoi.ShowDialog();

        }
        /// <summary>
        /// Botón que llama al formulario de loteria
        /// </summary>
        /// <param name="sender">lanza el   botón bPrimitiva</param>
        /// <param name="e">sin uso</param>
        private void bPrimitiva(object sender, EventArgs e)
        {

            MessageBox.Show("esta aplicacion te pide que ingreses números y hace un sorteo de primitiva y te dice los aciertos");
            Primitiva.jugarPrimitiva oPrimitiva = new Primitiva.jugarPrimitiva();
            oPrimitiva.ShowDialog();

        }
    }
}
