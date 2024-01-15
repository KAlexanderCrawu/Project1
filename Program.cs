using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5; int b = 5; int sum = a + b; int difference = a - b; int quotient = a / b; int product = a * b;
            Console.WriteLine("The sum of the first and second digit is :" + sum);
            Console.WriteLine("The difference of the first and second digit is: " +difference);
            Console.WriteLine("The quotient of the first and second digit is: " + quotient);
            Console.WriteLine("The product of the first and second digit is: " +  product);
        }  

    }
}
