using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);


            Console.ReadLine();
            

        }
    }
}
