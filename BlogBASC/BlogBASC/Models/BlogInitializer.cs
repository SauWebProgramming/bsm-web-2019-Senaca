using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogBASC.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() { KategoriAdi="Photography" },
                new Category() { KategoriAdi="Travel" },
                new Category() { KategoriAdi="Cinema" },
                new Category() { KategoriAdi="Books" },
                new Category() { KategoriAdi="Science" },
            };
            foreach(var kategori in kategoriler)
            {
                context.Kategoriler.Add(kategori);
            }
            context.SaveChanges();
            List<Blog> bloglar = new List<Blog>()
            {

                 new Blog() { Baslik="Fotoğrafçılık Hakkında 10 Şey", Aciklama="Bu yazımda size fotoğrafçılık hakkında önemli bulduğum bilgileri 10 madde ile paylaşacağım.", EklenmeTarihi=DateTime.Now.AddDays(-7), Anasayfa=true, Onay=true, Icerik="Bol bol fotoğraf çekmeye çalış. Kompozisyonu iyi ayarla. Objeyi ön plana çıkar", Resim="1.jpg", CategoryId=1 },
                 new Blog() { Baslik="Efes Antik Kenti", Aciklama="Bu yazımda size milattan Önce 7. bin yılda yaşamın başladığı ve yüzyıllar boyunca tüm Asya şehirlerinin yönetim yeri olan Efes’in tarihini çektiğim fotoğraflarla beraber anlatmaya çalışacağım.",EklenmeTarihi=DateTime.Now.AddDays(-15), Anasayfa=true, Onay=true, Icerik="Anadolu’nun batısında Selçuk ilçesi sınırlarında yer alan ve Efes Harabeleri de denilen Efes Antik Kenti‘nin tarihi MÖ 6000 yıllarındaki Neolitik Çağ’a kadar dayanıyor. Aynı zamanda, Antik Çağ’da İyonya denilen İzmir ve Ege şehirlerinin sahil şeridindeki 12 antik şehirden de biri. Bu nedenle topraklarımızdaki önemli tarihi kentlerden.", Resim="1.jpg", CategoryId=2 },
                 new Blog() { Baslik="Fotoğrafçılık Hakkında 10 Şey", Aciklama="Bu yazımda size fotoğrafçılık hakkında önemli bulduğum bilgileri 10 madde ile paylaşacağım.", EklenmeTarihi=DateTime.Now.AddDays(-16), Anasayfa=true, Onay=true, Icerik="Bol bol fotoğraf çekmeye çalış. Kompozisyonu iyi ayarla. Objeyi ön plana çıkar", Resim="1.jpg", CategoryId=3 },
                 new Blog() { Baslik="Efes Antik Kenti", Aciklama="Bu yazımda size milattan Önce 7. bin yılda yaşamın başladığı ve yüzyıllar boyunca tüm Asya şehirlerinin yönetim yeri olan Efes’in tarihini çektiğim fotoğraflarla beraber anlatmaya çalışacağım.",EklenmeTarihi=DateTime.Now.AddDays(-21), Anasayfa=true, Onay=true, Icerik="Anadolu’nun batısında Selçuk ilçesi sınırlarında yer alan ve Efes Harabeleri de denilen Efes Antik Kenti‘nin tarihi MÖ 6000 yıllarındaki Neolitik Çağ’a kadar dayanıyor. Aynı zamanda, Antik Çağ’da İyonya denilen İzmir ve Ege şehirlerinin sahil şeridindeki 12 antik şehirden de biri. Bu nedenle topraklarımızdaki önemli tarihi kentlerden.", Resim="1.jpg", CategoryId=4 },
                 new Blog() { Baslik="Fotoğrafçılık Hakkında 10 Şey", Aciklama="Bu yazımda size fotoğrafçılık hakkında önemli bulduğum bilgileri 10 madde ile paylaşacağım.", EklenmeTarihi=DateTime.Now.AddDays(-5), Anasayfa=true, Onay=true, Icerik="Bol bol fotoğraf çekmeye çalış. Kompozisyonu iyi ayarla. Objeyi ön plana çıkar", Resim="1.jpg", CategoryId=5 },
                 new Blog() { Baslik="Efes Antik Kenti", Aciklama="Bu yazımda size milattan Önce 7. bin yılda yaşamın başladığı ve yüzyıllar boyunca tüm Asya şehirlerinin yönetim yeri olan Efes’in tarihini çektiğim fotoğraflarla beraber anlatmaya çalışacağım.",EklenmeTarihi=DateTime.Now.AddDays(-17), Anasayfa=false, Onay=false, Icerik="Anadolu’nun batısında Selçuk ilçesi sınırlarında yer alan ve Efes Harabeleri de denilen Efes Antik Kenti‘nin tarihi MÖ 6000 yıllarındaki Neolitik Çağ’a kadar dayanıyor. Aynı zamanda, Antik Çağ’da İyonya denilen İzmir ve Ege şehirlerinin sahil şeridindeki 12 antik şehirden de biri. Bu nedenle topraklarımızdaki önemli tarihi kentlerden.", Resim="1.jpg", CategoryId=2 },
                };
            foreach (var post in bloglar)
            {
                context.Bloglar.Add(post);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}