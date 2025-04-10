namespace ScientificCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxOperation.SelectedIndex = 0;
        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOperation.SelectedIndex == 0)
            {
                labelBasicSign.Text = "+";
            }
            if (comboBoxOperation.SelectedIndex == 1)
            {
                labelBasicSign.Text = "-";
            }
            if (comboBoxOperation.SelectedIndex == 2)
            {
                labelBasicSign.Text = "*";
            }
            if (comboBoxOperation.SelectedIndex == 3)
            {
                labelBasicSign.Text = "/";
            }
        }

        private void buttonCalculateBasic_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxNumber1.Text);
                double b = double.Parse(textBoxNumber2.Text);
                string operation = comboBoxOperation.Text;

                double result = 0;
                Calculator calculator = new Calculator();

                if (operation == "Сложение")
                {
                    result = calculator.Add(a, b);
                }
                else if (operation == "Вычитание")
                {
                    result = calculator.Subtract(a, b);
                }
                else if (operation == "Умножение")
                {
                    result = calculator.Multiply(a, b);
                }
                else if (operation == "Деление")
                {
                    result = calculator.Divide(a, b);
                }
                else
                {
                    labelResultBasic.Text = "Unknown operation.";
                    return;
                }

                labelResultBasic.Text = result.ToString();
            }
            catch (Exception ex)
            {
                labelResultBasic.Text = "Ошибка: " + ex.Message;
            }
        }

        private void buttonSolveEquation_Click(object sender, EventArgs e)
        {
            try
            {
                var calculator = new Calculator();
                double result = calculator.SolveEquation(textBoxEquation.Text);
                labelResultEquation.Text = result.ToString();
            }
            catch (Exception ex)
            {
                labelResultEquation.Text = "Ошибка: " + ex.Message;
            }
        }

        private void buttonSolveIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxEdge1.Text);
                double b = double.Parse(textBoxEdge2.Text);
                var calculator = new Calculator();
                double result = calculator.Integrate(textBoxIntegral.Text, a, b);
                labelResultIntegral.Text = result.ToString();
            }
            catch (Exception ex)
            {
                labelResultIntegral.Text = "Ошибка: " + ex.Message;
            }
        }
    }
}
