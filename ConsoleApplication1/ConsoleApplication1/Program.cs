﻿using System;
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
            int valueOne;
            int valueTwo;
            Console.WriteLine("Please enter value one ");
            valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter value two ");
            valueTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Result is " +( valueOne + valueTwo));

            Console.ReadLine();
        }
    }
}
