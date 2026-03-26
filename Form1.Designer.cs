namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Title = new Label();
            txt_Input = new TextBox();
            txt_Result = new TextBox();
            btn_ClearEntry = new Button();
            btn_Clear = new Button();
            btn_Delete = new Button();
            btn_Divide = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_Multiply = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_Subtract = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_Add = new Button();
            btn_Sign = new Button();
            btn_0 = new Button();
            btn_Decimal = new Button();
            btn_Equals = new Button();
            btn_OpenParen = new Button();
            btn_CloseParen = new Button();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("맑은 고딕", 20F);
            lbl_Title.ForeColor = Color.Blue;
            lbl_Title.Location = new Point(117, 31);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(456, 72);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Simple Calculator";
            // 
            // txt_Input
            // 
            txt_Input.Font = new Font("맑은 고딕", 12F);
            txt_Input.Location = new Point(117, 122);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(529, 50);
            txt_Input.TabIndex = 1;
            // 
            // txt_Result
            // 
            txt_Result.Font = new Font("맑은 고딕", 12F);
            txt_Result.Location = new Point(117, 188);
            txt_Result.Name = "txt_Result";
            txt_Result.Size = new Size(529, 50);
            txt_Result.TabIndex = 2;
            // 
            // btn_ClearEntry
            // 
            btn_ClearEntry.Font = new Font("맑은 고딕", 15F);
            btn_ClearEntry.Location = new Point(117, 264);
            btn_ClearEntry.Name = "btn_ClearEntry";
            btn_ClearEntry.Size = new Size(101, 75);
            btn_ClearEntry.TabIndex = 3;
            btn_ClearEntry.Text = "CE";
            btn_ClearEntry.UseVisualStyleBackColor = true;
            btn_ClearEntry.Click += btn_ClearEntry_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("맑은 고딕", 15F);
            btn_Clear.Location = new Point(224, 264);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(101, 75);
            btn_Clear.TabIndex = 3;
            btn_Clear.Text = "C";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("맑은 고딕", 15F);
            btn_Delete.Location = new Point(331, 264);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(101, 75);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "del";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Divide
            // 
            btn_Divide.Font = new Font("맑은 고딕", 15F);
            btn_Divide.ForeColor = Color.Red;
            btn_Divide.Location = new Point(438, 264);
            btn_Divide.Name = "btn_Divide";
            btn_Divide.Size = new Size(101, 75);
            btn_Divide.TabIndex = 3;
            btn_Divide.Text = "÷";
            btn_Divide.UseVisualStyleBackColor = true;
            btn_Divide.Click += btn_Operator_Click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("맑은 고딕", 15F);
            btn_7.Location = new Point(117, 355);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(101, 75);
            btn_7.TabIndex = 3;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_Operand_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("맑은 고딕", 15F);
            btn_8.Location = new Point(224, 355);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(101, 75);
            btn_8.TabIndex = 3;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_Operand_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("맑은 고딕", 15F);
            btn_9.Location = new Point(331, 355);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(101, 75);
            btn_9.TabIndex = 3;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_Operand_Click;
            // 
            // btn_Multiply
            // 
            btn_Multiply.Font = new Font("맑은 고딕", 15F);
            btn_Multiply.ForeColor = Color.Red;
            btn_Multiply.Location = new Point(438, 355);
            btn_Multiply.Name = "btn_Multiply";
            btn_Multiply.Size = new Size(101, 75);
            btn_Multiply.TabIndex = 3;
            btn_Multiply.Text = "X";
            btn_Multiply.UseVisualStyleBackColor = true;
            btn_Multiply.Click += btn_Operator_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("맑은 고딕", 15F);
            btn_4.Location = new Point(117, 445);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(101, 75);
            btn_4.TabIndex = 3;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_Operand_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("맑은 고딕", 15F);
            btn_5.Location = new Point(224, 445);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(101, 75);
            btn_5.TabIndex = 3;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_Operand_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("맑은 고딕", 15F);
            btn_6.Location = new Point(331, 445);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(101, 75);
            btn_6.TabIndex = 3;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_Operand_Click;
            // 
            // btn_Subtract
            // 
            btn_Subtract.Font = new Font("맑은 고딕", 15F);
            btn_Subtract.ForeColor = Color.Red;
            btn_Subtract.Location = new Point(438, 445);
            btn_Subtract.Name = "btn_Subtract";
            btn_Subtract.Size = new Size(101, 75);
            btn_Subtract.TabIndex = 3;
            btn_Subtract.Text = "-";
            btn_Subtract.UseVisualStyleBackColor = true;
            btn_Subtract.Click += btn_Operator_Click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("맑은 고딕", 15F);
            btn_1.Location = new Point(117, 535);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(101, 75);
            btn_1.TabIndex = 3;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_Operand_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("맑은 고딕", 15F);
            btn_2.Location = new Point(224, 535);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(101, 75);
            btn_2.TabIndex = 3;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_Operand_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("맑은 고딕", 15F);
            btn_3.Location = new Point(331, 535);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(101, 75);
            btn_3.TabIndex = 3;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_Operand_Click;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("맑은 고딕", 15F);
            btn_Add.ForeColor = Color.Red;
            btn_Add.Location = new Point(438, 535);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(101, 75);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "+";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Operator_Click;
            // 
            // btn_Sign
            // 
            btn_Sign.Font = new Font("맑은 고딕", 15F);
            btn_Sign.Location = new Point(117, 627);
            btn_Sign.Name = "btn_Sign";
            btn_Sign.Size = new Size(101, 75);
            btn_Sign.TabIndex = 3;
            btn_Sign.Text = "+/-";
            btn_Sign.UseVisualStyleBackColor = true;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("맑은 고딕", 15F);
            btn_0.Location = new Point(224, 627);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(101, 75);
            btn_0.TabIndex = 3;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_Operand_Click;
            // 
            // btn_Decimal
            // 
            btn_Decimal.Font = new Font("맑은 고딕", 15F);
            btn_Decimal.Location = new Point(331, 627);
            btn_Decimal.Name = "btn_Decimal";
            btn_Decimal.Size = new Size(101, 75);
            btn_Decimal.TabIndex = 3;
            btn_Decimal.Text = ".";
            btn_Decimal.UseVisualStyleBackColor = true;
            // 
            // btn_Equals
            // 
            btn_Equals.Font = new Font("맑은 고딕", 15F);
            btn_Equals.Location = new Point(438, 627);
            btn_Equals.Name = "btn_Equals";
            btn_Equals.Size = new Size(101, 75);
            btn_Equals.TabIndex = 3;
            btn_Equals.Text = "=";
            btn_Equals.UseVisualStyleBackColor = true;
            btn_Equals.Click += btn_Result_Click;
            // 
            // btn_OpenParen
            // 
            btn_OpenParen.Font = new Font("맑은 고딕", 15F);
            btn_OpenParen.Location = new Point(545, 264);
            btn_OpenParen.Name = "btn_OpenParen";
            btn_OpenParen.Size = new Size(101, 75);
            btn_OpenParen.TabIndex = 3;
            btn_OpenParen.Text = "(";
            btn_OpenParen.UseVisualStyleBackColor = true;
            btn_OpenParen.Click += btn_Operand_Click;
            // 
            // btn_CloseParen
            // 
            btn_CloseParen.Font = new Font("맑은 고딕", 15F);
            btn_CloseParen.Location = new Point(545, 355);
            btn_CloseParen.Name = "btn_CloseParen";
            btn_CloseParen.Size = new Size(101, 75);
            btn_CloseParen.TabIndex = 3;
            btn_CloseParen.Text = ")";
            btn_CloseParen.UseVisualStyleBackColor = true;
            btn_CloseParen.Click += btn_Operand_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 759);
            Controls.Add(btn_OpenParen);
            Controls.Add(btn_CloseParen);
            Controls.Add(btn_Equals);
            Controls.Add(btn_Decimal);
            Controls.Add(btn_Add);
            Controls.Add(btn_3);
            Controls.Add(btn_Subtract);
            Controls.Add(btn_6);
            Controls.Add(btn_0);
            Controls.Add(btn_Multiply);
            Controls.Add(btn_2);
            Controls.Add(btn_9);
            Controls.Add(btn_5);
            Controls.Add(btn_Sign);
            Controls.Add(btn_Divide);
            Controls.Add(btn_1);
            Controls.Add(btn_8);
            Controls.Add(btn_4);
            Controls.Add(btn_Delete);
            Controls.Add(btn_7);
            Controls.Add(btn_Clear);
            Controls.Add(btn_ClearEntry);
            Controls.Add(txt_Result);
            Controls.Add(txt_Input);
            Controls.Add(lbl_Title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private TextBox txt_Input;
        private TextBox txt_Result;
        private Button btn_ClearEntry;
        private Button btn_Clear;
        private Button btn_Delete;
        private Button btn_Divide;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_Multiply;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_Subtract;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_Add;
        private Button btn_Sign;
        private Button btn_0;
        private Button btn_Decimal;
        private Button btn_Equals;
        private Button btn_OpenParen;
        private Button btn_CloseParen;
    }
}
