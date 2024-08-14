namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(ttb1.Text);
            double numero2 = Convert.ToDouble(ttb2.Text);

            double result = numero1 + numero2;

            MessageBox.Show($"{numero1} + {numero2} = {result}");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(ttb1.Text);
            double numero2 = Convert.ToDouble(ttb2.Text);

            double result = numero1 - numero2;

            MessageBox.Show($"{numero1} - {numero2} = {result}");
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(ttb1.Text);
            double numero2 = Convert.ToDouble(ttb2.Text);

            // Verifica se o segundo número não é zero para evitar divisão por zero
            if (numero2 != 0)
            {
                double resultado = numero1 / numero2;
                MessageBox.Show("Resultado: " + resultado.ToString(), "Resultado da Soma");
            }
            else
            {
                MessageBox.Show("Erro: Divisão por zero!");
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(ttb1.Text);
            double numero2 = Convert.ToDouble(ttb2.Text);

            double result = numero1 * numero2;

            MessageBox.Show($"{numero1} x {numero2} = {result}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
