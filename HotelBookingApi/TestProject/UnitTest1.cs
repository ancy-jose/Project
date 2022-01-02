using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using HotelBookingApi.Controllers;
using HotelBookingApi.Models;
using Microsoft.AspNetCore.Mvc;





namespace HotelBookingApi.Controllers
{
    public class BookingsController : Controller
    {
        public ActionResult Index()
        {
            // Add action logic here
            throw new NotImplementedException();
        }



        public ActionResult Details(int Id)
        {



            return View("Details");
        }
    }




    [TestFixture]
    public class BookingsControllerTest
    {
        [Test]
        public void Test1()
        {
#pragma warning disable CS0436 // Type conflicts with imported type
            var controller = new BookingsController();
#pragma warning restore CS0436 // Type conflicts with imported type
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);



        }



        [Test]
        public void Test2()
        {
#pragma warning disable CS0436 // Type conflicts with imported type
            var controller = new BookingsController();
#pragma warning restore CS0436 // Type conflicts with imported type
            var result = controller.Details(2) as ViewResult;
            Assert.IsNaN(Double.NaN, result.ViewName);



        }



        [Test]
        public void Test3()
        {
#pragma warning disable CS0436 // Type conflicts with imported type
            var controller = new BookingsController();
#pragma warning restore CS0436 // Type conflicts with imported type
            var result = controller.Details(2) as ViewResult;
            Assert.IsEmpty("", result.ViewName);



        }



        [Test]
        public void Test4()
        {
#pragma warning disable CS0436 // Type conflicts with imported type
            var controller = new BookingsController();
#pragma warning restore CS0436 // Type conflicts with imported type
            var result = controller.Details(2) as ViewResult;
            Assert.NotNull("Passed", result.ViewName);



        }
    }
}