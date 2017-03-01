using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace torres_de_hanoi
{
    public partial class Form1 : Form
    {
        void hanoi(int numdisc, string origen, string destino,string auxiliar, ref string texto)
        {
            if (numdisc>0)
            {
                hanoi(numdisc - 1, origen, auxiliar, destino, ref texto);
                texto = texto + "Muevo el disco " + numdisc + " de " + origen + " a "  + destino + "\n";
                hanoi(numdisc - 1, auxiliar, destino, origen, ref texto);
            }
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numdisc = int.Parse(textBox1.Text);
            string texto = "";

            hanoi(numdisc, "origen", "destino", "auxiliar", ref texto);
            label1.Text = texto;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
