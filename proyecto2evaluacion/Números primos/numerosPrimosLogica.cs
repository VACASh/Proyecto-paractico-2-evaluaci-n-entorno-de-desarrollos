using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros.Primos
{
    /// <summary>
    /// clase estatica de la logica de numeros primos
    /// </summary>
    public static class numerosPrimosLogica
    {
        /// <summary>
        /// Compueba si es primo  devuelve true si es primo false si no lo es.
        /// En el momento que lo encuentra se sale fuera y devulve true en ese caso.
        /// </summary>
        /// <remarks>cuando llega a la mitad del número ya comprueba todas las posibilidades de 
        /// que sea primo</remarks>
        /// <param name="numRecibido">El numero que se le pasa para comprobar si es primo</param>
        /// <returns>Devuelve booleano si es primo devuelve true si no es primo devuelve false</returns>
        static bool esPrimo(int numRecibido)
        {

            bool buscarPrimo = true;

            for (int i = 2; i <= numRecibido / 2 && buscarPrimo; i++)
            {

                if (numRecibido % i == 0)
                {

                    buscarPrimo = false;

                }

            }

            return buscarPrimo;

        }

       

        /// <summary>
        /// Almacena los números primos dentro de la matriz en un string 
        /// </summary>
        /// <remarks>llama al metodo para ver cuales son primos</remarks>
        /// <param name="cualquierMatrizComprobar">Matriz de números</param>
        /// <returns>Devuelve string con los números primos</returns>
        public static string comprobarMatriz(int[,] cualquierMatrizComprobar)
        {

            string textoMatrices = "Los números primos dentro de la matriz son: \n";

            for (int i = 0; i < cualquierMatrizComprobar.GetLength(0); i++)
            {

                for (int j = 0; j < cualquierMatrizComprobar.GetLength(1); j++)
                {

                    if (esPrimo(cualquierMatrizComprobar[i, j]))
                    {

                        textoMatrices = textoMatrices + "de la posicion " + i + "," + j + "el valor: " + cualquierMatrizComprobar[i, j] + "\n";

                    }

                }

            }

            return textoMatrices;

        }

    }
}
