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

namespace ejercicio9
{
    
    public partial class Form1 : Form
    {
        ArrayList primitiva = new ArrayList();
        ArrayList jugar = new ArrayList();

        const int Kprimitiva = 6;

        Random rndloteria = new Random();

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
        public Form1()
        {
            InitializeComponent();
        }
        bool comprobarrepe(ArrayList lista, int num)
        {
            int i = 0;
            bool encontrado = false;
            while(i < Kprimitiva && encontrado == false)
            {
                
                if (lista.Contains(num))
                {
                    encontrado = true;
                    MessageBox.Show("Inserte un número que no este repetido");
                }
                else
                {           
                    i++;
                }
            }
            return encontrado;

        }
        void rellenearprimitiva(ArrayList lista)
        {
            
            int i = 0;
            while (i < Kprimitiva)
            {
                int num = int.Parse(InputBox("Introduzca número: "));
                if (num < 50 && num > 0)
                {
                
                    if (comprobarrepe(lista, num))
                    {
                        MessageBox.Show("esta repetido");
                    }
                    else
                    {
                        lista.Add(num);
                        i++;
                    }

                }
                else
                {
                    MessageBox.Show("El número tiene que estar entre 1 y 49");
                }
                

            }
        }
        void rellenarpremiado(ArrayList lista)
        {
            
            int i = 0;
            while (i < Kprimitiva)
            {
                int num = rndloteria.Next(49);
                if (comprobarrepe(lista, num))
                {
                    MessageBox.Show("esta repetido");
                }
                else
                {
                    lista.Add(num);
                    i++;
                }


            }
        }

        string loteria(ArrayList primitiva, ArrayList jugar)
        {
            string texto = "has acertado: \n ";
            int cont = 0;
            for (int i = 0; i < primitiva.Count; i++)
            {
                if (primitiva.Contains(jugar[i]))
                {
                    cont++;
                    texto = texto + primitiva[i] + ",";
                }
            }
            if (cont == 0)
            {
                texto = "No has acertado ninguno";
            }
            if (cont == 6)
            {
                texto = "Has acertado todas YOU WIN!!!";
            }
            return texto;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
            rellenarpremiado(jugar);
            string texto = loteria(primitiva, jugar);
            MessageBox.Show(texto);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            rellenearprimitiva(primitiva);
            
        }
    }
}
