using System;

namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration");
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1. Enter First Name\n2. Exit");
            int condition = Convert.ToInt32(Console.ReadLine());
            Pattern pattern = new Pattern();
            switch (condition)
            {
                case 1:
                    Console.WriteLine("Enter name:");
                    pattern.FirstName();
                    break;
                default:
                    Console.WriteLine("Oops,Try Again!");
                    
                    break;
            }
        }
    }
}
