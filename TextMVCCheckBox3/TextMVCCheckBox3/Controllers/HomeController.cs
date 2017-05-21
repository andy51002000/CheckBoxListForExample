using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextMVCCheckBox3.Models;

namespace TextMVCCheckBox3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        //4.
        public ActionResult Create()
        {
            var usr = new UserViewModel();
            usr.AvailableRoles = RolesRepository.GetAll();
            return View(usr);
        }

        //5.
        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            UserRoleService userRoleService = new UserRoleService();
            userRoleService.CreateNewUser(model);

            return View();
        }
    }
}