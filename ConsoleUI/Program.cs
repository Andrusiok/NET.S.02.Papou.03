using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;
using Task3;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "fdffd";
            string b = "aaaaaacs1";

            string c = StringOperations.Concate(a, b);//acdfs

            int[] array = new int[] { 1, 0, 2, 3, 3 };

            int i = IndexSearch.FindIndex(array);//3

            int result = BinaryOperations.Insert(1, 3, 1, 1);//3

            Console.WriteLine("1st task result: {0}\n2nd task result: {1}\n3rd task result: {2}", i, c, result);
            Console.ReadKey(true);
        }
    }
}
