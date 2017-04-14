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

            int numIntroducido = -1;

            if (int.TryParse(tFibo.Text, out numIntroducido) && numIntroducido < int.MaxValue && numIntroducido > 0)
            {

                if (numIntroducido > 0)
                {

                    string textoFibo = NumerosFibo.numerosFibonacciLogica.textFibo(numIntroducido);

                    MessageBox.Show(textoFibo);

                }
                else
                {

                    MessageBox.Show("El número debe ser mayor de 0");

                }

            }
            else
            {


                if (numIntroducido >= int.MaxValue)
                {

                    MessageBox.Show("El número introducido supera el valor maximo permitido para un entero");

                }
                else
                {

                    MessageBox.Show("Inserte un número , el resto de parámetros son inválidos");

                }

            }




        }

        private void tFibo_TextChanged(object sender, EventArgs e)
        {
            //limitado el texto a 10 para que no puedas pasarse del maxvalue
            tFibo.MaxLength = 10;
        }

 
    }
}
