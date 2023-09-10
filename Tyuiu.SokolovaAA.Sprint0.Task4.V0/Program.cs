using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.SokolovaAA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //пример линейной структуры программы
            //вызов метода сложения addition
            Console.WriteLine(DataService.Addition(1, 5));
            //вызов метода умножения multiplication
            Console.WriteLine(DataService.Multiplication(10, 10));
            //вызов метода деления division
            Console.WriteLine(DataService.Division(5, 5));
            //вызов вычитания метода вычитания subtraction
            Console.WriteLine(DataService.Subtraction(15, 5));

            Console.ReadKey();
        }
    }
}
