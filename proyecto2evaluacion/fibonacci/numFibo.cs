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
/// El espacio de nombres fibonacci
/// </summary>
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
       /// Va cogiendo los numeros fibonacci que hay comprendidos entre el 0 y el número introducido.
       /// fibo1 es el que va almacenando el número fibonacci y lo va sumando en el string,
       /// fibo2 se usa para sumarle el número anterior a fibo1 que es como funciona fibonacci
       /// </summary>
       /// <remarks>auxFibo es un aux que se usa para poder almacenar y poder sumar y no machacar
       /// el número anterior</remarks>
       /// <param name="numIntroducido">El número se le pasa para comprobar</param>
       /// <returns>Devuelve string con los números fibonacci</returns>
        string textFibo(int numIntroducido)
        {
            
            int  numFibo1, numFibo2, auxFibo;

            string textoAlmacenaFibo;
            textoAlmacenaFibo = "Estos son los números fibonacci hasta el número introducido: ";

            numFibo1 = 0;

            //se le añade el 0 porque se consedera que es un número fibonacci
            textoAlmacenaFibo = textoAlmacenaFibo + numFibo1 + ",";
            numFibo2 = 1;
          
            for (int i = 0; numFibo1 < numIntroducido; i++)
            {

                auxFibo = numFibo1;
                numFibo1 = numFibo1 + numFibo2;
                numFibo2 = auxFibo;

                if (numFibo1 <= numIntroducido)
                {

                    textoAlmacenaFibo = textoAlmacenaFibo + numFibo1 + ",";

                }

            }

            return textoAlmacenaFibo;

        }
       
        /// <summary>
        /// Carga la parte visual del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
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
        /// <param name="sender">Lanza el evento del botón bFibo</param>
        /// <param name="e">SIN USO</param>
        private void bFibo(object sender, EventArgs e)
        {
            int numIntroducido;

            if (int.TryParse(tFibo.Text, out numIntroducido)) 
            {
                MessageBox.Show(textFibo(numIntroducido));
            }
            else
	        {
                MessageBox.Show("Inserte un número entero el resto de parámetros son inválidos");
            }
             

            

        }

        private void tFibo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
