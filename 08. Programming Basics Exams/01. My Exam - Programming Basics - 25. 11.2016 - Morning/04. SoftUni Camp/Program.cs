using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());

            var car = 0.0;
            var microbus = 0.0;
            var smallBus = 0.0;
            var bigBus = 0.0;
            var train = 0.0;

            var totalPeople = 0.0;
            for (int i = 1; i <= groups; i++)
            {
                var peopleInGroup = int.Parse(Console.ReadLine());
                totalPeople = totalPeople + peopleInGroup;

                if (peopleInGroup <= 5)
                {
                    car += peopleInGroup;
                }
                else if (peopleInGroup > 5 && peopleInGroup <= 12)
                {
                    microbus += peopleInGroup;
                }
                else if (peopleInGroup > 12 && peopleInGroup <= 25)
                {
                    smallBus += peopleInGroup;
                }
                else if (peopleInGroup > 25 && peopleInGroup <= 40)
                {
                    bigBus += peopleInGroup;
                }
                else if (peopleInGroup > 40)
                {
                    train += peopleInGroup;
                }
            }

            Console.WriteLine("{0:f2}%", (car * 100.0) / totalPeople);
            Console.WriteLine("{0:f2}%", (microbus * 100.0) / totalPeople);
            Console.WriteLine("{0:f2}%", (smallBus * 100.0) / totalPeople);
            Console.WriteLine("{0:f2}%", (bigBus * 100.0) / totalPeople);
            Console.WriteLine("{0:f2}%", (train * 100.0) / totalPeople);


        }
    }
}
