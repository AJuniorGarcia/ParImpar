using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAR_IMPAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verificarbutton1_Click(object sender, EventArgs e)
        {
            if (numerotextBox1.Text == "")
            {
                errorProvider1.SetError(numerotextBox1, "Ingrese un valor");
                return; 
            }
            errorProvider1.Clear();
           decimal numero = Convert.ToDecimal(numerotextBox1.Text);
            PosiNegv(numero);//funcion para verificar si es  Positivo o negativo
            ParImpar(numero);//funcion para verificar par o impar
        }
        private void PosiNegv(decimal numero)
        {
            if (numero > 0)
            {
                label3.Text = "El  número es positivo";
            }
            else if (numero < 0)
            {
                label3.Text = "El  número es negativo";
            }
            else
            {
                label3.Text = "El  número es cero";
            }
        }
        private void ParImpar(decimal numero)
        {
            if (numero % 2 == 0)
            {
                label2.Text = "El número es par";
            }
            else
            {
                label2.Text = "El número es impar";
            }

        }

    }
}
