using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SokolovaAA.Sprint0.Task5.V0.Lib
{
    public class DataService
     
    {
        //Пример линенйой структуры
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        //Пример линейной струкутуры
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        //Пример линейной структуры
        public static int Multiplication(int a, int b)
        {

            return a * b;
        }
        //Пример линейной структуры
       
        public static double Division(int a, int b)

        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException) 

            {
                Console.WriteLine("переменная b={0} на ноль делить нельзя", b);

                throw;
            }

            //if (b == 0) 
            //{
            //    //пример создан в целях демонстрации ветвления
            //    //в реальных проектах нужно использовать exception
            //    Console.WriteLine("переменная b={0} на ноль делить нельзя", b);
            //    return -1;
            //}
            //else
            //{
            //    return a / b;
            //}
        }
    }
}

