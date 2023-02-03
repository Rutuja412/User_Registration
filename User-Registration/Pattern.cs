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
        string PASSWORD_RULE2 = "^[A-Z]{8}$";
        public void passwordRule2()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, PASSWORD_RULE2))
                Console.WriteLine("Valid Password for Rule2 : " + input);
            else
                Console.WriteLine("Invalid");

        }
        string PASSWORD_RULE3 = "^[A-Z]{1}[a-z]{2}[0-9]{3}$";//Abc123
        public void passwordRule3()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, PASSWORD_RULE3))
                Console.WriteLine("Valid Password for Rule3 : " + input);
            else
                Console.WriteLine("Invalid");

        }
        string PASSWORD_RULE4 = "^[A-Z]{1,}[a-z]{1,}[!@#$&]{1}[0-9]{1,}$";//Ab@3
        public void passwordRule4()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, PASSWORD_RULE4))
                Console.WriteLine("Valid Password for Rule4 : " + input);
            else
                Console.WriteLine("Invalid");

        }
        string emailFormat = "[A-Za-z0-9](.[-+a-z0-9A-Z])+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,3})?$";
        public void EmailSampleValidation()
        {
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();

            if (Regex.IsMatch(email, emailFormat))
            {
                Console.Write("Given Email ID is Valid \n");

                Regex regex1 = new Regex(emailFormat);
                Console.Write("Please Enter valid Email ID ");
            }
        }

    }
}

