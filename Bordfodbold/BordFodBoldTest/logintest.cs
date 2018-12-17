using System;
using System.Web.Mvc;
using Bordfodbold.Abstract;
using Bordfodbold.Controllers;
using Bordfodbold.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BordFodBoldTest {
    [TestClass]
    public class logintest {
        [TestMethod]
        public void Canloginwithcorrect() {
            
            //Arrange   
            Mock<IAuhtProvider> mock = new Mock<IAuhtProvider>();
            mock.Setup(m => m.Authenticate("Admin", "AdminPW")).Returns(true);

            LoginViewModel model = new LoginViewModel();
            model.UserName = "Admin";
            model.PassWord = "AdminPW";
                                                            //står for iAuthprovider
            AccountController acctrol = new AccountController(mock.Object);

            // Act
            ActionResult result = acctrol.Login(model, "/MyURL");
            
            //Assert
            Assert.IsInstanceOfType(result, typeof(RedirectResult));
            Assert.AreEqual("/MyURL", ((RedirectResult)result).Url);

        }


        [TestMethod]
        public void cannotloginwithincorrect() {

            //Arrange
            Mock<IAuhtProvider> mock = new Mock<IAuhtProvider>();
            mock.Setup(m => m.Authenticate("Admin123", "AdminPW123")).Returns(false);

            LoginViewModel model = new LoginViewModel();
            model.UserName = "Admin123";
            model.PassWord = "AdminPW123";
            //står for iAuthprovider
            AccountController acctrol = new AccountController(mock.Object);

            // Act
            ActionResult result = acctrol.Login(model, "/MyURL");

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.IsFalse(((ViewResult)result).ViewData.ModelState.IsValid);
        }
    }
}
