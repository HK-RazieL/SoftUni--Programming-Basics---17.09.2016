using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0To100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int secondNumber = number % 10;
            int firstNumber = number / 10;
            int from10to20 = number;

            string secondWord = "";
            string firstWord = "";
            string fromTenToTwenty = "";

            switch (secondNumber)
            {
                case 0:
                    secondWord = "zero";
                    break;
                case 1:
                    secondWord = "one";
                    break;
                case 2:
                    secondWord = "two";
                    break;
                case 3:
                    secondWord = "three";
                    break;
                case 4:
                    secondWord = "four";
                    break;
                case 5:
                    secondWord = "five";
                    break;
                case 6:
                    secondWord = "six";
                    break;
                case 7:
                    secondWord = "seven";
                    break;
                case 8:
                    secondWord = "eight";
                    break;
                case 9:
                    secondWord = "nine";
                    break;
            }

            switch (firstNumber)
            {
                case 2:
                    firstWord = "twenty";
                    break;
                case 3:
                    firstWord = "thirty";
                    break;
                case 4:
                    firstWord = "fourty";
                    break;
                case 5:
                    firstWord = "fifty";
                    break;
                case 6:
                    firstWord = "sixty";
                    break;
                case 7:
                    firstWord = "seventy";
                    break;
                case 8:
                    firstWord = "eighty";
                    break;
                case 9:
                    firstWord = "ninety";
                    break;
            }

            switch (from10to20)
            {
                case 10:
                    fromTenToTwenty = "ten";
                    break;
                case 11:
                    fromTenToTwenty = "eleven";
                    break;
                case 12:
                    fromTenToTwenty = "twelve";
                    break;
                case 13:
                    fromTenToTwenty = "thirteen";
                    break;
                case 14:
                    fromTenToTwenty = "fourteen";
                    break;
                case 15:
                    fromTenToTwenty = "fifteen";
                    break;
                case 16:
                    fromTenToTwenty = "sixteen";
                    break;
                case 17:
                    fromTenToTwenty = "seventeen";
                    break;
                case 18:
                    fromTenToTwenty = "eighteen";
                    break;
                case 19:
                    fromTenToTwenty = "nineteen";
                    break;
            }
            if (number >= 0 && number < 10)
            {
                Console.WriteLine(secondWord);
            }
            else if(number >= 10 && number < 20)
            {
                Console.WriteLine(fromTenToTwenty);
            }
            else if(number == firstNumber * 10 && number < 100)
            {
                Console.WriteLine(firstWord);
            }
            else if (number == firstNumber * 10 + secondNumber && number < 100 && number > 0)
            {
                Console.WriteLine(firstWord + " " + secondWord);
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (number > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (number < 0)
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
