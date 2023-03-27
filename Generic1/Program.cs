using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Xml;

namespace Generic1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();
            Console.WriteLine("How many values?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }


}
