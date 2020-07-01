using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6_Git_Testing.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            LinkHubDbEntities db = new LinkHubDbEntities();
            ViewBag.CategoryID = new SelectList(db.tbl_Category, "CategoryID", "CategoryName");
            return View();
        }


        [HttpPost]
        public ActionResult Create(tbl_Url objURL)
        {
            //LinkHubDbEntities db = new LinkHubDbEntities();
            //ViewBag.CategoryID = new SelectList(db.tbl_Category, "CategoryID", "CategoryName");
            return View();
        }

    }
}