namespace Bhaskara2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBt_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Digite o valor de a: ");
            //int a = Convert.ToInt32(Console.ReadLine()); 
            int a = Convert.ToInt32(aTb.Text);

            //Console.WriteLine("Digite o valor de b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(bTb.Text);

            //Console.WriteLine("Digite o valor de c: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(cTb.Text);

            double delta = b * b - 4 * a * c;

            double a1 = 0;
            double a2 = 0;

            if (delta < 0)
                //Console.WriteLine("Não existem raízes reais.");
                msgLb.Text = "Não existem raízes reais.";
            else if (delta > 0)
            {
                //Console.WriteLine("Existem duas raízes reais.");
                msgLb.Text = "Existem duas raízes reais.";
                a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                a2 = (-b - Math.Sqrt(delta)) / (2 * a);

                //Console.WriteLine($"O valor de delta é: {delta}");
                deltaLb.Text = Convert.ToString(delta);
            }
            else
            {
                //Console.WriteLine("Existe uma raiz real.");
                msgLb.Text = "Existe uma raiz real.";
                a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                a2 = a1;

                //Console.WriteLine($"O valor de delta é: {delta}");
                deltaLb.Text = Convert.ToString(delta);
            }

            //Console.WriteLine($"O valor de a1 é: {a1}");
            //Console.WriteLine($"O valor de a2 é: {a2}");
            a1Lb.Text = Convert.ToString(a1);
            a2Lb.Text = Convert.ToString(a2);
        }
    }
}