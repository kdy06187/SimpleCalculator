namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        TextBox txtInput, txtResult;

        String operand1, operand2;
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
                // 버튼의 텍스트를 텍스트박스에 추가
                txtInput.Text += button.Text;

                // 현재 연산자가 없는 경우 첫 번째 피연산자, 있는 경우 두 번째 피연산자로 저장
                if (currentOperator == null)
                {
                    operand1 += button.Text;
                    txtResult.Text = operand1;
                }
                else
                {
                    operand2 += button.Text;
                    txtResult.Text = operand2;
                }

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
            int n1 = int.Parse(operand1);
            int n2 = int.Parse(operand2);
            // 현재 연산자에 따라 연산 수행
            switch (currentOperator)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "X":
                    result = n1 * n2;
                    break;
                case "÷":
                    if (n2 != 0) result = n1 / n2;
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

        // 초기화 버튼 클릭 시 모든 변수와 텍스트박스 초기화
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // 모든 변수 초기화
            operand1 = "";
            operand2 = "";
            currentOperator = null;
            // 텍스트박스 초기화
            txtInput.Text = "";
            txtResult.Text = "";
        }

        //CE버튼 클릭 시 마지막 피연산자 제거
        private void btn_ClearEntry_Click(object sender, EventArgs e)
        {
            // 현재 연산자가 없는 경우 첫 번째 피연산자, 있는 경우 두 번째 피연산자로 제거
            if (currentOperator == null)
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - operand1.Length);
                txtResult.Text = "";
                operand1 = "";
            }
            else
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - operand2.Length);
                txtResult.Text = "";
                operand2 = "";
            }

        }
        //Delete 버튼 클릭 시 마지막 입력 제거
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                // 텍스트박스에서 마지막 문자 제거
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
                // 현재 연산자가 없는 경우 첫 번째 피연산자, 있는 경우 두 번째 피연산자로 제거
                if (currentOperator == null)
                {
                    operand1 = operand1.Substring(0, operand1.Length - 1);
                    txtResult.Text = operand1;
                }
                else
                {
                    operand2 = operand2.Substring(0, operand2.Length - 1);
                    txtResult.Text = operand2;
                }
            }
        }
    }
}
