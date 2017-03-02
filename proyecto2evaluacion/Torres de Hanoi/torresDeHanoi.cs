using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros.Hanoi
{
    /// <summary>
    /// Juego de las torres de hanoi
    /// <remarks>No se pueden hacer con más de 13 discos el número de movimientos necesarios hace
    /// que el programa de error</remarks>
    /// </summary>
    public partial class toresHanoi : Form
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
        void torresDeHanoi(int numDiscos, string discOrigen, string discDestino,string discAux, ref string textoMovimientos)
        {

            if (numDiscos > 0)
            {
                //orden de variables importante no modificar
                torresDeHanoi(numDiscos - 1, discOrigen, discAux, discDestino, ref textoMovimientos);
                textoMovimientos = textoMovimientos + "Muevo el disco " + numDiscos + " de " + discOrigen + " a "  + discDestino + "\n";
                torresDeHanoi(numDiscos - 1, discAux, discDestino, discOrigen, ref textoMovimientos);

            }
            
        }

        /// <summary>
        /// inicializa componentes
        /// </summary>
        public toresHanoi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// botón que llama al metodo y recibe un texto que muestra por label con el número de movimientos 
        /// necesarios para lograr ganar
        /// </summary>
        /// <remarks>El número de discos que vamos a pasar al metodo se recibe por un textbox</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bHanoi(object sender, EventArgs e)
        {

            int numDiscos = int.Parse(introducirNumeros.Text);
            string textoMovimentos = "";

            torresDeHanoi(numDiscos, "origen", "destino", "auxiliar", ref textoMovimentos);
            labelMovimentos.Text = textoMovimentos;

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
