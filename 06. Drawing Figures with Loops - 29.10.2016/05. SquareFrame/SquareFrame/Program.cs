using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var row = 0;
            var col = 0;


            for (row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.Write("- ");
                }
            }

            Console.WriteLine();
            
            for (col = 1; col <= n - 2; col++)
            {
                if (col > 1 || col < n)
                {
                    var spaces = "| " + new string('&', n - 2) + "|";
                    spaces = spaces.Replace("&", "- ");
                    Console.Write(spaces);
                }
                Console.WriteLine();
            }

                var endRow = "+ " + new string('$', n - 2) + "+";
                endRow = endRow.Replace("$", "- ");
                Console.WriteLine(endRow);
           
        }
    }
}
