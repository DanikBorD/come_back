using System;
using System.IO;
using System.Linq;
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
        public static long additionEvenNumbers(long privateNumber = 2)
        {
            return (privateNumber < 100 ? privateNumber += additionEvenNumbers(privateNumber + 2) : (privateNumber));
        }

        static long TotalAllEvenNumbers(int[] intArray)
        {
            return intArray.Where(i => i % 2 == 0).Sum(i => (long) i);
        }
        
        static long TotalAllEvenNumbers2(int[] intArray) {
            return (from i in intArray where i % 2 == 0 select (long)i).Sum();
        }
        
        //Напишите код на C# для вычисления окружности, без изменения класса circle
        public sealed class Circle {
            private double radius;
 
            public double Calculate(Func<double, double> op) {
                return op(radius);
            }
        }
    }
}
