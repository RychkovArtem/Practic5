using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace Practic5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Vector3 V1 = new Vector3(3, 4, 5);
            //Vector3 V2 = new Vector3(6, 1, 2);
            //Vector3 V3 = V1 + V2;
            //Console.WriteLine(V3.ToString());
            //Vector3 V3 = V1.Cross(V2);
            //double k = V1.Lenght();
            //Vector3 V4 = V1.Normalize();
            //Console.WriteLine(V4.ToString());
            //Console.WriteLine(V3.ToString());

            //double[] coif = { 6, -7, 8, 1 };
            //Polynomial P1 = new Polynomial(coif);
            //Console.WriteLine(P1.ToString());
            double[] p1 = { 3, 5, 0, 2, 4 };
            double[] p2 = { 1, 1 };
            Polynomial P1 = new Polynomial(p1);
            Polynomial P2 = new Polynomial(p2);
            Polynomial P3 = P1 / P2;
            //double exp = P2.Exp();
            Console.WriteLine(P3.ToString());
        //    Dictionary<string, Vector3> vector = new Dictionary<string, Vector3>();
        //    int Number_Vector = 0;

        //    string inputMain;
        //    string inputCreateVector;
        //    do
        //    {
        //        Console.Clear();
        //        ShowMenu();
        //        inputMain = Console.ReadLine();
        //        switch (inputMain)
        //        {
        //            case "1":
        //                do
        //                {
        //                    VectorMenu(vector, Number_Vector);
        //                    inputCreateVector = Console.ReadLine();
        //                    switch (inputCreateVector)
        //                    {
        //                        case "1":
        //                            Vector3Create(vector, Number_Vector);
        //                            break;
        //                        case "2":
        //                            Polynomaial();
        //                            break;
        //                        case "10":
        //                            Console.WriteLine("Выход...");
        //                            break;
        //                        default:
        //                            Console.WriteLine("Некорректный ввод, попробуйте снова");
        //                            break;
        //                    }
        //                }while (inputCreateVector != "10");
        //             break;
        //            case "2":
        //                Polynomaial();
        //                break;
        //            case "3":
        //                Console.WriteLine("Выход...");
        //                break;
        //            default:
        //                Console.WriteLine("Некорректный ввод, попробуйте снова");
        //                break;
        //        }
        //    } while (inputMain != "3");
        //}
        //static void ShowMenu()
        //{
        //    Console.Clear();
        //    Console.WriteLine("=== Главное меню ===");
        //    Console.WriteLine("1. Работа с векторами");
        //    Console.WriteLine("2. Работа с многочленами");
        //    Console.WriteLine("3. Выход");
        //    Console.Write("Выберите опцию: ");
        //}
        //static void VectorMenu(Dictionary<string, Vector3> vector, int Number_Vector)
        //{
        //    Console.Clear();
        //    Console.WriteLine("=== Работа с векторами ===");
        //    Console.WriteLine("1. Создать вектор");
        //    Console.WriteLine("2. Показать созданные векторы");
        //    Console.WriteLine("3. Сложить два вектора");
        //    Console.WriteLine("4. Вычесть два вектора");
        //    Console.WriteLine("5. Умножить вектор на скаляр");
        //    Console.WriteLine("6. Скалярное произведение");
        //    Console.WriteLine("7. Векторное произведение");
        //    Console.WriteLine("8. Длина вектора");
        //    Console.WriteLine("9. Нормализация вектора");
        //    Console.WriteLine("10. Выход");
        //    Console.Write("Выберите опцию: ");
        //}
        //static void Vector3Create(Dictionary<string, Vector3> vector, int Number_Vector)
        //{
        //    Console.Clear();
        //    double x, y, z;

        //    if (vector.Count > 0) 
        //    {
        //        Number_Vector++;
        //    }
        //    Console.WriteLine("Введите координаты вектора");
        //    Console.Write("Введите x: ");
        //    x = double.Parse(Console.ReadLine());
        //    Console.Write("Введите y: ");
        //    y = double.Parse(Console.ReadLine());
        //    Console.Write("Введите z: ");
        //    z = double.Parse(Console.ReadLine());              
        //    vector.Add($"Vector_{Number_Vector}", new Vector3(x, y, z));
        //    string Key_name = vector.Keys.ElementAt(Number_Vector);
        //    Console.WriteLine($"Вы создали вектор {Key_name}({x}, {y}, {z})");
        //    Console.ReadKey();
        //    return;
        //}
        //static void Polynomaial()
        //{

        }
    }
}
