﻿using System;
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
    public partial class revisarPrimosMatriz : Form
    {

        //num de filas y columnas 
        const int kFilas = 2;
        const int kCol = 2;

        int[,] matrizPrimos = new int[kFilas, kCol];

        //los enteros de las matriz
        int numeroMatriz00 = -1;
        int numeroMatriz10 = -1;
        int numeroMatriz01 = -1;
        int numeroMatriz11 = -1;




        /// <summary>
        /// inicializa componentes 
        /// </summary>
        public revisarPrimosMatriz()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este botón llama a las funciones qye primero ingresa números
        /// despues comprueba que números de los que has ingresado son primos
        /// y por ultimo los muestra
        /// </summary>
        /// <remarks>No hace falta controlar con int.tryParse porque ya esta controlado anteriormente</remarks>
        /// <param name="sender">lanza la funcion que llama al botón bPrimos</param>
        /// <param name="e">sin uso</param>
        private void bPrimos(object sender, EventArgs e)
        {

            try
            {

                matrizPrimos[0, 0] = int.Parse(tMatriz00.Text);
                matrizPrimos[0, 1] = int.Parse(tMatriz01.Text);
                matrizPrimos[1, 0] = int.Parse(tMatriz10.Text);
                matrizPrimos[1, 1] = int.Parse(tMatriz11.Text);

                string texto = numerosPrimosLogica.comprobarMatriz(matrizPrimos);

                MessageBox.Show(texto);

            }
            catch (Exception exCatch)
            {

                MessageBox.Show("Se ha producido un eror " + exCatch);
            }


        }

        /// <summary>
        /// Cargar la parte visual del formulario
        /// </summary>
        /// <param name="sender">Lanza el evento que carga pa larte visual del formulario</param>
        /// <param name="e">sin uso</param>
        private void formularioPrimosLoad(object sender, EventArgs e)
        {

            tMatriz00.MaxLength = 10;
            tMatriz01.MaxLength = 10;
            tMatriz10.MaxLength = 10;
            tMatriz11.MaxLength = 10;

        }
        /// <summary>
        /// Text change con las condiciones que no esten vacias y limitando el tamaño del texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tMatriz00_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Pasan todos los números de la matriz por el try parse para que se pueda activar el boton
                //uso la condicion de que los números no sean menor de 0 ni mayor que el maxvalue para controlar el boton
                if (int.TryParse(tMatriz00.Text, out numeroMatriz00) && int.TryParse(tMatriz10.Text, out numeroMatriz10)
                    && int.TryParse(tMatriz01.Text, out numeroMatriz01) && int.TryParse(tMatriz11.Text, out numeroMatriz11)
                    && numeroMatriz00 > 0 && numeroMatriz10 > 0 && numeroMatriz01 > 0 && numeroMatriz11 > 0)
                {

                    bIngresarNumeros.Enabled = true;

                }
                else
                {

                    bIngresarNumeros.Enabled = false;

                    //Si todos estan con algo en el textbox comprueba que sean caracteres validos
                    if (!string.IsNullOrEmpty(tMatriz00.Text) && !string.IsNullOrEmpty(tMatriz01.Text)
                        && !string.IsNullOrEmpty(tMatriz10.Text) && !string.IsNullOrEmpty(tMatriz11.Text))
                    {
                        if (!string.IsNullOrEmpty(tMatriz00.Text) || !string.IsNullOrEmpty(tMatriz01.Text)
                            || !string.IsNullOrEmpty(tMatriz10.Text) || !string.IsNullOrEmpty(tMatriz11.Text))
                        {

                            MessageBox.Show("Para jugar solo puede ser un número entre 1 y maxvalue, no permitidos decimales ni otros caractéres");

                            tMatriz00.Text = "";
                            tMatriz01.Text = "";
                            tMatriz10.Text = "";
                            tMatriz11.Text = "";

                        }

                    }
                }
            }
            catch (Exception exCatch)
            {

                MessageBox.Show("Se ha producido un error" + exCatch);
            }



        }
    }
}
