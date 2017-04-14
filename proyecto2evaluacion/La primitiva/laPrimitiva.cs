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

/// <summary>
/// Espacio de nombres de la clase primitiva
/// </summary>
namespace Numeros.Primitiva
{
    /// <summary>
    /// Clase primitiva donde juegas tus 6 números y compruebas si has ganado
    /// <remarks>Constante kPrimitiva para que solo se puedan jugar 6 números</remarks>
    /// </summary>
    public partial class jugarPrimitiva : Form
    {
        PrimitivaLogica.LaPrimitivaLogica oPrimitiva = new PrimitivaLogica.LaPrimitivaLogica();

        const int kPrimitiva = 6;

        int contadorDeNumeros = 0;

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
        /// Botón donde se hace el sorteo y lo compara con los números que has ingresado
        /// </summary>
        /// <remarks>Primero rellena la lista con números aleatorios antes de almacenar texto</remarks>
        /// <param name="sender">Lanza el evento del botón bMuestraPremio</param>
        /// <param name="e">sin uso</param>
        private void bMuestraPremio(object sender, EventArgs e)
        {
            oPrimitiva.borrarLista();
            oPrimitiva.rellenarPremiado();

            string textoMostrar = oPrimitiva.textoLoteria();

            MessageBox.Show(textoMostrar);

        }

        /// <summary>
        /// este botón llama a un metodo para rellenar tu primitiva 
        /// </summary>
        /// <remarks>---</remarks>
        /// <param name="sender">Llama al  botón bRellenaTuPrimtiva</param>
        /// <param name="e">sin uso</param>
        private void bRellenaTuPrimitiva(object sender, EventArgs e)
        {
            
            int numeroIngresas = -1;

            if (contadorDeNumeros < kPrimitiva)
            {

                if (int.TryParse(tRellenarPrimitiva.Text, out numeroIngresas) && numeroIngresas > 0
                    && numeroIngresas < 50)
                {
                    MessageBox.Show(oPrimitiva.rellenarPrimitiva(numeroIngresas));

                    tRellenarPrimitiva.Text = null;

                    bRellenarPrimitiva.Enabled = false;

                    contadorDeNumeros++;
                }
                else
                {
                    MessageBox.Show("Inserte un valor valido");

                }

            }

            if(contadorDeNumeros==6)
            {
                MessageBox.Show("ya has ingresado todos los números");

                tRellenarPrimitiva.Enabled = false;

                bRellenarPrimitiva.Enabled = false;

                bProbarSuerte.Enabled = true;

            }




        }

        /// <summary>
        /// carga la parte visual del formulario
        /// </summary>
        /// <param name="sender">lanza el evento que carga a la parte visual del formulario</param>
        /// <param name="e">sin uso</param>
        private void formularioPrimitivaLoad(object sender, EventArgs e)
        {

        }

        private void tRellenarPrimitiva_TextChanged(object sender, EventArgs e)
        {
            string comprobarVacio = tRellenarPrimitiva.Text;

            if (!string.IsNullOrEmpty(comprobarVacio))
            {

                bRellenarPrimitiva.Enabled = true;

            }

            tRellenarPrimitiva.MaxLength = 2;
        }
    }
}
