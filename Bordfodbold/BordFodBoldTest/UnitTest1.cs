using System;
using Bordfodbold.Concrete;
using Bordfodbold.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BordFodBoldTest {
    [TestClass]
    public class TestSaveKamp{
        [TestMethod]
        public void cansaveKamp() {
            //Arrange
            Mock<Ikamprepository> mock = new Mock<IKamprepository>();

            HomeController testcontroller = new HomeController(mock.Object);
        }
    }
}
