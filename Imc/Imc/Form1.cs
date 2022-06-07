using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularBt_Click(object sender, EventArgs e)
        {
            double altura = 0, peso = 0, imc = 0; // altura, peso, imc: real

            peso = Convert.ToDouble(pesoTb.Text);
            altura = Convert.ToDouble(alturaTb.Text);

            imc = peso / (altura * altura); // imc:= peso / (altura * altura)

            imcLb.Text = Convert.ToString(imc);

            if (imc <= 18.5)
            {
                msgLb.Text = "Você está abaixo do peso";
            } else if (imc <= 24.9)
            {
                msgLb.Text = "Você está no peso ideal";
            } else if (imc <= 29.9)
            {
                msgLb.Text = "Você está levemente acima do peso";
            } else if (imc <= 34.9)
            {
                msgLb.Text = "Você tem obesidade de grau 1";
            } else if (imc <= 39.9)
            {
                msgLb.Text = "Você tem obesidade de grau 2";
            } else
            {
                msgLb.Text = "Você tem obesidade de grau 3";
            }
        }
    }
}
