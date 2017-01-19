using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(inputDate.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}

