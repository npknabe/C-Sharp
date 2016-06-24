using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please recalibrate core every 24 hours!");
            Console.WriteLine("Type in the correct recalibration code and press enter...do NOT press the wrong numbers!");
            Console.WriteLine("If you should see FAILURE, evacuate the building immediately!");
            string userValue = Console.ReadLine();
            
            string message = "";

            if (userValue == "1 " + "2 " + "3")
                {
                    message = ("Recalibrating Core");
                }
 
            else
                {
                    message = ("FAILURE, MELTDOWN WILL HAPPEN IN 11 MINUTES!");
                    Console.Beep();
                }

            Console.WriteLine(message);
            Console.ReadLine();
         }
    }
}
