using System;
using System.Xml.Linq;

namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration");
            
            Pattern pat = new Pattern();
           
            Console.WriteLine("Enter the First Name: ");
            string firstname = Console.ReadLine();
            bool name = pat.Validate_FirstName(firstname);
            Console.WriteLine(name);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter the Last Name: ");
            string lastname = Console.ReadLine();
            bool name1 = pat.Validate_LastName(lastname);
            Console.WriteLine(name1);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter the Email Id: ");
            string email = Console.ReadLine();
            bool id = pat.Validate_Email(email);
            Console.WriteLine(id);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter the Phone Number: ");
            string phonenumber = Console.ReadLine();
            bool num = pat.Validate_PhoneNumber(phonenumber);
            Console.WriteLine(num);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Password: ");
            string password1 = Console.ReadLine();
            bool pass1 = pat.Validate_Password1(password1);
            Console.WriteLine(pass1);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Password: ");
            string password2 = Console.ReadLine();
            bool pass2 = pat.Validate_Password2(password2);
            Console.WriteLine(pass2);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Password: ");
            string password3 = Console.ReadLine();
            bool pass3 = pat.Validate_Password3(password3);
            Console.WriteLine(pass3);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Password: ");
            string password4 = Console.ReadLine();
            bool pass4 = pat.Validate_Password4(password4);
            Console.WriteLine(pass4);
            Console.WriteLine("----------------------------------------");
        }
        }
    }

