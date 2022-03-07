using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLibrary;
using MyLibrary.Model;

namespace ShopThoiTrang.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Index()
        {
            ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();
            int somautin = db.Products.Count();
            ViewBag.SoMauTin = somautin;
            return View("Index");
        }
        public ActionResult Blog(int id, int k, int? hh)
        {
            ViewBag.So = id;
            return View();
        }
    }
}