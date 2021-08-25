using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2_Ejemplo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Evento de ingreso de datos al arreglo
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lsbArreglo.Items.Add(txtnumero.Text);
            txtnumero.Clear();
            txtnumero.Focus();
        }
        //Evento calcular al mayor de los pares negativos
        private void btnmostrar1_Click(object sender, EventArgs e)
        {
            int maynegativo = -1000;
            for (int i = 0; i < lsbArreglo.Items.Count; i++){
                string valor = lsbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero < 0 && numero % 2 == 0)
                {
                    if (numero > maynegativo)
                    {
                        maynegativo = numero;
                        txtnegativo.Text = maynegativo.ToString();
                    }
                }
                else
                {
                    txtnegativo.Text = "No hay números negativos pares";
                }
            }
        }
        //Evento calcular procentaje de ceros
        private void btnmostrar2_Click(object sender, EventArgs e)
        {
            double cantidadnumeros = lsbArreglo.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;
            for (int i = 0; i<lsbArreglo.Items.Count; i++)
            {
                string valor = lsbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if(numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            txtprocentaje.Text = porcentaje.ToString() + "%";

        }
        //Evento calcular promedio de impares positivos
        private void btnmostrar3_Click(object sender, EventArgs e)
        {
            double prom;
            double cantidadimpares=0;
            double suma = 0;
            for(int i =0; i< lsbArreglo.Items.Count; i++)
            {
                string valor = lsbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if(numero > 0 && numero %2 != 0)
                {
                    suma = suma + numero;
                    cantidadimpares = cantidadimpares + 1;
                }
            }
            prom = suma / cantidadimpares;
            txtpositivos.Text = prom.ToString();
        }

        private void btnmostrar4_Click(object sender, EventArgs e)
        {
            int mayor = 0;
            for(int i = 0; i < lsbArreglo.Items.Count; i++)
            {
                string valor = lsbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if(numero > 0 && numero % 2 == 0)
                {
                    if(numero > mayor)
                    {
                        mayor = numero;
                    }
                }
            }
            txtmayoposi.Text = mayor.ToString();
        }
    }
}
