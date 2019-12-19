using BlogBASC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogBASC.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext Context = new BlogContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Blog()
        {
            var blogs = Context.Bloglar
                                .Where(i => i.Onay == true && i.Anasayfa == true)
                                .Select(i => new BlogModel()
                                {
                                    Id = i.Id,
                                    Baslik = i.Baslik,
                                    Aciklama = i.Aciklama,
                                    Resim = i.Resim,
                                    Icerik = i.Icerik.Length > 210 ? i.Baslik.Substring(0, 210) + "..." : i.Icerik,
                                    EklenmeTarihi = i.EklenmeTarihi,
                                    Onay = i.Onay,
                                    Anasayfa = i.Anasayfa


                                });


            return View(blogs.ToList());
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
    }
}