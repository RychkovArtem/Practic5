using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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

            //    //Объявляем переменную строкого типа для хранения символа "x" в разных степенях
            string x = "x";

            for (int i = 0; i < _coefficients.Length; i++)
            {
                if (_coefficients[i] > 0)
                {
                    if (_coefficients[i] == 1)
                    {
                        if (i == 0)
                        {
                            array.Add($"+{_coefficients[i]}{exponent(x, i)}");
                        }
                        else
                        {
                            if (i == _coefficients.Length - 1)
                            {
                                array.Add($"{exponent(x, i)}");
                            }
                            else
                            {
                                array.Add($"+{exponent(x, i)}");
                            }
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            array.Add($"+{_coefficients[i]}{exponent(x, i)}");
                        }
                        else
                        {
                            if (i == _coefficients.Length - 1)
                            {
                                array.Add($"{_coefficients[i]}{exponent(x, i)}");
                            }
                            else
                            {
                                array.Add($"+{_coefficients[i]}{exponent(x, i)}");
                            }
                        }
                    }
                }
                else
                {
                    if (_coefficients[i] == 0)
                    {
                        array.Add($"");
                    }
                    else
                    {
                        if (_coefficients[i] == -1)
                        {
                            if (i == 0)
                            {
                                array.Add($"{_coefficients[i]}{exponent(x, i)}");
                            }
                            else
                            {
                                array.Add($"-{exponent(x, i)}");
                            }
                        }
                        else
                        {
                            array.Add($"{_coefficients[i]}{exponent(x, i)}");
                        }
                    }
                }
            }

            array.Reverse();

            return String.Join("", array);

            string exponent(string p, int i)
            {
                switch (i)
                {
                    case 0: return ""; // пустой символ
                    case 1: return $"{p}"; // p
                    case 2: return $"{p}" + "²"; // p^2
                    case 3: return $"{p}" + "³"; // p^3
                    case 4: return $"{p}" + "⁴"; // p^4
                    case 5: return $"{p}" + "⁵"; // p^5
                    case 6: return $"{p}" + "⁶"; // p^6
                    case 7: return $"{p}" + "⁷"; // p^7
                    case 8: return $"{p}" + "⁸"; // p^8
                    case 9: return $"{p}" + "⁹"; // p^9
                    default: return ""; // Для остальных значений
                }
            }
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

            return new Polynomial(R);
        }
        public static Polynomial operator *(Polynomial P1, Polynomial P2)
        {
            int maxDegree = (int)P1.Exp() + (int)P2.Exp() + 1;

            // Инициализируем результующий многочлен
            double[] R = new double[maxDegree];
            int maxI = 0;
            int maxK = 0;

            if (P1.Exp() > P2.Exp())
            {
                maxI = P2._coefficients.Length;
                maxK = P1._coefficients.Length;
            } else
            {
                maxI = P1._coefficients.Length;
                maxK = P2._coefficients.Length;
            }

            // Умножение коэффициентов
            for (int i = 0; i < maxI; i++)
            {
                for (int k = 0; k < maxK; k++)
                {
                    double coeffP = (k < P1._coefficients.Length) ? P1._coefficients[k] : 0; // Если индекс выходит за пределы P, берем 0
                    double coeffQ = (i < P2._coefficients.Length) ? P2._coefficients[i] : 0; // Если индекс выходит за пределы Q, берем 0
                    R[i + k] += coeffP * coeffQ;
                }
            }

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
            }
            else
            {
                maxI = P1._coefficients.Length;
                maxK = P2._coefficients.Length;
            }

            // Умножение коэффициентов
            for (int i = 0; i < maxI; i++)
            {
                for (int k = 0; k < maxK; k++)
                {
                    double coeffP = (k < P1._coefficients.Length) ? P1._coefficients[k] : 0; // Если индекс выходит за пределы P, берем 0
                    double coeffQ = (i < P2._coefficients.Length) ? P2._coefficients[i] : 0; // Если индекс выходит за пределы Q, берем 0
                    R[i + k] += coeffP / coeffQ;
                }
            }

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
    }
}
