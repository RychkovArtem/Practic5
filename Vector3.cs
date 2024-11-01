using System;

namespace Practic5
{
    public class Vector3
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        //Сложение векторов
        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        //Вычитание векторов
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        //Умножение вектора на скаляр
        public static Vector3 operator *(Vector3 a, double scalar)
        {
            return new Vector3(a.X * scalar, a.Y * scalar, a.Z * scalar);
        }

        //Скалярное произведение
        public static double operator *(Vector3 a, Vector3 b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        //Векторное произведение
        public Vector3 Cross(Vector3 other)
        {
            return new Vector3(
                Y * other.Z - Z * other.Y,
                Z * other.X - X * other.Z,
                X * other.Y - Y * other.X);
        }

        //Длина вектора
        public double Lenght()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        //Нормализация вектора
        public Vector3 Normalize()
        {
            double leght = Lenght();
            return new Vector3(X / leght, Y / leght, Z / leght);
        }

        //Перегрузка метода ToString()
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
