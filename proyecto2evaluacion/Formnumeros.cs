using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fibonacci.Formfibonacci oFibo = new Fibonacci.Formfibonacci();
            oFibo.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Primos.Formprimos oPrimos = new Primos.Formprimos();
            oPrimos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
