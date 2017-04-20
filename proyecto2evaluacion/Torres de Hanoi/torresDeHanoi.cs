using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Globalization;



namespace Numeros.Hanoi
{
    /// <summary>
    /// Juego de las torres de hanoi
    /// <remarks>No se pueden hacer con más de 13 discos el número de movimientos necesarios hace
    /// que el programa de error</remarks>
    /// </summary>
    public partial class torresHanoi : Form
    {

        int numDiscos = 0;

        ResourceManager manejoTexto;

        /// <summary>
        /// inicializa componentes
        /// </summary>
        public torresHanoi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// botón que llama al metodo y recibe un texto que muestra por label con el número de movimientos 
        /// necesarios para lograr ganar
        /// </summary>
        /// <remarks>El número de discos que vamos a pasar al metodo se recibe por un textbox</remarks>
        /// <param name="sender">lanza el el botón bHanoi</param>
        /// <param name="e">sin uso</param>
        private void bHanoi(object sender, EventArgs e)
        {

            string textoMovimentos = "";

            Hanoi.torresDeHanoiLogica oTorres = new Hanoi.torresDeHanoiLogica();

            numDiscos = int.Parse(introducirNumeros.Text);

            oTorres.torresDeHanoi(numDiscos, "Origen", "Destino", "Auxiliar", ref textoMovimentos);

            cajaMovimientos.Text = textoMovimentos;


        }


        /// <summary>
        /// carga la parte visual del formulario
        /// </summary>
        /// <param name="sender">Lanza el evento que carga la parte visual del formulario</param>
        /// <param name="e">sin uso</param>
        private void formularioTorresDeHanoiLoad(object sender, EventArgs e)
        {
           // string manejandoTexto = proyecto2evaluacion.Properties.Resources.stringHanoi;
           // manejoTexto = new ResourceManager("es-ES", Assembly.GetExecutingAssembly());
            //solucionar
            //lMinimoMaximo.Text = manejoTexto.GetString(manejoTexto);

        }
        /// <summary>
        /// textxchanged  del texto de los movimientos de torres de hanoi
        /// </summary>
        /// <param name="sender">Lanza el  textchanged del textvox donde almacena movimientos</param>
        /// <param name="e">sin uso</param>
        private void tTorresDeHanoiMovimientos_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Este textchange controla que solo puedan ser números entre 0 y 9 y no acepta 
        /// otros caracteres 
        /// </summary>
        /// <remarks>Activa el boton si los datos son los deseados de lo contrario lo desactiva </remarks>
        /// <param name="sender">Llama al textchange de introducir números</param>
        /// <param name="e"></param>
        private void introducirNumeros_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(introducirNumeros.Text, out numDiscos) && numDiscos > 0 && numDiscos < 10)
            {

                bJugarTorres.Enabled = true;

            }
            else
            {

                bJugarTorres.Enabled = false;

                if (!string.IsNullOrEmpty(introducirNumeros.Text))
                {
                    MessageBox.Show("Para jugar solo puede ser un número entre 1 y 9");

                    introducirNumeros.Text = null;

                }

            }

            introducirNumeros.MaxLength = 1;

        }

        private void lNumeroDiscos_Click(object sender, EventArgs e)
        {

        }

        private void lMinimoMaximo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
