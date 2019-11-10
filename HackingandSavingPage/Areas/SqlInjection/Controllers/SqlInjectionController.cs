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
                logger.Info("User trying to loging with, " + model.UserName + "as Username");

                HackingandSavingPageUserDao dao = new HackingandSavingPageUserDao();

                if (dao.existsUser(model)) {
                    HttpContext.Session.SetString("username", model.UserName);
                    logger.Info("User succesfully logged in with, " + model.UserName + "as Username");
                    return View("UserEdit");
                } else {
                    logger.Info("User failed login with, " + model.UserName + "as Username");
                    return View("Login");
                }

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
                logger.Warning("User tried accessing site without being logged in");

                return View("Login");
            }

            HackingandSavingPageUserDao hackingandSavingPageUserDao = new HackingandSavingPageUserDao();
            if (hackingandSavingPageUserDao.updateUser(HttpContext.Session.GetString("username"))) {
                return View("UserEdit");
            } else {
                return View("Login");
            }
            
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