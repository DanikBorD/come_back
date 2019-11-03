using System;
using System.IO;
using static System.Console;

namespace addition_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
           Console.WriteLine("RESULT IS " + Solutions.additionEvenNumbers());
        }
    }

    class Solutions
    {
        // Сумма всех четных чисел до какого-то предела
        public static long additionEvenNumbers ( long privateNumber = 2)
        {
            return (privateNumber < 100 ? privateNumber += additionEvenNumbers(privateNumber + 2) : (privateNumber));
        }
    }
}
