using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            decimal chin = decimal.Parse(Console.ReadLine());
            decimal dollar = decimal.Parse(Console.ReadLine());
            int bincoinConversion = 1168 * bitcoin;
            var chinConversion = (0.15m * chin) / dollar;
            var dollarConversion = (1.76m * dollar) + chinConversion;
            var euroConversion = 1.95m;
            var leva = bincoinConversion + chinConversion + dollarConversion;
            decimal result = leva / euroConversion;
            var comission = result - (5 / 100);
            Console.WriteLine(result);
        }
    }
}
