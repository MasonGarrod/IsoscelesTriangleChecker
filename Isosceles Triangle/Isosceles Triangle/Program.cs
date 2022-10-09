using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isosceles_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Isosceles or Not? \\

            // Declare Variables \\
            string sideA;
            string sideB;
            string sideC;

            // User enters the length of sides in cm \\

            // Side A \\
            Console.Write("Enter the length of side A in cm: ");
            sideA = Convert.ToString(Console.ReadLine());

            // Invalidates if input is left blank \\
            while (sideA == "")
            {
                Console.WriteLine("Incorrect input, try again");
                Console.Write("Enter the length of side A in cm: ");
                sideA = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Side A is {sideA} cm");
            Console.WriteLine("------------------------------");

            // Side B \\
            Console.Write("Enter the length of side B in cm: ");
            sideB = Convert.ToString(Console.ReadLine());

            // Invalidates if input is left blank \\
            while (sideB == "")
            {
                Console.WriteLine("Incorrect input, try again");
                Console.Write("Enter the length of side B in cm: ");
                sideB = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Side B is {sideB} cm");
            Console.WriteLine("------------------------------");

            // Side C \\
            Console.Write("Enter the length of side C in cm: ");
            sideC = Convert.ToString(Console.ReadLine());

            // Invalidates if input is left blank \\
            while (sideC == "")
            {
                Console.WriteLine("Incorrect input, try again");
                Console.Write("Enter the length of side C in cm: ");
                sideC = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Side C is {sideC} cm");
            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine($"Side A is {sideA}cm, Side B is {sideB}cm and Side C is {sideC}cm");
            Console.WriteLine("-----------------------------------------------------------");

            // Determines if the shape is an isosceles triangle \\

            // Isoceles \\

            if (sideA == sideB && sideA != sideC)
            {
                Console.WriteLine("This triangle IS isosceles.");
            }

            else if (sideB == sideC && sideB != sideA)
            {
                Console.WriteLine("This triangle IS isosceles.");
            }

            else if (sideA == sideC && sideA != sideB)
            {
                Console.WriteLine("This triangle IS isosceles.");
            }

            // Not Isosceles \\

            if (sideA == sideB && sideA == sideC)
            {
                Console.WriteLine("This triangle is NOT isosceles.");
            }

            else if (sideA != sideC && sideA != sideB && sideC != sideB)
            {
                Console.WriteLine("This triangle is NOT isosceles.");
            }

            // Exit \\
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();


        }
    }
}
