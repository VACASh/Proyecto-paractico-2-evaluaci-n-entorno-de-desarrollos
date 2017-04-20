using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Numeros.PrimitivaLogica
{
    class laPrimitivaLogica
    {

        ArrayList listaPremiada = new ArrayList();
        ArrayList listaDondeJuegas = new ArrayList();



        Random randomLoteria = new Random();

        public void borrarLista()
        {
            listaPremiada.Clear();
        }


        /// <summary>
        /// String donde compara la lista de jeugos con la lista premiada y va añadiendo el número de aciertos
        /// </summary>
        /// <remarks>Si haciertas todos te dice que has ganado, si no te dice los números que has acertado.
        /// en el caso de que no aciertes nada tambien te devolvera que no has acertado ninguno </remarks>
        /// <returns>Devuelve el string con lo que has acertado </returns>
        public string textoLoteria()
        {
            string textoAciertos = "has acertado: \n ";
            int numContador = 0;

            for (int i = 0; i < listaPremiada.Count; i++)
            {
                
                if (listaPremiada.Contains(listaDondeJuegas[i]))
                {

                    numContador++;
                    textoAciertos = textoAciertos + listaDondeJuegas[i] + ",";

                }

            }

            if (numContador == 0)
            {

                textoAciertos = "No has acertado ninguno";

            }

            if (numContador == 6)
            {

                textoAciertos = "Has acertado todas YOU WIN!!!";

            }

            return textoAciertos;

        }
        /// <summary>
        /// rellena el arraylist de los números que vas a jugar .
        /// <remarks>ingresas los números por inputbox  llama al metodo comprobarrrepe para
        /// que no ingreses números repetidos si esta repetido no avanzas y tienes que volver a ingresarlo</remarks>
        /// </summary>
        public string rellenarPrimitiva(int numeroQueIngresas)
        {

            string suceso = "El número ";
            if (numeroQueIngresas < 50 && numeroQueIngresas > 0)
            {

                if (listaDondeJuegas.Contains(numeroQueIngresas))
                {

                    suceso = suceso + "esta repetido ingrese otro";

                }
                else
                {

                    listaDondeJuegas.Add(numeroQueIngresas);
                    suceso = suceso + "ha sido añadido";

                }

            }

            return suceso;

        }
        /// <summary>
        /// Lista donde se ingresan números premiados de forma aleatoria.
        /// </summary>
        /// <remarks>Los números son random pero solo estan comprendidos entre el 0 y el 49</remarks>
        public void rellenarPremiado()
        {

            int i = 0;

            while (i < listaDondeJuegas.Count)
            {

                int numRandom = randomLoteria.Next(49);

                if (!listaPremiada.Contains(numRandom) && numRandom!=0)
                {

                    listaPremiada.Add(numRandom);
                    i++;
                    
                }            

            }
        }

        /// <summary>
        /// Renicia primitiva
        /// </summary>
        public void reiniciarPrimitiva()
        {
            listaDondeJuegas.Clear();
            listaPremiada.Clear();
        }
    }
}

    

