using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
 
            Console.WriteLine("Hello {0}!!!", yourName);

            
            System.Console.WriteLine("What is your years old?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
        } 
    }
}
