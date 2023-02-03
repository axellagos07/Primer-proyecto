using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal Total = 0;
        decimal Signo = 0;

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            decimal numero = Convert.ToDecimal(NumerotextBox.Text);
            Total = ParoImpar(numero);
            Signo = SignoNumero(numero);

        }

        private decimal SignoNumero(decimal num)
        {
            decimal n1;
            n1 = num;

            if (n1 == 0)
            {
                
                Signolabel.Text = ("El Numero "+ num +" cero");
            }
            else if (n1 >= 1)
            {  
                Signolabel.Text = ("El Número "+ num + " es positivo");
            }
            else if (n1 <= -1)
            {
                Signolabel.Text = ("El Número "+ num +" Negativo");
                
            }


            return n1;
        }

        private decimal ParoImpar(decimal num)
        {
            decimal n1;
            n1 = num;

            
            if ((n1 % 2) == 0)
            {
                ParoImparlabel.Text = ("El numero "+ num + " es par");
            }
            else
            {
                ParoImparlabel.Text = ("El numero " + num + " es Impar");
            }

            return n1;

        }
    }
}
