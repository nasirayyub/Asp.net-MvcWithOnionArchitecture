using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Services.Interfaces;

namespace MVCAppArchitecture.Controllers
{
    public class HomeController : Controller
    {
        //#region Properties

        private readonly IUserService _userService;

        //#endregion
        //#region Constructors

        public HomeController(
            IUserService userService
            )
        {
            _userService = userService;
        }

        //#endregion
        //#region Public Methods
        public ActionResult Index()
        {
            var getAllUser = _userService.AllUsers();
            return View(getAllUser);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //#endregion
        //#region Helpers

        //// ADD HERE

        //#endregion



    }
}