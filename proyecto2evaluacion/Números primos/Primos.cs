using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros.Primos
{
    /// <summary>
    /// Clase parcial de números primos
    /// <remarks>las constantes kFilas y kCol soN laS filas y columnas de la matriz en la que ingresamos los num primos</remarks>
    /// </summary>
    public partial class tPrimos : Form
    {
        //num de filas y columnas 
        const int kFilas = 5;
        const int kCol = 6;

        int[,] matrizPrimos = new int[kFilas, kCol];

        /// <summary>
        /// Objeto de texto que usamos para ingresar números
        /// </summary>
        /// <param name="texto">Texto a ingresar </param>
        /// <returns>devuelve el valor que se le ingresa</returns>
        private static string InputBox(string texto)
        {

            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;

        }

        /// <summary>
        /// Compueba si es primo  devuelve true si es primo false si no lo es.
        /// En el momento que lo encuentra se sale fuera y devulve true en ese caso.
        /// </summary>
        /// <remarks>cuando llega a la mitad del número ya comprueba todas las posibilidades de 
        /// que sea primo</remarks>
        /// <param name="numRecibido">El numero que se le pasa para comprobar si es primo</param>
        /// <returns>Devuelve booleano si es primo devuelve true si no es primo devuelve false</returns>
        bool esPrimo(int numRecibido)
        {

            bool buscarPrimo = true;

            for (int i = 2; i <= numRecibido/2 &&  buscarPrimo; i++)
            {

                if (numRecibido%i==0)
                {

                    buscarPrimo = false;

                }

            }

            return buscarPrimo;

        }

        /// <summary>
        /// Va ingresando números a la matriz  y rellenandola
        /// </summary>
        /// <param name="culaqueirMatriz">matriz donde ingresas números </param>
        void ingresarMatriz(int [,] culaqueirMatriz)
        {
            
            for (int i = 0; i < culaqueirMatriz.GetLength(0); i++)
            {

                for (int j = 0; j < culaqueirMatriz.GetLength(1); j++)
                {

                    culaqueirMatriz[i, j] = int.Parse(InputBox("Elemento[" + i + ", " + j + "]"));

                }

            }

        }

        /// <summary>
        /// Almacena los números primos dentro de la matriz en un string 
        /// </summary>
        /// <param name="cualquierMatrizComprobar">Matriz de números</param>
        /// <returns>Devuelve string con los números primos</returns>
        string comprobarMatriz(int[,] cualquierMatrizComprobar)
        {

            string textoMatrices = "Los números primos dentro de la matriz son: \n";

            for (int i = 0; i < cualquierMatrizComprobar.GetLength(0); i++)
            {

                for (int j = 0; j < cualquierMatrizComprobar.GetLength(1); j++)
                {

                    if (esPrimo(cualquierMatrizComprobar[i, j]))
                    {

                        textoMatrices = textoMatrices + "de la posicion " + i + "," + j +   "el valor: " +cualquierMatrizComprobar[i, j] + "\n";

                    }

                 }

            }

            return textoMatrices;      

        }

        /// <summary>
        /// inicializa formulario
        /// </summary>
        public tPrimos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este botón llama a las funciones qye primero ingresa números
        /// despues comprueba que números de los que has ingresado son primos
        /// y por ultimo los muestra
        /// </summary>
        /// <param name="sender">lanza la funcion que llama al botón bPrimos</param>
        /// <param name="e">sin uso</param>
        private void bPrimos(object sender, EventArgs e)
        {

            ingresarMatriz(matrizPrimos);
            string texto = comprobarMatriz(matrizPrimos);

            MessageBox.Show(texto);

        }

        /// <summary>
        /// Cargar la parte visual del formulario
        /// </summary>
        /// <param name="sender">Lanza el evento que carga pa larte visual del formulario</param>
        /// <param name="e">sin uso</param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
