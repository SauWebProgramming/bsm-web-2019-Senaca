using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogBASC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bloglar()
        {
            return View();
        }
        public ActionResult Kategoriler()
        {
            return View();
        }

    }
}