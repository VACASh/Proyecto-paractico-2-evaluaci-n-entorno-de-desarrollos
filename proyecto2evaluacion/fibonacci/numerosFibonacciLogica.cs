using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//preguntar si ese es el nombre valido para el namespace del subsistema
namespace Numeros.Fibonacci
{
    /// <summary>
    /// Clase logica statica de números fibonacci
    /// </summary>
    public static class numerosFibonacciLogica
    {
        /// <summary>
        /// Va cogiendo los numeros fibonacci que hay comprendidos entre el 0 y el número introducido.
        /// fibo1 es el que va almacenando el número fibonacci y lo va sumando en el string,
        /// fibo2 se usa para sumarle el número anterior a fibo1 que es como funciona fibonacci
        /// </summary>
        /// <remarks>auxFibo es un aux que se usa para poder almacenar y poder sumar y no machacar
        /// el número anterior</remarks>
        /// <param name="numIntroducido">El número se le pasa para comprobar</param>
        /// <returns>Devuelve string con los números fibonacci</returns>
        public static string textFibo(int numIntroducido)
        {

            int numFibo1 = 0;
            int numFibo2 = 1;
            int auxFibo = 0;

            string textoAlmacenaFibo = "Estos son los números fibonacci hasta el número introducido: ";

            //se le añade el 0 porque se consedera que es un número fibonacci
            textoAlmacenaFibo = textoAlmacenaFibo + numFibo1 + ",";

            bool acabar = false;


            for (int i = 0; numFibo1 < numIntroducido && !acabar; i++)
            {

                auxFibo = numFibo1;
                numFibo1 = numFibo1 + numFibo2;
                numFibo2 = auxFibo;

                //revisar
                if (numFibo1 < 0)
                {

                    acabar = true;

                }
                else
                {
                    if (numFibo1 <= numIntroducido)
                    {

                        textoAlmacenaFibo = textoAlmacenaFibo + numFibo1 + ",";

                    }

                }

            }

            return textoAlmacenaFibo;

        }
    }
}
