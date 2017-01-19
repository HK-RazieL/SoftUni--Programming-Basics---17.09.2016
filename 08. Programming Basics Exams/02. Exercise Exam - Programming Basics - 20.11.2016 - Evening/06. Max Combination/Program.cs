using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            var secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the maximum allowed combinations");
            var maxNumberOfCombinations = int.Parse(Console.ReadLine());
            var numberOfCombinations = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    if (numberOfCombinations == maxNumberOfCombinations)
                    {
                        break;
                    }
                    Console.Write("<" + i + "-" + j + ">");
                    numberOfCombinations++;
                }
            }
            Console.WriteLine($"\n\nThere are a total of  {numberOfCombinations} possible combinations");
        }
    }
}
