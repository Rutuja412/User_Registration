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
        string EMAIL_ID = "^[a-z]{7}[0-9]{3}[@][a-z]{5}[.][a-z]{3}$"; //abcdefg589@gmail.com
        public void ValidEmail()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, EMAIL_ID))
                Console.WriteLine("Valid Email id - " + input);
            else
                Console.WriteLine("Invalid");
        }
        string MOBILE_NUMBER = "^[+][0-9]{2}[0-9]{10}$";
        public void MobileNumber()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, MOBILE_NUMBER))
                Console.WriteLine("Valid Mobile Number : " + input);
            else
                Console.WriteLine("Invalid");
        }
        string PASSWORD_RULE1 = "^[a-z]{8}$";//minimum 8 chara
        public void passwordRule1()
        {
            string input= Console.ReadLine();
            if (Regex.IsMatch(input, PASSWORD_RULE1))
                Console.WriteLine("Valid Password for Rule1 : " + input);
            else
                Console.WriteLine("Invalid");

        }
    }
}

