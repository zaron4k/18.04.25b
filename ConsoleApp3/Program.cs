using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
            static void PrintShapeInfo(IShape shape)
            {
                Console.WriteLine($"Фигура: {shape.Name}");
                Console.WriteLine($"Параметры: {shape.GetParameters()}");
                Console.WriteLine($"Периметр: {shape.Perimeter():F2}");
                Console.WriteLine($"Площадь: {shape.Area():F2}");
                Console.WriteLine(new string('-', 40));
            }

            static void Main(string[] args)
            {
                try
                {
                    IShape triangle = new Triangle(3, 4, 5);
                    IShape disk = new Disk(5);

                    PrintShapeInfo(triangle);
                    PrintShapeInfo(disk);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }

