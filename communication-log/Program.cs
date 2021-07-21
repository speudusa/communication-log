using System;

namespace communication_log
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name:");
            string input = Console.ReadLine();

            int nameLength = input.Length;

            Console.WriteLine($"Your name, {input}, contains {nameLength} letters.");

            Console.WriteLine("Hello, Alyce");
        }
    }
}
