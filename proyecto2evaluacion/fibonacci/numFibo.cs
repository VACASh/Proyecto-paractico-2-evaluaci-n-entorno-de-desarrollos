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
    /// clase parcial  de números fibonacci
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

            try
            {

                if (int.TryParse(tFibo.Text, out numIntroducido) )
                {

                    if (numIntroducido > 0)
                    {

                        string textoFibo = numerosFibonacciLogica.textFibo(numIntroducido);

                        MessageBox.Show(textoFibo);

                    }
                    else
                    {
                      
                        string mayorDe0 = proyecto2evaluacion.recursosProyecto.stringMayorDe0;
                        MessageBox.Show(mayorDe0);

                    }

                }
                else
                {


                    if (numIntroducido >= int.MaxValue)
                    {
                        string noPermitido = proyecto2evaluacion.recursosProyecto.stringNoPermitido;
                        MessageBox.Show(noPermitido);

                    }
                    else
                    {
                        string inserteNumero = proyecto2evaluacion.recursosProyecto.stringInserteNum;
                        MessageBox.Show(inserteNumero);

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido un error " + ex.Message);

            }
            




        }

        /// <summary>
        /// Usado para limitar el tamaño a 10 caracteres
        /// </summary>
        /// <param name="sender">Lanza el textchange del formulario </param>
        /// <param name="e">Sin uso</param>
        private void tFibo_TextChanged(object sender, EventArgs e)
        {
            //limitado el texto a 10 para que no puedas pasarse del maxvalue
            tFibo.MaxLength = 10;
            if (!int.TryParse(tFibo.Text, out int resultadoEsperado) && !string.IsNullOrEmpty(tFibo.Text))
            {

                MessageBox.Show("inserte un valor adecuado que no sobrepase el valor maximo permitido por visual stuido, ni con decimales");

                tFibo.Text = "";
                
            }
          
            
        }

 
    }
}
