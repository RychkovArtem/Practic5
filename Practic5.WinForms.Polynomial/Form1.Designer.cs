namespace Practic5.WinFormsPolynomial
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
            label1 = new Label();
            coefficient_1 = new TextBox();
            label2 = new Label();
            coefficient_2 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            label4 = new Label();
            result = new Label();
            label3 = new Label();
            label5 = new Label();
            label_polynomial_1 = new Label();
            label_polynomial_2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 0;
            label1.Text = "Коэфициенты многочлена 1";
            // 
            // coefficient_1
            // 
            coefficient_1.Location = new Point(182, 17);
            coefficient_1.Name = "coefficient_1";
            coefficient_1.Size = new Size(148, 23);
            coefficient_1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 0;
            label2.Text = "Коэфициенты многочлена 2";
            // 
            // coefficient_2
            // 
            coefficient_2.Location = new Point(182, 81);
            coefficient_2.Name = "coefficient_2";
            coefficient_2.Size = new Size(148, 23);
            coefficient_2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Location = new Point(12, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 130);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите операцию";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 19);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Сложение";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 19);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Вычитание";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(90, 19);
            radioButton3.TabIndex = 19;
            radioButton3.TabStop = true;
            radioButton3.Text = "Умножение";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 97);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(72, 19);
            radioButton4.TabIndex = 20;
            radioButton4.TabStop = true;
            radioButton4.Text = "Деление";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(128, 284);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 19;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 324);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 20;
            label4.Text = "Результат:";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(78, 324);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 52);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 22;
            label3.Text = "Многочлен 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 120);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 22;
            label5.Text = "Многочлен 2";
            // 
            // label_polynomial_1
            // 
            label_polynomial_1.AutoSize = true;
            label_polynomial_1.Location = new Point(182, 52);
            label_polynomial_1.Name = "label_polynomial_1";
            label_polynomial_1.Size = new Size(0, 15);
            label_polynomial_1.TabIndex = 22;
            // 
            // label_polynomial_2
            // 
            label_polynomial_2.AutoSize = true;
            label_polynomial_2.Location = new Point(182, 120);
            label_polynomial_2.Name = "label_polynomial_2";
            label_polynomial_2.Size = new Size(0, 15);
            label_polynomial_2.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 363);
            Controls.Add(label_polynomial_2);
            Controls.Add(label5);
            Controls.Add(label_polynomial_1);
            Controls.Add(label3);
            Controls.Add(result);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(coefficient_2);
            Controls.Add(coefficient_1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox coefficient_1;
        private Label label2;
        private TextBox coefficient_2;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private Label label4;
        private Label result;
        private Label label3;
        private Label label5;
        private Label label_polynomial_1;
        private Label label_polynomial_2;
    }
}
