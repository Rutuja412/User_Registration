using System;

namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration");
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1. Enter First Name\n2. Enter Last Name\n3. Enter Email ID\n4. Enter Mobile Number\n5.Exit");
            int condition = Convert.ToInt32(Console.ReadLine());
            Pattern pattern = new Pattern();
            switch (condition)
            {
                case 1:
                    Console.WriteLine("Enter name:");
                    pattern.FirstName();
                    break;
                    case 2:
                    Console.WriteLine("Enter Last Name: ");
                    pattern.LastName();
                    break;
                case 3:
                    Console.WriteLine("Enter Email ID: ");
                    pattern.ValidEmail();
                    break;
                case 4:
                    Console.WriteLine("Enter Mobile Number: ");
                    pattern.MobileNumber();
                    break;
                default:
                    Console.WriteLine("Enter Correct Option!!!");
                    
                    break;
            }
        }
    }
}
