using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Стороны треугольника заданы некорректно");

            A = a;
            B = b;
            C = c;
        }

        public string Name => "Треугольник";

        public double Perimeter()
        {
            return A + B + C;
        }

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C)); // Формула Герона
        }

        public string GetParameters()
        {
            return $"Стороны: A = {A}, B = {B}, C = {C}";
        }
    }
}
