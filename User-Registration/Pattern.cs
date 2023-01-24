using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    internal class Pattern
    {
         string FIRST_NAME = "^[A-Z][a-z]{5}$";
        public void FirstName()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, FIRST_NAME))
                Console.WriteLine("First Name - " + input);
            else
                Console.WriteLine("Invalid");
        }
        string LAST_NAME = "^[A-Z][a-z]{4}$";
        public void LastName()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, LAST_NAME))
                Console.WriteLine("Last Name : " + input);
            else
                Console.WriteLine("Invalid");
        }
    }
}

