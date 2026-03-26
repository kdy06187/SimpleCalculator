using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        TextBox txtInput, txtResult;
        bool isCalculated = false;

        public Form1()
        {
            InitializeComponent();
            txtInput = txt_Input;
            txtResult = txt_Result;
        }

        private void btn_Operand_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (isCalculated)
                {
                    txtInput.Text = "";
                    txtResult.Text = "";
                    isCalculated = false;
                }
                txtInput.Text += button.Text;
            }
        }

        private void btn_Operator_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && txtInput.Text.Length > 0)
            {
                if (isCalculated)
                {
                    txtInput.Text = txtResult.Text;
                    isCalculated = false;
                }

                // 기호 변경 로직 (마지막 글자가 연산자일 때)
                string lastChar = txtInput.Text.Substring(txtInput.Text.Length - 1);
                if (lastChar == "+" || lastChar == "-" || lastChar == "X" || lastChar == "÷")
                {
                    txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
                }

                txtInput.Text += button.Text;
            }
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length == 0) return;

            try
            {
                DataTable dt = new DataTable();

                // 1. 표기용 수식(X, ÷)을 계산용 수식(*, /)으로 변환
                string expression = txtInput.Text.Replace("X", "*").Replace("÷", "/");

                // 2. 숫자와 여는 괄호 사이, 또는 닫는 괄호와 숫자 사이에 생략된 '*' 기호 추가
                // 예: "2(9+3)" -> "2*(9+3)", "(9+3)2" -> "(9+3)*2"
                expression = Regex.Replace(expression, @"(\d)(\()", "$1*$2");
                expression = Regex.Replace(expression, @"(\))(\d)", "$1*$2");
                // 예: ")(" -> ")*(" 
                expression = Regex.Replace(expression, @"(\))(\()", "$1*$2");

                var result = dt.Compute(expression, "");

                txtResult.Text = result.ToString();

                // 식 창 (txtInput)에 원래 식과 결과를 = 로 표현 (예: 1+2+3=6)
                if (!txtInput.Text.Contains("="))
                {
                    txtInput.Text += "=" + result.ToString();
                }

                isCalculated = true;
            }
            catch
            {
                MessageBox.Show("수식이 잘못되었습니다.");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtResult.Text = "";
            isCalculated = false;
        }

        private void btn_ClearEntry_Click(object sender, EventArgs e)
        {
            // 간단한 처리: 마지막 연산자 이후 숫자를 지움
            if (isCalculated)
            {
                btn_Clear_Click(null, null);
                return;
            }

            int lastOpIndex = txtInput.Text.LastIndexOfAny(new char[] { '+', '-', 'X', '÷', '(', ')' });
            if (lastOpIndex != -1)
            {
                txtInput.Text = txtInput.Text.Substring(0, lastOpIndex + 1);
            }
            else
            {
                txtInput.Text = "";
            }
            txtResult.Text = "0";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (isCalculated) return;

            if (txtInput.Text.Length > 0)
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
            }
        }
    }
}
