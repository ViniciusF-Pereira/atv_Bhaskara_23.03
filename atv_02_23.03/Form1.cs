namespace atv_02_23._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int.TryParse(txtValor3.Text, out var ValorCpositivo);

            if ( ValorCpositivo > 0)
            {
                lblValor1.Text = "(" + txtValor1.Text + "x²)+(" + txtValor2.Text + "x)" + "+" + txtValor3.Text +"= 0";
            }
            else
            {
                lblValor1.Text = "(" + txtValor1.Text + "x)²+(" + txtValor2.Text + "x)" + txtValor3.Text + "= 0";

            }


           
            int.TryParse(txtValor1.Text, out var valor1);

            if ( valor1 != 0 )
            {
                int.TryParse(txtValor1.Text, out var valorA);
                int.TryParse(txtValor2.Text, out var valorB);
                int.TryParse(txtValor3.Text, out var valorC);

                int delta = (valorB * valorB) - (4 * valorA * valorC);

                if (delta < 0)
                {

                    MessageBox.Show("O valor de delta é " + delta + ", ou seja negativo, portando as raizes não podem ser calcualdas !", "Erro!");
                }
                else {

                    float Resultado = (((valorB *(-1))) + Convert.ToSingle(Math.Sqrt(delta)))/ (2*valorA);
                    float Resultado2 = (((valorB * (-1))) - Convert.ToSingle(Math.Sqrt(delta))) / (2 * valorA);



                    lblResultado.Text = "X¹ = " + Resultado.ToString() + " e X² = " + Resultado2.ToString() ;
                }


                lblEquacao.Text = "X =  - (" + valorB + ") ± √ (" + valorB + "²) - " + "4 * [(" + valorA + ") * (" + valorC + ")]";
                lblB.Text = "                 2 * (" + valorA + ")";
            }
            else
            {
                MessageBox.Show("Preencha o campo A com um valor diferente de 0!", "Erro!");
                return;


            }



        }

        private void lblValor1_Click(object sender, EventArgs e)
        {

        }

        private void lblEquacao_Click(object sender, EventArgs e)
        {

        }
    }
}