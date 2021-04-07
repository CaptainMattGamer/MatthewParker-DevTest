using DevTest.Core.Abstract;
using DevTest.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevTest.Controllers
{
    public class HomeController : Controller
    {
        public IUserService _userService = null;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var users = _userService.GetAllUsers().ToList().Take(10);
            return View("Index", users);
        }

        [HttpGet]
        public PartialViewResult GetPage(int page = 0)
        {
            var users = _userService.GetAllUsers().ToList().Skip(page * 10).Take(10);
            return PartialView("GetPage", users);
        }

        [HttpPost]
        public JsonResult InsertUser(User newUser)
        {
            newUser.UserId = Guid.NewGuid();
            User returnUser = _userService.AddUser(newUser);
            return Json (new { UserId = returnUser.UserId, Title = returnUser.Title, FirstName = returnUser.FirstName, 
                LastName = returnUser.LastName, UserName = returnUser.UserName, Email = returnUser.Email }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateUser(User updateUser)
        {
            _userService.UpdateUser(updateUser);
            return new EmptyResult();
        }
    }
}