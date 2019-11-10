using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackingandSavingPage.Areas.SqlInjection.Models;
using HackingandSavingPage.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace HackingandSavingPage.Areas.SqlInjectionController.Controllers
{
    public class SqlInjectionController : Controller
    {


        Logger logger = new Logger();
        public IActionResult Index()
            {
            SqlInjectionModel model = new SqlInjectionModel();
            return View(model);
        }

        public ActionResult Login(LoginModel model)
        {
            
            if(model.UserName != null)
            {
                logger.Info("User trying to login with, " + model.UserName + "as Username");

                //After succesfull login 

                HttpContext.Session.SetString("username", model.UserName);

                return View("UserEdit");
            }
            else
            {
                return View("Login");
            }
            
        }



        public ActionResult UpdateUser(SqlInjectionModel model)
        {
            
            return null;
        }

        public ActionResult UserEdit()
        {
            if(HttpContext.Session.GetString("username") == null)
            {
                logger.Info("User tried accessing site without being logged in");

                return View("Login");
            }

            // Da User usehole wo username het vode Session  und denn is model Abfülle und zwar ines Sqlinjectionmodel
            // Sqlin model = new Sqletc
            // model.username = db.username
            //model.email = db.email
            return View("UserEdit"/*, model*/);
        }

        public ActionResult Save(SqlInjectionModel model)
        {
            if (TryValidateModel(model))
            {
                return View("Login");

            }
            else
            {
                return View("Index", model);
            }
        }
    }
}