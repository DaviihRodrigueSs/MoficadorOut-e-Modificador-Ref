﻿using System.Globalization;
namespace ModificadorOut
{
    class program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;

            Calculator.Triple (a,out triple);
            Console.WriteLine(triple);
        }
    }
}