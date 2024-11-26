namespace Practic5.WinForms
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
            x_coordinate_1 = new TextBox();
            y_coordinate_1 = new TextBox();
            z_coordinate_1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            result = new Label();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label5 = new Label();
            x_coordinate_2 = new TextBox();
            y_coordinate_2 = new TextBox();
            z_coordinate_2 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            scalar = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // x_coordinate_1
            // 
            x_coordinate_1.Location = new Point(72, 31);
            x_coordinate_1.Name = "x_coordinate_1";
            x_coordinate_1.Size = new Size(93, 23);
            x_coordinate_1.TabIndex = 0;
            // 
            // y_coordinate_1
            // 
            y_coordinate_1.Location = new Point(171, 31);
            y_coordinate_1.Name = "y_coordinate_1";
            y_coordinate_1.Size = new Size(93, 23);
            y_coordinate_1.TabIndex = 1;
            // 
            // z_coordinate_1
            // 
            z_coordinate_1.Location = new Point(270, 31);
            z_coordinate_1.Name = "z_coordinate_1";
            z_coordinate_1.Size = new Size(93, 23);
            z_coordinate_1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 3;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 9);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 9);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 5;
            label3.Text = "Z";
            // 
            // button1
            // 
            button1.Location = new Point(151, 360);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 6;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(78, 385);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 15;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Location = new Point(12, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 205);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите операцию";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 172);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(154, 19);
            radioButton7.TabIndex = 23;
            radioButton7.TabStop = true;
            radioButton7.Text = "Нормализация вектора";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 147);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(106, 19);
            radioButton6.TabIndex = 22;
            radioButton6.TabStop = true;
            radioButton6.Text = "Длина вектора";
            radioButton6.UseVisualStyleBackColor = true;
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
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 122);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(163, 19);
            radioButton5.TabIndex = 21;
            radioButton5.TabStop = true;
            radioButton5.Text = "Векторное произведение";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(147, 19);
            radioButton3.TabIndex = 19;
            radioButton3.TabStop = true;
            radioButton3.Text = "Умножение на скаляр";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 97);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(165, 19);
            radioButton4.TabIndex = 20;
            radioButton4.TabStop = true;
            radioButton4.Text = "Скалярное произведение";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 34);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 18;
            label5.Text = "Вектор 1\r\n";
            // 
            // x_coordinate_2
            // 
            x_coordinate_2.Location = new Point(72, 69);
            x_coordinate_2.Name = "x_coordinate_2";
            x_coordinate_2.Size = new Size(93, 23);
            x_coordinate_2.TabIndex = 19;
            // 
            // y_coordinate_2
            // 
            y_coordinate_2.Location = new Point(171, 69);
            y_coordinate_2.Name = "y_coordinate_2";
            y_coordinate_2.Size = new Size(93, 23);
            y_coordinate_2.TabIndex = 19;
            // 
            // z_coordinate_2
            // 
            z_coordinate_2.Location = new Point(270, 69);
            z_coordinate_2.Name = "z_coordinate_2";
            z_coordinate_2.Size = new Size(93, 23);
            z_coordinate_2.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 72);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 18;
            label6.Text = "Вектор 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 385);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 15;
            label4.Text = "Результат";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 112);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 18;
            label7.Text = "Скаляр";
            // 
            // scalar
            // 
            scalar.Location = new Point(72, 109);
            scalar.Name = "scalar";
            scalar.Size = new Size(93, 23);
            scalar.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 450);
            Controls.Add(z_coordinate_2);
            Controls.Add(y_coordinate_2);
            Controls.Add(scalar);
            Controls.Add(x_coordinate_2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(result);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(z_coordinate_1);
            Controls.Add(y_coordinate_1);
            Controls.Add(x_coordinate_1);
            Name = "Form1";
            Text = "Векторный калькулятор";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox x_coordinate_1;
        private TextBox y_coordinate_1;
        private TextBox z_coordinate_1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label result;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton2;
        private RadioButton radioButton5;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label5;
        private TextBox x_coordinate_2;
        private TextBox y_coordinate_2;
        private TextBox z_coordinate_2;
        private Label label6;
        private Label label4;
        private Label label7;
        private TextBox scalar;
    }
}
