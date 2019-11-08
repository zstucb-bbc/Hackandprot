using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackingandSavingPage.Areas.SqlInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace HackingandSavingPage.Areas.SqlInjectionController.Controllers
{
    public class SqlInjectionController : Controller
    {
        public IActionResult Index()
            {
            SqlInjectionModel model = new SqlInjectionModel();
            return View(model);
        }

        public ActionResult Login(LoginModel model)
        {
            return View("Login", model);
        }

        public ActionResult Save(SqlInjectionModel model)
        {
            return View("Index", model);
        }
    }
}