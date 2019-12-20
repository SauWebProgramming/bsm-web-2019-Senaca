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
                                    EklenmeTarihi = i.EklenmeTarihi,
                                    Onay = i.Onay,
                                    Anasayfa = i.Anasayfa


                                });


            return View(blogs.ToList());
        }

       

        public ActionResult Contact()
        {

            return View();
        }
    }
}