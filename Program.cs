using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string - строка
            //Console.ReadLine(); читает строку с клавы

            string strA = Console.ReadLine();
            int a = int.Parse(strA);//int.Parse("123") преобразует строку (текст) в число

            string strB = Console.ReadLine();
            int b = int.Parse(strB);

            int s = a + b;

            Console.WriteLine("{0} + {1} = {2}", a, b, s);
            //                          индексы: 0  1   2
            s = a - b;

            Console.WriteLine("{0} - {1} = {2}", a, b, s);
            s = a * b;

            Console.WriteLine("{0} * {1} = {2}", a, b, s);
            s = a / b;

            Console.WriteLine("{0} / {1} = {2}", a, b, s);

            Console.ReadKey();
        }
    }
}
