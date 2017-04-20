using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Numeros.Fibonacci
{
    /// <summary>
    /// clase  de números fibonacci
    /// </summary>
    public partial class numFibonacci : Form
    {
        //numero usado para comprobar , inicializado a -1 para darle un valor luego cambia por el del textbox
        int numIntroducido = -1;

        /// <summary>
        /// Inicializa componentes
        /// </summary>
        public numFibonacci()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga la parte visual del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formularioFiboLoad(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// carga la parte visual del formulario
        /// </summary>
        /// <param name="sender">Lanza el evento que carga la parte visual del formulario</param>
        /// <param name="e">sin uso</param>
        private void Formfibonacci_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// botón que recibe el número por un textbox y muestra un message box con los números fibonacci
        /// llamando a la funcion textFibo
        /// </summary>
        /// <param name="sender">llama al botón bFibo</param>
        /// <param name="e">SIN USO</param>
        private void bFibo(object sender, EventArgs e)
        {


            string textoFibo = Fibonacci.numerosFibonacciLogica.textFibo(numIntroducido);

            MessageBox.Show(textoFibo);

        }
        /// <summary>
        /// Usado para limitar el tamaño a 10 caracteres y deshabilitado el botón si no introducen
        /// caracteres adecuados
        /// </summary>
        /// <remarks>No deja introducir nada que no este comprendido entre 1 y maxvalue-1</remarks>
        /// <param name="sender">Lanza el textchange del formulario </param>
        /// <param name="e">Sin uso</param>
        private void tFibo_TextChanged(object sender, EventArgs e)
        {
            //limitado el texto a 10 para que no puedas pasarse del maxvalue
            tFibo.MaxLength = 10;

            if (int.TryParse(tFibo.Text, out numIntroducido) && !string.IsNullOrEmpty(tFibo.Text))
            {

                if (numIntroducido > 0 )
                {

                    bMostrar.Enabled = true;

                }
                else
                {

                    
                    bMostrar.Enabled = false;

                    MessageBox.Show("El número debe ser mayor de 0");

                    tFibo.Text = null;
                }

            }
            else
            {

                if (!string.IsNullOrEmpty(tFibo.Text))
                {
                    MessageBox.Show("Debe introducir un número entero positivo no valen caracteres ni se debe pasar el numero maximo permitido");

                    tFibo.Text = null;

                }

                bMostrar.Enabled = false;

            }

        }

    }
}
