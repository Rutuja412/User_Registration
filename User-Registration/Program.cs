using System;

namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration");
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1. Enter First Name\n2. Enter Last Name\n3. Enter Email ID\n4. Enter Mobile Number\n5.Password Rule1\n6.Password-Rule2 \n7.Password-Rule2 \n8.Exit");
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
                    case 5:
                    Console.WriteLine("Enter Password for rule 1:");
                    pattern.passwordRule1();
                    break;
                    case 6:
                    Console.WriteLine("Enter Password For Rule 2:");
                    pattern.passwordRule2();
                    break;
                    case 7:
                    Console.WriteLine("Enter Password For Rule 3");
                    pattern.passwordRule3();
                    break;
                default:
                    Console.WriteLine("Enter Correct Option!!!");
                    
                    break;
            }
        }
    }
}
