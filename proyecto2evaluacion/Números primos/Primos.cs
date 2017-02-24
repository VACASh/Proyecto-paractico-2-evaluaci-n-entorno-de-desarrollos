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
    public partial class Formprimos : Form
    {
        /// <summary>
        /// constantes para el número de columnas y filas. Y creamos la matriz
        /// </summary>
        const int kfilas = 5;
        const int kcol = 6;

        int[,] matriz = new int[kfilas, kcol];

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
        /// <param name="num">El numero que se le pasa para comprobar si es primo</param>
        /// <returns>Devuelve booleano si es primo devuelve true si no es primo devuelve false</returns>
        bool esPrimo(int num)
        {

            bool primo = true;

            for (int i = 2; i <= num/2 &&  primo; i++)
            {

                if (num%i==0)
                {

                    primo = false;

                }

            }

            return primo;

        }

        /// <summary>
        /// Va ingresando números a la matriz  y rellenandola
        /// </summary>
        /// <param name="Matriz">matriz donde ingresas números </param>
        void ingresarMatriz(int [,] Matriz)
        {
            
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {

                for (int j = 0; j < Matriz.GetLength(1); j++)
                {

                    Matriz[i, j] = int.Parse(InputBox("Elemento[" + i + ", " + j + "]"));

                }

            }

        }

        /// <summary>
        /// Almacena los números primos dentro de la matriz en un string 
        /// </summary>
        /// <param name="matriz">Matriz de números</param>
        /// <returns>Devuelve string con los números primos</returns>
        string comprobarPrimo(int[,] matriz)
        {

            string texto = "Los números primos dentro de la matriz son: \n";

            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    if (esPrimo(matriz[i, j]))
                    {

                        texto = texto + "de la posicion " + i + "," + j +   "el valor" +matriz[i, j] + "\n";

                    }

                 }

            }

            return texto;      

        }
        public Formprimos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este botón llama a las funciones qye primero ingresa números
        /// despues comprueba que números de los que has ingresado son primos
        /// y por ultimo los muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPrimos(object sender, EventArgs e)
        {

            ingresarMatriz(matriz);
            string texto = comprobarPrimo(matriz);

            MessageBox.Show(texto);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
