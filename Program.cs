using System;
using System.Collections.Generic;
using System.Text;

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
            double[] p1 = { 2, 0, 0 };
            double[] p2 = { 2, 1, -1 };
            Polynomial P1 = new Polynomial(p1);
            Polynomial P2 = new Polynomial(p2);
            Polynomial P3 = P1 + P2;
            //double exp = P2.Exp();
            Console.WriteLine(P3.ToString());
        }
    }
}
