﻿using System;
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

        LaPrimitivaLogica oPrimitiva = new LaPrimitivaLogica();

        const int kPrimitiva = 6;

        int contadorDeNumeros = 0;

     

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
            try
            {

                oPrimitiva.rellenarPremiado();

                string textoMostrar = oPrimitiva.textoLoteria();

                MessageBox.Show(textoMostrar);

                bProbarSuerte.Enabled = false;
                bReiniciarLaPrimitiva.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido un error " + ex.Message);

            }
           

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

            try
            {

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

                if (contadorDeNumeros == 6)
                {
                    MessageBox.Show("ya has ingresado todos los números");

                    tRellenarPrimitiva.Enabled = false;

                    bRellenarPrimitiva.Enabled = false;

                    bProbarSuerte.Enabled = true;

                }

            }
            catch (Exception ex )
            {

                MessageBox.Show("Se ha producido un error " + ex.Message);

            }          

        }

        /// <summary>
        /// carga la parte visual del formulario
        /// </summary>
        /// <param name="sender">lanza el evento que carga a la parte visual del formulario</param>
        /// <param name="e">sin uso</param>
        private void formularioPrimitivaLoad(object sender, EventArgs e)
        {
            tRellenarPrimitiva.MaxLength = 2;
        }

        /// <summary>
        /// textchanged del texto rellenar primitiva  donde se controla que no este vacio
        /// </summary>
        /// <remarks>si no es ta vacio activa el boton para poder jugar</remarks>
        /// <param name="sender">lanza el envento del textchanged</param>
        /// <param name="e">sin uso</param>
        private void tRellenarPrimitiva_TextChanged(object sender, EventArgs e)
        {
            string comprobarVacio = tRellenarPrimitiva.Text;

            if (!string.IsNullOrEmpty(comprobarVacio))
            {

                bRellenarPrimitiva.Enabled = true;

            }

           
        }

        /// <summary>
        /// Boton que reinicia la primitiva para empezar otra vez a jugar
        /// </summary>
        /// <remarks>Vuelve a activar los botones para poder jugar</remarks>
        /// <param name="sender">Lanza el boton de reiniciar la primtiva</param>
        /// <param name="e">sin uso</param>
        private void bReiniciarLaPrimitiva_Click(object sender, EventArgs e)
        {
            try
            {

                tRellenarPrimitiva.Enabled = true;
                bRellenarPrimitiva.Enabled = true;
                bProbarSuerte.Enabled = false;
                bReiniciarLaPrimitiva.Enabled = false;

                oPrimitiva.borrarLista();

                contadorDeNumeros = 0;
            }
            catch (Exception ex )
            {

                MessageBox.Show("Se ha producido un error " + ex.Message);

            }
           
        }

        /// <summary>
        /// evento lick del label no tiene uso
        /// </summary>
        /// <param name="sender">lanza el evento click del label</param>
        /// <param name="e">sin uso</param>
        private void ingresarNumerosQueJuegas_Click(object sender, EventArgs e)
        {

        }
    }
}
