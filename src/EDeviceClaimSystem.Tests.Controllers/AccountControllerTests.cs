using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using EDeviceClaims.Domain.Services;
using EDeviceClaims.Entities;
using EDeviceClaims.WebUi.Controllers;
using EDeviceClaims.WebUi.Models;
using Moq;
using NUnit.Framework;
using WebUi;

namespace EDeviceClaimSystem.Tests.Controllers
{
    [TestFixture]
    public class AccountControllerTests
    {
        private Mock<PolicyService> _mockPolicyService;
        private AccountController _controller;
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        [SetUp]
        public void SetupTest()
        {
            _mockPolicyService = new Mock<PolicyService>();
            _controller = new AccountController();
        }

        [Test]
        public async Task ValidRegistrationWorks()
        {
            var newUser = new RegisterViewModel
            {
                Email = "batman@gotham.com",
                Password = "okpassword"
            };

            var result = await _controller.Register(newUser) as RedirectToRouteResult;


            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("Home", result.RouteValues["controller"]);
        }
    }
}
