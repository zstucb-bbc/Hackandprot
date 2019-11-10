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

                HackingandSavingPageUserDao dao = new HackingandSavingPageUserDao();

                if (dao.existsUser(model)) {
                    HttpContext.Session.SetString("username", model.UserName);

                    return View("UserEdit");
                } else {
                    return View("Login");
                }

            }
            else
            {
                return View("Login");
            }
            
        }

        public ActionResult UserEdit()
        {
            if(HttpContext.Session.GetString("username") == null)
            {
                logger.Info("User tried accessing site without being logged in");

                return View("Login");
            }

            HackingandSavingPageUserDao hackingandSavingPageUserDao = new HackingandSavingPageUserDao();
            if (hackingandSavingPageUserDao.updateUser(HttpContext.Session.GetString("username"))) {
                return View("UserEdit");
            } else {
                return View("Login");
            }
            
        }

        public ActionResult UpdateUser(SqlInjectionModel model)
        {
            return View("UserEdit");
        }

        public ActionResult Save(SqlInjectionModel model)
        {
            
            return View("Index", model);
        }

        
    }
}