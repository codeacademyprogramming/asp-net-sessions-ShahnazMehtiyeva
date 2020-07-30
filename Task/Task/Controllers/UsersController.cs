using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Attributes;

namespace Task.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            if (Session["login"] != null)
            {
                ViewBag.Logined = true;
            }
            return View();
        }
        public ActionResult About()
        {
            if (Session["login"] != null)
            {
                ViewBag.Logined = true;
            }
            return View();
        }
        public ActionResult Blog()
        {
            if (Session["login"] != null)
            {
                ViewBag.Logined = true;
            }
            return View();
        }
        public ActionResult Contact()
        {
            if (Session["login"] != null)
            {
                ViewBag.Logined = true;
            }
            return View();
        }

        [Auth]
        public ActionResult Courses()
        {
            if (Session["login"] != null)
            {
                ViewBag.Logined = true;
            }
            return View();
        }
        public ActionResult Blog_details()
        {
            if (Session["login"] != null)
            {
                ViewBag.Logined = true;
            }
            return View();
        }
        public ActionResult Elements()
        {
            if (Session["login"] != null)
            {
                ViewBag.Logined = true;
            }
            return View();
        }

        [Auth]
        public ActionResult Instructor()
        {
            if (Session["login"] != null)
            {
                ViewBag.Logined = true;
            }
            return View();
        }
        [Auth]
        public ActionResult Logout()
        {
            if (Session["login"] != null)
            {
                ViewBag.Logined = true;
            }
            Session.Clear();

            return RedirectToAction("Index", "Users");
        }
    }
}