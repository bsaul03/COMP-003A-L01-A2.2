/* 
 * 
 * Author: Saul Barajas
 * Course: COMP- 003A L01
 * Purpose: Code for Assigment 2
 */
using System.Reflection;

namespace COMP_003A_L01_A2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            // String section
            Console.Write("Enter your First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your Middle Name: ");
            string middleName = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your Age in 2024: ");
            int yearBorn = 2024 - Convert.ToInt32(Console.ReadLine());
            string inputAge = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}");
            //math section
            Console.Write("Enter the first integer: ");
            string input1 = Console.ReadLine();
            int integer1 = int.Parse(input1);
            Console.Write("Enter the second integer: ");
            string input2 = Console.ReadLine();
            int integer2 = int.Parse(input2);
            Console.WriteLine("Entered integer: " + integer1);
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");
            //Circle Area & Circumference Calculator Section
            Console.Write("Enter the radius: ");
            string radiusInput = Console.ReadLine();
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
            Console.WriteLine($"The circumference of the circle with radius {radius} is: {circumference}");
        }
    }
}
