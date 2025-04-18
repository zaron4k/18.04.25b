using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Disk : IShape
    {
        public double Radius { get; }

        public Disk(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным");

            Radius = radius;
        }

        public string Name => "Круг";

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public string GetParameters()
        {
            return $"Радиус: R = {Radius}";
        }
    }
}
