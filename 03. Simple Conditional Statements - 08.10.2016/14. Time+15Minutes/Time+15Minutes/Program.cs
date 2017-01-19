using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var totalTime = (hour * 60) + minutes + 15;
            var resultHours = totalTime / 60;
            var resultMinutes = totalTime % 60;

            if (resultMinutes >= 60)
            {
                resultHours += 1;
            }
            if (resultHours == 24)
            {
                resultHours = 0;
            }
            Console.WriteLine("{0}:{1:00}",resultHours, resultMinutes);
        }
    }
}
