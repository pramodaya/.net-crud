using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PlayerController : Controller
    {
        DataContext db = new DataContext();
        // GET: Player
        public ActionResult Index()
        {
            List<Player> player = db.player.ToList();
            return View(player);
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Player player)
        {
            db.player.Add(player);
            db.SaveChanges();
            return View();
        }

        public ActionResult Edit(int Id) {
            Player player = db.player.Where(x => x.Id == Id).SingleOrDefault();
            return View(player);
        }


    }
}