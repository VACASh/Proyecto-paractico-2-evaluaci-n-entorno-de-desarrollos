using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Numeros.Primitiva
{
    /// <summary>
    /// Clase primitiva donde juegas tus 6 números y compruebas si has ganado
    /// <remarks>Constante kPrimitiva para que solo se puedan jugar 6 números</remarks>
    /// </summary>
    public partial class jugarPrimitiva : Form
    {
        ArrayList arrayPrimitiva = new ArrayList();
        ArrayList arrayJugar = new ArrayList();

        const int kPrimitiva = 6;

        Random randomLoteria = new Random();

        /// <summary>
        /// Inputbox
        /// </summary>
        /// <param name="texto">texto de entrada</param>
        /// <returns></returns>
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
        /// inicializa componentes
        /// </summary>
        public jugarPrimitiva()
        {
            InitializeComponent();
        }

        /// <summary>
        /// comprueba que no metas un número repetido
        /// </summary>
        /// <remarks>en el omemto que lo encuentra no continua en el bucle </remarks>
        /// <param name="listaComprobar">lista de comparación</param>
        /// <param name="numeroComprobar">Número a comprobar</param>
        /// <returns>devuelve true si el número esta repetido  false si no esta repetido</returns>
        bool comprobarRepetido(ArrayList listaComprobar, int numeroComprobar)
        {

            int i = 0;
            bool numEncontrado = false;

            while(i < kPrimitiva && numEncontrado == false)
            {
                
                if (listaComprobar.Contains(numeroComprobar))
                {

                    numEncontrado = true;
                    MessageBox.Show("Inserte un número que no este repetido");

                }
                else
                {    
                           
                    i++;

                }

            }

            return numEncontrado;

        }

        /// <summary>
        /// rellena el arraylist de los números que vas a jugar .
        /// <remarks>ingresas los números por inputbox  llama al metodo comprobarrrepe para
        /// que no ingreses números repetidos si esta repetido no avanzas y tienes que volver a ingresarlo</remarks>
        /// </summary>
        /// <param name="listaParaJugar">Lista en la que ingreas números</param>
        void rellenarPrimitiva(ArrayList listaParaJugar)
        {
            
            int i = 0;
            while (i < kPrimitiva)
            {

                int num = int.Parse(InputBox("Introduzca número: "));

                if (num < 50 && num > 0)
                {
                
                    if (comprobarRepetido(listaParaJugar, num))
                    {

                        MessageBox.Show("esta repetido");

                    }
                    else
                    {

                        listaParaJugar.Add(num);
                        i++;

                    }

                }
                else
                {

                    MessageBox.Show("El número tiene que estar entre 1 y 49");

                }
                
            }

        }

        /// <summary>
        /// Lista donde se ingresan números premiados de forma aleatoria.
        /// </summary>
        /// <remarks>Los números son random pero solo estan comprendidos entre el 0 y el 49</remarks>
        /// <param name="listaPremiados">Lista donde ingresas números premiados</param>
        void rellenarPremiado(ArrayList listaPremiados)
        {
            
            int i = 0;

            while (i < kPrimitiva)
            {

                int numRandom = randomLoteria.Next(49);

                if (comprobarRepetido(listaPremiados, numRandom))
                {

                    MessageBox.Show("esta repetido");

                }
                else
                {

                    listaPremiados.Add(numRandom);
                    i++;

                }


            }
        }

        /// <summary>
        /// String donde compara la lista de jeugos con la lista premiada y va añadiendo el número de aciertos
        /// </summary>
        /// <remarks>Si haciertas todos te dice que has ganado, si no te dice los números que has acertado.
        /// en el caso de que no aciertes nada tambien te devolvera que no has acertado ninguno </remarks>
        /// <param name="ListaPremiada">Lista de números premiados</param>
        /// <param name="ListaDondeJuegas">Lista de números que juegas</param>
        /// <returns>Devuelve el string con lo que has acertado </returns>
        string textoLoteria(ArrayList ListaPremiada, ArrayList ListaDondeJuegas)
        {
            string textoAciertos = "has acertado: \n ";
            int numContador = 0;

            for (int i = 0; i < ListaPremiada.Count; i++)
            {

                if (ListaPremiada.Contains(ListaDondeJuegas[i]))
                {

                    numContador++;
                    textoAciertos = textoAciertos + ListaPremiada[i] + ",";

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
        /// Botón donde se hace el sorteo y lo compara con los números que has ingresado
        /// </summary>
        /// <remarks>Primero rellena la lista con números aleatorios antes de almacenar texto</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMuestraPremio(object sender, EventArgs e)
        {
            
            rellenarPremiado(arrayJugar);

            string textoMostrar = textoLoteria(arrayPrimitiva, arrayJugar);

            MessageBox.Show(textoMostrar);
            
        }

        /// <summary>
        /// este botón llama a un metodo para rellenar tu primitiva 
        /// </summary>
        /// <remarks>---</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRellenaTuPrimitiva(object sender, EventArgs e)
        {
            
            rellenarPrimitiva(arrayPrimitiva);
            
        }

        /// <summary>
        /// carga la parte visual del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
