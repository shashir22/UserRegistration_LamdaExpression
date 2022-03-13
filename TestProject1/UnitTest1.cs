using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_LambdaExpression;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateFirstName_ReturnTrue()
        {
            string FirstName = "Shashi";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidFirstName(FirstName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateLastName_ReturnTrue()
        {
            string LastName = "Kumar";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidLastName(LastName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateEmail_ReturnTrue()
        {
            string Email = "Shashi@gmail.com";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidEmail(Email);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidatePhoneNo_ReturnTrue()
        {
            string Phone = "91 9772346265";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidPhoneNo(Phone);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidatePassword_ReturnTrue()
        {
            string Password = "Pass@w0rdyu";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidPasswordRule(Password);
            Assert.IsTrue(result);
        }

    }
}