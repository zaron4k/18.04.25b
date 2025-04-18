using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IShape
    {
        double Perimeter();
        double Area();
        string GetParameters();
        string Name { get; }
    }
}
