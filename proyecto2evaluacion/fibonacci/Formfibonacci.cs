using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros.Fibonacci
{
    public partial class Formfibonacci : Form
    {
        public Formfibonacci()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Este programa introduces un número por un textbox
        ///  calcula los números fibonacci que hay entre el 0 y el número introducido
        ///  
        /// </summary>
        /// <remarks>fibo3 es un auxiliar necesario para poder almacenar el número anterior
        /// y asi poder sumar al número actual.
        /// </remarks>
        /// <remarks>En el momento que fibo1 es mayor o  igual al número introducido
        /// el programa para y muestra los números
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            int numintroducido, fibo1, fibo2, fibo3;
            string texto;
            texto = "";

            fibo1 = 0;
            texto = texto + fibo1 + ",";
            fibo2 = 1;

            numintroducido = int.Parse(textBox1.Text);
            
            for (int i = 0; fibo1 < numintroducido; i++)
            {
                fibo3 = fibo1;
                fibo1 = fibo1 + fibo2;
                fibo2 = fibo3;
                if (fibo1 < numintroducido)
                {
                    texto = texto + fibo1 + ",";
                }
            }
            MessageBox.Show(texto);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
