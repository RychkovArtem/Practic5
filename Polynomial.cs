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

            for (int i = 0; i < _coefficients.Length; i++)
            {
                array.Add($"{exponent_x(_coefficients[i], i)}");
            }

            array.Reverse();

            char oldChar = '0'; // Символ, который мы ищем
            string newChar = ""; // Символ, на который мы заменяем
            int numberNull = 0;
            char oldOne = '1'; // Символ, который мы ищем
            char point = ',';

            // Удаляем символ '0'
            //for (int i = 0; i < array.Count; i++)
            //{
            //    foreach (char c in array[i])
            //    {
            //        if (c == oldChar)
            //        {
            //            array[i] = newChar;
            //            break; // Выходим из цикла, если символ найден
            //        }
            //    }
            //}

            // Удаляем символ число 0
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i].Contains(oldChar) && array[i].Contains(point)) // Если есть '0' и ','
                {
                    break;
                }
                else
                {
                    foreach (char c in array[i])
                    {
                        if (c == oldChar)
                        {
                            array[i] = newChar;
                            break; // Выходим из цикла, если символ найден
                        }
                    }
                }
            }

            //// Удаляем символ '1'
            //for (int i = 0; i < array.Count; i++)
            //{
            //    // Если это не последняя строка, то удаляем символ '1'
            //    if (i < array.Count - 1)
            //    {
            //        array[i] = array[i].Replace(oldOne.ToString(), string.Empty);
            //    }
            //}

            for (int i = 0; i < array.Count; i++)
            {
                // Если это не последняя строка, то удаляем символ '1'
                if (i < array.Count - 1)
                {
                    if (array[i].Contains(point)) // Если есть ','
                    {
                        break;
                    }else
                    array[i] = array[i].Replace(oldOne.ToString(), string.Empty);
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
            //List<double> favoritcoeff_P = new List<double>();
            //List<double> favoritcoeff_D = new List<double>();
            //List<double> exp = new List<double>();
            //double[] coefficients1 = new double[0];
            //exp.Add(P1._exp.Max() - P2._exp.Max());
            //coefficients1 = new double[(int)exp[0] + 1];
            //coefficients1[0] = P1.favorit_coeff() / P2.favorit_coeff();
            //Polynomial P3 = new Polynomial(coefficients1);

            //P3 = P3 * P2;
            //P3 = P1 - P3;

            //while(P3._exp.Max() > P2._exp.Max())
            //{
            //    exp.Add(P3._exp.Max() - P2._exp.Max());
            //    coefficients1 = new double[(int)exp[0] + 1];
            //    coefficients1[0] = P3.favorit_coeff() / P2.favorit_coeff();
            //    P1._coefficients = coefficients1;
            //    P1 = P1 * P2;
            //    P1 = P3 - P1;
            //}

            //favoritcoeff_P.Add(P3._coefficients[0]);
            //favoritcoeff_D.Add(P2._coefficients[0]);



            ////coefficients1 = new double[(int)exp[0] + 1];
            ////coefficients1[0] = P1._coefficients[0] / P2._coefficients[0];



            //double[] coefficientsSum = { 1, 0 };
            //return new Polynomial(coefficientsSum);

            int maxDegree = (int)P1.Exp() + (int)P2.Exp() + 1;

            // Инициализируем результующий многочлен
            double[] R = new double[maxDegree];
            double[] coefficientsP = { 0 };
            double[] coefficientsQ = { 0 };
            Polynomial r = new Polynomial(P1._coefficients);
            int maxI = 0;
            int maxK = 0;
            double expT = 0;
            double[] coefficients1 = { 0 };
            double favorit_r;
            double favorit_P2;
            double favorit_T;
            Polynomial Q = new Polynomial(coefficients1);
            Polynomial T = new Polynomial(coefficients1);
            //P3 = P1._coefficients[P1._coefficients.Length - 1] * P2;

            if (P2.Exp() < P1.Exp())
            {
                r = new Polynomial(P1._coefficients);
            }

            while(r.Exp() >= P2.Exp())
            {
                favorit_r = r.favorit_coeff();
                favorit_P2 = P2.favorit_coeff();
                favorit_T = favorit_r / favorit_P2;
                expT = (P1.Exp() - P2.Exp()) + 1;
                coefficients1 = new double[(int)expT];
                coefficients1[coefficients1.Length - 1] = favorit_T;
                T = new Polynomial(coefficients1, expT);
                //T._coefficients[0] = favorit_r * favorit_P2;
                P2 = P2 * T;
                r = r - P2;
            }

            if (P1.Exp() > P2.Exp())
            {
                maxI = P2._coefficients.Length;
                maxK = P1._coefficients.Length;
                coefficientsP = new double[P1._coefficients.Length];
                coefficientsQ = new double[P2._coefficients.Length];
                Array.Copy(P1._coefficients, coefficientsP, P1._coefficients.Length);
                Array.Copy(P2._coefficients, coefficientsQ, P2._coefficients.Length);
            }
            else
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
                    R[i + k] += coeffP / coeffQ;
                }
            }
            Array.Reverse(R);
            return new Polynomial(R);
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
