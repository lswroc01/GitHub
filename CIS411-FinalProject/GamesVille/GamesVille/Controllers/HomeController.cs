using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GamesVille.Models;

namespace GamesVille.Controllers
{
    public class HomeController : Controller
    {
        private GameDBContext db = new GameDBContext();

        public ActionResult Index()
        {
            return View(db.Games.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

         //GET: /Games/Details/5
        public ActionResult More(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }


        //public ActionResult More(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Game game = db.Games.Find(id);
        //    if (game == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(game);
        //}
    }
}