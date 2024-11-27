using System.Linq;

namespace Practic5.WinFormsPolynomial
{
    public partial class Form1 : Form
    {
        private TextBox[] textBox;
        private RadioButton[] radioButton;
        public Form1()
        {
            InitializeComponent();

            textBox = new TextBox[] { coefficient_1, coefficient_2 };
            radioButton = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string coefficient_string_1 = coefficient_1.Text;
            string coefficient_string_2 = coefficient_2.Text;
            char[] separators = new char[] { ' ', ',', ';', ':' };
            string[] parts_coefficient_string_1 = coefficient_string_1.Split(separators);
            double[] coefficient_double_1 = new double[parts_coefficient_string_1.Length];
            string[] parts_coefficient_string_2 = coefficient_string_2.Split(separators);
            double[] coefficient_double_2 = new double[parts_coefficient_string_2.Length];
            //string[] coefficient_string_2 = new string[] { coefficient_2.Text };
            //double[] coefficient_double_1 = new double[coefficient_string_1.Length];
            //double[] coefficient_double_2 = new double[coefficient_string_2.Length];
            //int true_coordinate = 0;
            //double Vector_to_scalar;
            //double dot_product;
            //double lenght_vector_1;
            //double lenght_vector_2;
            //string V1_Normalize_string;
            //string V2_Normalize_string;


            for (int i = 0; i < parts_coefficient_string_1.Length; i++)
            {
                if (double.TryParse(parts_coefficient_string_1[i], out coefficient_double_1[i]))
                {
                    //        true_coordinate++;
                }
                else
                {
                    textBox[0].Text = "Неверный ввод";
                }
            }

            for (int i = 0; i < parts_coefficient_string_2.Length; i++)
            {
                if (double.TryParse(parts_coefficient_string_2[i], out coefficient_double_2[i]))
                {
                    //        true_coordinate++;
                }
                else
                {
                    textBox[1].Text = "Неверный ввод";
                }
            }

            Polynomial P1 = new Polynomial(coefficient_double_1);
            Polynomial P2 = new Polynomial(coefficient_double_2);
            label_polynomial_1.Text = P1.ToString();
            label_polynomial_2.Text = P2.ToString();

            //if (true_coordinate == 6)
            //{
            //    Polynomial P1 = new Polynomial(coefficient_string);
            //    Vector3 V2 = new Vector3(coordinate[3], coordinate[4], coordinate[5]);

            switch (GetSelectedOption())
            {
                case "Option1":
                    Polynomial P3 = P1 + P2;
                    result.Text = P3.ToString();
                    break;
                case "Option2":
                    Polynomial P4 = P1 - P2;
                    result.Text = P4.ToString();
                    break;
                case "Option3":
                    Polynomial P5 = P1 * P2;
                    result.Text = P5.ToString();
                    break;
                case "Option4":
                    Polynomial P6 = P1 / P2;
                    result.Text = P6.ToString();
                    break;
                default:
                    MessageBox.Show("Пожалуйста, выберите опцию");
                    break;
            }
        }
        private string GetSelectedOption()
        {
            // Проверяем, какая радиокнопка выбрана
            if (radioButton1.Checked)
            {
                return "Option1";
            }
            else if (radioButton2.Checked)
            {
                return "Option2";
            }
            else if (radioButton3.Checked)
            {
                return "Option3";
            }
            else if (radioButton4.Checked)
            {
                return "Option4";
            }
            return null; // Если ничего не выбрано
        }
    }
}
