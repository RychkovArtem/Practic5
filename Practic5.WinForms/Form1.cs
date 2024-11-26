using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using static System.Windows.Forms.Design.AxImporter;

namespace Practic5.WinForms
{
    public partial class Form1 : Form
    {
        private TextBox[] textBox;
        private RadioButton[] radioButton;

        public Form1()
        {
            InitializeComponent();

            textBox = new TextBox[] { x_coordinate_1, y_coordinate_1, z_coordinate_1, x_coordinate_2, y_coordinate_2, z_coordinate_2 };
            radioButton = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6, radioButton7 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] coordinate_string = new string[] { x_coordinate_1.Text, y_coordinate_1.Text, z_coordinate_1.Text, x_coordinate_2.Text, y_coordinate_2.Text, z_coordinate_2.Text };
            double[] coordinate = new double[coordinate_string.Length];
            int true_coordinate = 0;
            double Vector_to_scalar;
            double dot_product;
            double lenght_vector_1;
            double lenght_vector_2;
            string V1_Normalize_string;
            string V2_Normalize_string;


            for (int i = 0; i < coordinate_string.Length; i++)
            {
                if (double.TryParse(coordinate_string[i], out coordinate[i]))
                {
                    true_coordinate++;
                }
                else
                {
                    textBox[i].Text = "Неверный ввод";
                }
            }

            if (true_coordinate == 6)
            {
                Vector3 V1 = new Vector3(coordinate[0], coordinate[1], coordinate[2]);
                Vector3 V2 = new Vector3(coordinate[3], coordinate[4], coordinate[5]);

                switch (GetSelectedOption())
                {
                    case "Option1":
                        Vector3 V3 = V1 + V2;
                        result.Text = $"Вектор суммы {V3.ToString()}";
                        break;
                    case "Option2":
                        Vector3 V4 = V1 - V2;
                        result.Text = $"Вектор разницы {V4.ToString()}";
                        break;
                    case "Option3":
                        if (double.TryParse(scalar.Text, out Vector_to_scalar))
                        {
                            Vector3 V5 = V1 * Vector_to_scalar;
                            Vector3 V6 = V2 * Vector_to_scalar;
                            result.Text = $"Вектор 1 {V5.ToString()}\nВектор 2 {V6.ToString()}";
                        }
                        else
                        {
                            scalar.Text = "Неверный ввод";
                        }
                        break;
                    case "Option4":
                        dot_product = V1 * V2;
                        result.Text = $"Cкаляр = {dot_product}";
                        break;
                    case "Option5":
                        Vector3 V7 = V1.Cross(V2);
                        result.Text = $"Вектор произведения {V7.ToString()}";
                        break;
                    case "Option6":
                        lenght_vector_1 = V1.Lenght();
                        lenght_vector_2 = V2.Lenght();
                        result.Text = $"Длина вектора 1 = {lenght_vector_1}\nДлина вектора 2 = {lenght_vector_2}";
                        break;
                    case "Option7":
                        Vector3 V1_Normalize = V1.Normalize();
                        Vector3 V2_Normalize = V2.Normalize();
                        V1_Normalize_string = V1_Normalize.ToString();
                        V2_Normalize_string = V2_Normalize.ToString();
                        result.Text = $"Нормализованный вектор 1 = {V1_Normalize_string}\nНормализованный вектор 2 = {V2_Normalize_string}";
                        break;
                    default:
                        MessageBox.Show("Пожалуйста, выберите опцию");
                        break;
                }
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
            else if (radioButton5.Checked)
            {
                return "Option5";
            }
            else if (radioButton6.Checked)
            {
                return "Option6";
            }
            else if (radioButton7.Checked)
            {
                return "Option7";
            }
            return null; // Если ничего не выбрано
        }
    }
}
