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
       
        string textFibo(int num1)
        {
            
            int  fibo1, fibo2, fibo3;
            string texto;
            texto = "Estos son los números fibonacci hasta el número introducido: ";

            fibo1 = 0;
            texto = texto + fibo1 + ",";
            fibo2 = 1;

          
            
            for (int i = 0; fibo1 < num1; i++)
            {
                fibo3 = fibo1;
                fibo1 = fibo1 + fibo2;
                fibo2 = fibo3;
                if (fibo1 < num1)
                {
                    texto = texto + fibo1 + ",";
                }
            }
            return texto;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Formfibonacci_Load(object sender, EventArgs e)
        {

        }

        private void bFibo(object sender, EventArgs e)
        {
            int num = int.Parse(Tfibo.Text);
            MessageBox.Show(textFibo(num));
        }
    }
}
