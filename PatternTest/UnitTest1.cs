using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using User_Registration;

namespace PatternTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateFirstName()
        {
            //Arrange
            string excepted = "Rutuja";
            string firstname = "Vikram";
            //Act
            UserEntryValidationTest regex = new UserEntryValidationTest();
            string actual = regex.ValidateFirstName(firstname);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
        [TestMethod]
        public void ValidateLastName()
        {
            //Arrange
            string excepted = "Kadam";
            string lastname = "Pawar";
            //Act
            UserEntryValidationTest regex = new UserEntryValidationTest();
            string actual = regex.ValidateLastName(lastname);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
        [TestMethod]
        public void ValidatePhoneNumber()
        {
            //Arrange
            string excepted = "+919945678956";
            string phonenumber = "+919945678953";
            //Act
            UserEntryValidationTest regex = new UserEntryValidationTest();
            string actual = regex.ValidatePhoneNumber(phonenumber);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
        [TestMethod]
        public void ValidateEmail()
        {
            //Arrange
            string excepted = "abc.xyz@bl.co.in";
            string email = "abc.ram@bl.co.im";
            //Act
            UserEntryValidationTest regex = new UserEntryValidationTest();
            string actual = regex.ValidateEmail(email);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
        [TestMethod]
        public void ValidatePassword()
        {
            //Arrange
            string excepted = "Abc123";
            string password = "Xyz345";
            //Act
            UserEntryValidationTest regex = new UserEntryValidationTest();
            string actual = regex.ValidatePassword1(password);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
    }

   
}

