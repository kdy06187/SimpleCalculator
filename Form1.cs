namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        TextBox txtInput,txtResult;

        int operand1, operand2;
        String currentOperator;
        public Form1()
        {
            InitializeComponent();
            // 텍스트박스 참조 저장
            txtInput = txt_Input;
            txtResult = txt_Result;
        }

        // 숫자 버튼 클릭 시 텍스트박스에 숫자 추가
        private void btn_Operand_Click(object sender, EventArgs e)
        {
            // 클릭한 버튼 객체
            Button button = sender as Button;
            // 버튼이 null이 아닌 경우에만 텍스트 추가
            if (button != null)
            {
                // 현재 연산자가 없는 경우 첫 번째 피연산자, 있는 경우 두 번째 피연산자로 저장
                if (currentOperator == null)
                {
                    operand1 = int.Parse(button.Text);
                }
                else
                {
                    operand2 = int.Parse(button.Text);
                }
                // 버튼의 텍스트를 텍스트박스에 추가
                txtInput.Text += button.Text;
                txtResult.Text = button.Text;
            }
        }

        // 연산자 버튼 클릭 시 현재 연산자 저장
        private void btn_Operator_Click(object sender, EventArgs e)
        {
            // 클릭한 버튼 객체
            Button button = sender as Button;
            // 버튼이 null이 아닌 경우에만 텍스트 추가
            if (button != null)
            {
                currentOperator = button.Text;
                // 버튼의 텍스트를 텍스트박스에 추가
                txtInput.Text += button.Text;
            }
        }
        // 결과 버튼 클릭 시 연산 수행
        private void btn_Result_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                txtInput.Text += button.Text;
            }
            int result;
            // 현재 연산자에 따라 연산 수행
            switch (currentOperator)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "X":
                    result = operand1 * operand2;
                    break;
                case "%":
                    if (operand2 != 0) result = operand1 / operand2;
                    else
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("유효한 연산자가 아닙니다.");
                    return;
            }
            // 결과를 텍스트박스에 표시
            txtInput.Text += result.ToString();
            txtResult.Text = result.ToString();
        }
    }
}
