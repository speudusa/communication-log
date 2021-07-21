using System;

namespace communication_log
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter a Number:");
            string input = Console.ReadLine();

            if(Int32.Parse(input) % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd.");
            }

            Console.WriteLine("Hello, Alyce");
        }
    }
}
