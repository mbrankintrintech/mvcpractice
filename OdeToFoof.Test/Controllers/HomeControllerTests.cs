using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OdeToFood.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void AboutTest()
        {

            HomeController homeController = new HomeController();
            ViewResult result = homeController.About() as ViewResult;
            Assert.IsNotNull(result.Model);
        }

        [TestMethod()]
        public void IndexTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AboutTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ContactTest()
        {
            Assert.Fail();
        }
    }
}