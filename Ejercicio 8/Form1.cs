using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numerosSorteo = new List<int>();
        List<int> numerosUsuario = new List<int>();
        private void bNumeroAleatorio_Click(object sender, EventArgs e)
        {
            numerosSorteo.Clear();         
            while (numerosSorteo.Count < 6)
            {
                int numeroAleatorio = new Random().Next(1, 50);
                if (!numerosSorteo.Contains(numeroAleatorio))
                {
                    numerosSorteo.Add(numeroAleatorio);
                }
            }
            MessageBox.Show("Los numeros aleatorios han sido generados");

        }

        private void bIngresarNumeros_Click(object sender, EventArgs e)
        {
            numerosUsuario.Clear();
            int numero;

            while (numerosUsuario.Count < 6)
            {

                numero = int.Parse(Interaction.InputBox("Introduce un numero"));
                if (numero > 0 && numero < 50)
                {
                    if (!numerosUsuario.Contains(numero))
                    {
                        numerosUsuario.Add(numero);
                    }
                    else MessageBox.Show("El numero ya ha sido introducido, prueba otro");
                }
                else
                {
                    MessageBox.Show("El numero introducido no es valido, prueba otro");
                }


            }


        }

        private void bNumerosAcertados_Click(object sender, EventArgs e)
        {
            string texto; int numero; //int numero2;
            texto = mostrarlistasnumeros(numerosSorteo, numerosUsuario);
            MessageBox.Show(texto);

            //Este es facilitado en la corrección
            //numero2 = numerosAcertados2(numerosSorteo, numerosUsuario);
            //MessageBox.Show("Los numeros acertados por el usuario en el sorteo han sido de: " + numero2);

            //Aparte del que me facilitaste, para no hacer lo mismo he implementado otro nuevo que creo que es lo que me pedia el ejercicio
            numero = numerosAcertadosSorteo(numerosSorteo, numerosUsuario);
            MessageBox.Show("Los numeros acertados por el usuario en el sorteo han sido de: " + numero);
            
            
        }

        private string mostrarlistasnumeros(List<int> numeroSorteo, List<int> numeroUsuario)
        {
            string texto = "";

            for (int i = 0; i < numeroSorteo.Count; i++)
            {
                texto = "La lista de los aleatorios son :  " + montarlista(numeroSorteo) + "\n";
                texto = texto + "La lista de los usuario son: " + montarlista(numeroUsuario);
            }

            return texto;
        }

        private string montarlista(List<int> lista)
        {
            string texto = "";
            for (int i = 0; i < lista.Count; i++)
            {
                texto = texto + lista[i] + ",";

            }

            return texto;
        }

        public int numerosAcertadosSorteo(List<int> numeroSorteo, List<int> numeroUsuario)
        {
            int numerosAcertados = 0;
            int j = 0;
            
            for(int i = 0; i < numeroSorteo.Count; i++)
            {
                while(j < numeroSorteo.Count)
                {
                    if (numeroUsuario[i] == numeroSorteo[j])
                    {
                        numerosAcertados++;
                    }
                    j++;
                }
                j = 0;
            }
            return numerosAcertados;
        } 

        private int numerosAcertados2(List<int> numeroSorteo, List<int> numeroUsuario)
        {
            int cont = 0;

            for (int i = 0; i < numerosSorteo.Count; i++)
            {
                if (numerosUsuario.Contains(numerosSorteo[i]))
                {
                    cont++;
                }
            }

            return cont;
        }
    }

}
