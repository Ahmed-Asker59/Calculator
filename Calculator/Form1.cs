namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = string.Empty;
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
        }

        private void button_click(object sender, EventArgs e)
        {

            if (textBox_Result.Text == "0" || isOperationPerformed)
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;

            }
            else
                textBox_Result.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                EqualButton.PerformClick();
                operationPerformed = button.Text;           
                LabelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                LabelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            LabelCurrentOperation.Text = string.Empty;
            resultValue = 0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
            }

            resultValue = Double.Parse(textBox_Result.Text);
            LabelCurrentOperation.Text = string.Empty;
        }
    }
}