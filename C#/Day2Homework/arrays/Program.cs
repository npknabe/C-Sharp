﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;
           // numbers[5] = 42;

            int[] numbers = { 4, 8, 15, 16, 23 };
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i].ToString());
            }

            string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string myText = "Now is the time for all men to come to the aid of their country.";
            char[] charArray = myText.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);


                //Console.WriteLine(numbers[1].ToString());
                Console.ReadLine();
       
        }
    }
}
