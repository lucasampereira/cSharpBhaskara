using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void somarBt_Click(object sender, EventArgs e)
        {
            double n1, n2, result;
            n1 = Convert.ToDouble(n1Tb.Text);
            n2 = Convert.ToDouble(n2Tb.Text);
            result = n1 + n2;
            saidaLb.Text = Convert.ToString(result);
        }

        private void subtrairBt_Click(object sender, EventArgs e)
        {
            double n1, n2, result;
            n1 = Convert.ToDouble(n1Tb.Text);
            n2 = Convert.ToDouble(n2Tb.Text);
            result = n1 - n2;
            saidaLb.Text = Convert.ToString(result);
        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            n1Tb.Text = "";
            n2Tb.Text = "";
        }

        private void raizBt_Click(object sender, EventArgs e)
        {
            double n1;
            n1 = Convert.ToDouble(n1Tb.Text);
            saidaLb.Text = Convert.ToString(Math.Sqrt(n1));            
        }
    }
}
