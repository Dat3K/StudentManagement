using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManagement;
using System;

namespace UnitTest
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]

        public void TestLoginSuccess()
        {
            // Arrange
            Login form = new Login();
            form.txtUser.Text = "admin";
            form.passwordTextBox.Text = "";

            // Act
            form.loginBtn.PerformClick();

            // Assert
            Assert.IsTrue(form.loggedIn);
        }

    }
}
