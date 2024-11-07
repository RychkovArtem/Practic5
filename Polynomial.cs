using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Practic5
{
    public class Polynomial
    {
        public double[] _coefficients { get; set; }
        public double[] _exp { get; set; }
        public Polynomial(double [] coefficients)
        {
            _coefficients = coefficients;
            Array.Reverse(_coefficients);
            _exp = new double[coefficients.Length];
            for (int i = 0; i < _exp.Length; i++)
            {
                _exp[i] = i;
            }
        }
        public Polynomial(double[] coefficients, double exp)
        {
            _coefficients = coefficients;
            Array.Reverse(_coefficients);
            _exp = new double[(int)exp];
            for (int i = 0; i < _exp.Length; i++)
            {
                _exp[i] = i;
            }
            Array.Reverse(_coefficients);
        }
        public override string ToString()
        {
            //Объявляем список для хранения коэффициентов в строковом ввиде
            List<string> array = new List<string>();
            List<string> newarray = new List<string>();

            string newChar = ""; // Символ, на который мы заменяем
            int numberNull = 0;

            // Добавляем цисла из объекта в строковый массив
            for (int i = 0; i < _coefficients.Length; i++)
            {
                if(_coefficients[i] == 0)
                {
                    array.Add($"");
                } else
                array.Add($"{exponent_x(_coefficients[i], i)}");
            }

            array.Reverse();

            //Удаляем число 1 где оно как-бы подразумевается, но не пишется 
            for (int i = 0; i < array.Count; i++) // Внешний цикл для перебора строк
            {
                string str = array[i]; // Получаем текущую строку

                // Проверяем условия для удаления символа '1'
                if (str.Length > 1) // Убедимся, что строка имеет хотя бы 2 символа
                {
                    if (str[0] == '1' && str[1] == 'x') // Условие 1: '1' - первый символ, 'x' - второй
                    {
                        array[i] = str.Substring(1); // Удаляем первый символ '1'
                    }
                    else if (str[0] == '-' && str[1] == '1' && str.Length > 2 && str[2] == 'x') // Условие 2: '-' - первый, '1' - второй, 'x' - третий
                    {
                        array[i] = str.Remove(1, 1); // Удаляем второй символ '1'
                    }
                }
            }

            // Проверяем массив на пустые строки
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == newChar)
                {
                    numberNull++;
                }
            }

            // Если массив состоит из пустых строк, то выводим "0"
            if (numberNull == array.Count)
            {
                return "0";
            }
            else
                foreach (string str in array)
                {
                    if (str.Length > 0) // Проверяем, что строка не пустая
                    {
                        char firstChar = str[0]; // Получаем первый символ
                        if (newarray.Count > 0 && firstChar != '-')
                        {
                            newarray.Add($"+{str}");
                        }else
                            newarray.Add(str);
                    }
                }
            //array.Reverse();
            return String.Join("", newarray);
        }
        public static Polynomial operator +(Polynomial P1, Polynomial P2)
        {

            int maxDegree = Math.Max(P1._coefficients.Length, P2._coefficients.Length);

            // Инициализируем результующий многочлен
            double[] R = new double[maxDegree];

            // Сложение коэффициентов
            for (int i = 0; i < maxDegree; i++)
            {
                double coeffP = (i < P1._coefficients.Length) ? P1._coefficients[i] : 0; // Если индекс выходит за пределы P, берем 0
                double coeffQ = (i < P2._coefficients.Length) ? P2._coefficients[i] : 0; // Если индекс выходит за пределы Q, берем 0
                R[i] = coeffP + coeffQ;
            }
            Array.Reverse(R);
            return new Polynomial(R);
        }
        public static Polynomial operator -(Polynomial P1, Polynomial P2)
        {
            int maxDegree = Math.Max(P1._coefficients.Length, P2._coefficients.Length);

            // Инициализируем результующий многочлен
            double[] R = new double[maxDegree];

            // Сложение коэффициентов
            for (int i = 0; i < maxDegree; i++)
            {
                double coeffP = (i < P1._coefficients.Length) ? P1._coefficients[i] : 0; // Если индекс выходит за пределы P, берем 0
                double coeffQ = (i < P2._coefficients.Length) ? P2._coefficients[i] : 0; // Если индекс выходит за пределы Q, берем 0
                R[i] = coeffP - coeffQ;
            }
            Array.Reverse(R);
            return new Polynomial(R);
        }
        public static Polynomial operator *(Polynomial P1, Polynomial P2)
        {
            int maxDegree = (int)P1.Exp() + (int)P2.Exp() + 1;

            // Инициализируем результующий многочлен
            double[] R = new double[maxDegree];
            double[] coefficientsP = {0};
            double[] coefficientsQ = {0};
            int maxI = 0;
            int maxK = 0;

            if (P1.Exp() > P2.Exp())
            {
                maxI = P2._coefficients.Length;
                maxK = P1._coefficients.Length;
                coefficientsP = new double[P1._coefficients.Length];
                coefficientsQ = new double[P2._coefficients.Length];
                Array.Copy(P1._coefficients, coefficientsP, P1._coefficients.Length);
                Array.Copy(P2._coefficients, coefficientsQ, P2._coefficients.Length);
            } else
            {
                maxI = P1._coefficients.Length;
                maxK = P2._coefficients.Length;
                coefficientsP = new double[P2._coefficients.Length];
                coefficientsQ = new double[P1._coefficients.Length];
                Array.Copy(P2._coefficients, coefficientsP, P2._coefficients.Length);
                Array.Copy(P1._coefficients, coefficientsQ, P1._coefficients.Length);
            }

            // Умножение коэффициентов
            for (int i = 0; i < maxI; i++)
            {
                for (int k = 0; k < maxK; k++)
                {
                    double coeffP = (k < maxK) ? coefficientsP[k] : 0; // Если индекс выходит за пределы P, берем 0
                    double coeffQ = (i < maxI) ? coefficientsQ[i] : 0; // Если индекс выходит за пределы Q, берем 0
                    R[i + k] += coeffP * coeffQ;
                }
            }
            Array.Reverse(R);
            return new Polynomial(R);
        }
        public static Polynomial operator /(Polynomial P1, Polynomial P2)
        {
            int maxDegree = (int)P1.Exp() + (int)P2.Exp() + 1;

            // Инициализируем результующий многочлен
            double[] R = new double[maxDegree];
            double[] coefficientsP = { 0 };
            double[] coefficientsQ = { 0 };
            Array.Reverse(P1._coefficients);
            Polynomial r = new Polynomial(P1._coefficients);
            int maxI = 0;
            int maxK = 0;
            double expT = 0;
            double expr = 0;
            double expP2 = 0;
            double[] coefficients1 = { 0 };
            double favorit_r;
            double favorit_P2;
            double favorit_T;
            Polynomial Q = new Polynomial(coefficients1);
            Polynomial T = new Polynomial(coefficients1);

            favorit_P2 = P2.favorit_coeff();
            expP2 = P2.exp();
            int numberNull = 0;

            while (r.exp() >= expP2)
            {
                favorit_r = r.favorit_coeff();
                Array.Reverse(r._coefficients);               
                favorit_T = favorit_r / favorit_P2;
                expr = r.exp();
                expT = (expr - expP2) + 1;
                coefficients1 = new double[(int)expT];
                coefficients1[coefficients1.Length - 1] = favorit_T;
                T = new Polynomial(coefficients1, expT);
                //T._coefficients[0] = favorit_r * favorit_P2;
                Q = P2 * T;
                r = r - Q;
            }

            // Проверяем массив на yekb
            for (int i = 0; i < r._coefficients.Length; i++)
            {
                if (r._coefficients[i] == 0)
                {
                    numberNull++;
                }
            }

            // Если массив состоит из нулей, то выводим 1
            if (numberNull == r._coefficients.Length)
            {
                r._coefficients[r._coefficients.Length - 1] = 1;
                return new Polynomial(r._coefficients);
            }
            
            Array.Reverse(r._coefficients);
            return new Polynomial(r._coefficients);
        }
        public double Exp()
        {
            return _exp.Max();
        }
        public double exp()
        {
            double e = 0;
            for (int i = 0; i < _coefficients.Length; i++)
            {
                if (_coefficients[i] != 0)
                {
                    e = i;
                }
            }
            return e;
        }
        public void reverse()
        {
            Array.Reverse(_coefficients);
        }
        public bool nullarray()
        {
            bool allZeros = true; // Переменная для проверки

            foreach (int number in _coefficients)
            {
                if (number != 0)
                {
                    allZeros = false; // Если найден не ноль, устанавливаем в false
                    break; // Выходим из цикла
                }
            }
            return allZeros;
        }
        public double favorit_coeff()
        {
            Array.Reverse(_coefficients);
            for (int i = 0; i < _coefficients.Length; i++)
            {
                if (_coefficients[i] != 0)
                {
                    return _coefficients[i];
                }
            }
            return 0;
        }
        public void first_monomial(out double monomial, out int e)
        {
            Array.Reverse(_coefficients);
            int i = _coefficients.Length - 1;
            for (; i >= 0; i--)
            {
                if (_coefficients[i] != 0)
                {
                    monomial = _coefficients[i];
                    e = i;
                    return;
                }
            }
            e = i;
            monomial = 0;
        }
        public string exponent_x(double p, int i)
        {
                switch (i)
                {
                    case 0: return $"{p}"; // пустой символ
                    case 1: return $"{p}" + "x"; // p
                    case 2: return $"{p}" + "x²"; // p^2
                    case 3: return $"{p}" + "x³"; // p^3
                    case 4: return $"{p}" + "x⁴"; // p^4
                    case 5: return $"{p}" + "x⁵"; // p^5
                    case 6: return $"{p}" + "x⁶"; // p^6
                    case 7: return $"{p}" + "x⁷"; // p^7
                    case 8: return $"{p}" + "x⁸"; // p^8
                    case 9: return $"{p}" + "x⁹"; // p^9
                    default: return ""; // Для остальных значений
                }
        }
    }
}
