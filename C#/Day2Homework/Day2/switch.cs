using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?");
            string userValue = Console.ReadLine();
            string message = "";

            //give users options
            switch (userValue)
            {
                case "1":
                    message = "You won a new car!";
                    break;
                case "2":
                    message = "You won a new boat!";
                    break;
                case "3":
                    message = "You won a new cat!";
                    break;
                default:
                    message = "sorry, we didnt understand your response. You lose.";
                    break;
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
