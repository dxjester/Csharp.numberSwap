/*
 * FILE NAME: numberSwap.cs
 * PROJECT NAME: Number Swap Project
 * DATE INITIATLIZED: 22 July 2018
 * DESCRIPTION: A C# program designed to swap two integers
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.Write("\nInput the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("\nInput the second number: ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nAfter swap: ");
            Console.WriteLine("\nFirst Number: " + num1);
            Console.WriteLine("\nSecond Number: " + num2);
            Console.Read();          

        }
    }
}
