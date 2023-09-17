using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.SokolovaAA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            //пример циклической структуры находится в библиотеке классов в методе AdditionArray
            Console.WriteLine("сумма элементов массива =" + DataService.AdditionArray(numsArray));

            //пример циклической структуры находится в библиотеке классов в методе SubtractionArray
            Console.WriteLine("разность элементов массива =" + DataService.SubtractionArray(numsArray));

            //пример цикллической структуры находится в библиотеке классов в методе MultiplicationArray
            Console.WriteLine("произведение элементов массива =" + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
