using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros.TorresHanoi
{
     class torresDeHanoiLogica
    {

        /// <summary>
        /// Torres de hanoi recursivo donde se le pasa el número de discos y te dice que movimientos deberias hacer para completarlo
        /// </summary>
        /// <remarks>Forma recursiva para poder hacerlo, importante el orden de las variables. Cuando llega a 0 
        /// para y devuelve el texto</remarks>
        /// <param name="numDiscos">El número de disco que juegan</param>
        /// <param name="discOrigen">El origen de donde salen los dicos</param>
        /// <param name="discDestino">El destino de donde tienen que llegar los discos</param>
        /// <param name="discAux">El auxiliar del juego</param>
        /// <param name="textoMovimientos">Almacenador de movimientos</param>
        public void torresDeHanoi(int numDiscos, string discOrigen, string discDestino, string discAux, ref string textoMovimientos)
        {

            if (numDiscos > 0)
            {

                //orden de variables importante no modificar
                torresDeHanoi(numDiscos - 1, discOrigen, discAux, discDestino, ref textoMovimientos);
                textoMovimientos = textoMovimientos + "Muevo el disco " + numDiscos + " de " + discOrigen + " a " + discDestino + "\n ";
                torresDeHanoi(numDiscos - 1, discAux, discDestino, discOrigen, ref textoMovimientos);

            }

        }

    }
}
