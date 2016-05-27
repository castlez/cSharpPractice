using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPractice
{
    class Lambda_Practice
    {
        public static void Main()
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            // ... Find index of first odd element.
            int oddIndex = elements.FindIndex(x => x % 2 != 0);
            LazyPrintLine(oddIndex);
            LazyReadKey();
        }

        public static void LazyPrintLine(object input)
        {
            System.Console.WriteLine(input);
        }

        public static void LazyPrint(object input)
        {
            System.Console.Write(input);
        }

        public static void LazyReadKey()
        {
            System.Console.ReadKey();
        }

        public static object LazyReadline()
        {
            return System.Console.ReadLine();
        }
    }
}
