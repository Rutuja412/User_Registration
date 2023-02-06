using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    internal class Pattern
    {

        public static string REGEX_CODE = "^[A-Z]{1}[a-z]{4}$";
        public bool Validate_FirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_CODE);
        }
        public static string REGEX_LASTNAMECODE = "^[A-Z]{}[a-z]{2}$";
        public bool Validate_LastName(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAMECODE);
        }
        public static string REGEX_EMAILCODE = @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2})?$";
        public bool Validate_Email(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAILCODE);
        }
        public static string REGEX_PHONECODE = "^+[1-9]{2}[: :][0-9]{10}$";
        public bool Validate_PhoneNumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, REGEX_PHONECODE);
        }
        public static string REGEX_PASSWORDCODE1 = "^[a-z]{8}$";
        public bool Validate_Password1(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORDCODE1);
        }
        public static string REGEX_PASSWORDCODE2 = "^[a-zA-Z]{8}$";
        public bool Validate_Password2(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORDCODE2);
        }
        public static string REGEX_PASSWORDCODE3 = "^[a-zA-Z0-9]{8}$";
        public bool Validate_Password3(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORDCODE3);
        }
        public static string PASSWORDCODE4 = @"^[a-zA-Z0-9]?[~`!@#$%^&*()-_+={}[]|\;:""<>,./?]{1,8}$";
        public bool Validate_Password4(string password)
        {
            return Regex.IsMatch(password, PASSWORDCODE4);
        }
        public static string REGEX_EmailCODE1 = @"^([a-z]+)?@([a-z]+)\.([a-z\,]{2,})$";
        public bool Validate_Email1(string email)
        {
            return Regex.IsMatch(email, REGEX_EmailCODE1);
        }
        public static string REGEX_EmailCODE2 = @"^([a-z0-9\-]+)?@([a-z]+)\.([a-z\,]{2,})$";
        public bool Validate_Email2(string email)
        {
            return Regex.IsMatch(email, REGEX_EmailCODE2);
        }
        public static string REGEX_EmailCODE3 = @"^([a-z0-9\.]+)?@([a-z]+)\.([a-z\,]{2,})$";
        public bool Validate_Email3(string email)
        {
            return Regex.IsMatch(email, REGEX_EmailCODE3);
        }
        public static string REGEX_EmailCODE4 = @"^([a-z0-9]+)?@([a-z]+)\.([a-z\,]{2,})$";
        public bool Validate_Email4(string email)
        {
            return Regex.IsMatch(email, REGEX_EmailCODE4);
        }
        public static string REGEX_EmailCODE5 = @"^([a-z0-9\-]+)?@([a-z]+)\.([a-z\,]{2,})$";
        public bool Validate_Email5(string email)
        {
            return Regex.IsMatch(email, REGEX_EmailCODE5);
        }
        public static string REGEX_EmailCODE6 = @"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";
        public bool Validate_Email6(string email)
        {
            return Regex.IsMatch(email, REGEX_EmailCODE6);
        }
        public static string REGEX_EmailCODE7 = @"^([a-z]+)?@([1]+)\.([a-z\,]{2,})$";
        public bool Validate_Email7(string email)
        {
            return Regex.IsMatch(email, REGEX_EmailCODE7);
        }
        public static string REGEX_EmailCODE8 = @"^([a-z]+)?@([a-z]+)\.([a-z]{2,5})(\.[a-z]{3})?$";
        public bool Validate_Email8(string email)
        {
            return Regex.IsMatch(email, REGEX_EmailCODE8);
        }
        public static string REGEX_EmailCODE9 = @"^([a-z0-9\+]+)?@([a-z]+)\.([a-z\,]{2,})$";
        public bool Validate_Email9(string email)
        {
            return Regex.IsMatch(email, REGEX_EmailCODE9);
        }
    }
    public class UserEntryValidationTest
    {
        public static string REGEX_CODE = "^[A-Z]{1}[a-z]{5}$";
        public static string REGEX_LASTNAMECODE = "^[A-Z]{1}[a-z]{4}$";
        public static string REGEX_EMAILCODE = @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2})?$";
        public static string REGEX_PHONECODE = "^[+][0-9]{2}[0-9]{10}$";
        public static string REGEX_PASSWORDCODE1 = "^[A-Z]{1}[a-z]{2}[0-9]{3}$";
        public string ValidateFirstName(string firstname) =>
            Regex.IsMatch(firstname, REGEX_CODE) ? "Rutuja" : "Last Name is not match";
        public void ValidationFirstName(string firstname)
        {
            Console.WriteLine(Regex.IsMatch(firstname, REGEX_CODE));
        }
        public string ValidateLastName(string lastname) =>
            Regex.IsMatch(lastname, REGEX_LASTNAMECODE) ? "Kadam" : "Last Name is not match";
        public void ValidationLastName(string lastname)
        {
            Console.WriteLine(Regex.IsMatch(lastname, REGEX_LASTNAMECODE));
        }
        public string ValidateEmail(string email) =>
            Regex.IsMatch(email, REGEX_EMAILCODE) ? "abc.xyz@bl.co.in" : "Email is not match";
        public void ValidationEmail(string email)
        {
            Console.WriteLine(Regex.IsMatch(email, REGEX_EMAILCODE));
        }
        public string ValidatePhoneNumber(string phonenumber) =>
            Regex.IsMatch(phonenumber, REGEX_PHONECODE) ? "+919945678956" : "Phonenumber is not match";
        public void ValidationPhoneNumber(string phonenumber)
        {
            Console.WriteLine(Regex.IsMatch(phonenumber, REGEX_PHONECODE));
        }
        public string ValidatePassword1(string password) =>
             Regex.IsMatch(password, REGEX_PASSWORDCODE1) ? "Abc123" : "Password is not match";
        public void ValidationPassword(string password)
        {
            Console.WriteLine(Regex.IsMatch(password, REGEX_PASSWORDCODE1));
        }
    }


}


