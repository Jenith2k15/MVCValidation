using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidatingControlsDemo.Models;

namespace ValidatingControlsDemo.Controllers
{
    public class HomeController : Controller
    {
        Register register = new Register();
        // GET: Home
        [HttpGet]
        public ActionResult Register()
        {
            return View(register);
        }

        [HttpPost]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(register);
        }
    }
}