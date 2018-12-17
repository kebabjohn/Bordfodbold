using System;
using System.Web.Mvc;
using Bordfodbold.Abstract;
using Bordfodbold.Controllers;
using Bordfodbold.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace BordFodBoldTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void canspilleradddfight() {
            // Arrange 
            Kamp match = new Kamp();
            match.Kamp_ID = 0;
            match.Spiller1 = "p1";
            match.Spiller2 = "p2";
            match.Spiller3 = "p3";
            match.Spiller4 = "p4";
            match.Kamp_Dato = DateTime.Now;
            Mock<IKampRepository> mock = new Mock<IKampRepository>();
            mock.Setup(me => me.SaveKamp(match));
            Mock<ISpillerRepository> muck = new Mock<ISpillerRepository>();


            HomeController home = new HomeController( muck.Object, mock.Object);
            // act
            ActionResult action = home.AfslutKamp(match);

            //Assert

        }
    }
}
