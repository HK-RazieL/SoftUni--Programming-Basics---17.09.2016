using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldPeople = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var oldPeopleTicketPrice = 0.0;
            var studentsTicketPrice = 0.0;


            switch (transport)
            {
                case "train":
                    oldPeopleTicketPrice = 24.99;
                    studentsTicketPrice = 14.99;
                    if (oldPeople + students >= 50)
                    {
                        oldPeopleTicketPrice = oldPeopleTicketPrice * 0.5;
                        studentsTicketPrice = studentsTicketPrice * 0.5;
                    }
                    break;
                case "bus":
                    oldPeopleTicketPrice = 32.50;
                    studentsTicketPrice = 28.50;
                    break;
                case "boat":
                    oldPeopleTicketPrice = 42.99;
                    studentsTicketPrice = 39.99;
                    break;
                case "airplane":
                    oldPeopleTicketPrice = 70.00;
                    studentsTicketPrice = 50.00;
                    break;
                default:
                    break;
            }

            var oldPeopleTotalTickets = (oldPeople * oldPeopleTicketPrice) * 2;
            var studentsTotalTickets = (students * studentsTicketPrice) * 2;
            var totalTicketPrice = oldPeopleTotalTickets + studentsTotalTickets;
            var vacationPrice = nights * 82.99;
            var comission = (totalTicketPrice + vacationPrice) * 0.1;

            Console.WriteLine("{0:f2}", totalTicketPrice + vacationPrice + comission);

        }
    }
}
