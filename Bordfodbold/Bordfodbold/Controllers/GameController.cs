using Bordfodbold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bordfodbold.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }
        /*
        List<Spiller> spiller = new List<Spiller> {
            new Spiller {spiller_navn = "john"},
            new Spiller {spiller_navn = "patte"},
            new Spiller {spiller_navn = "glenn"},
            new Spiller {spiller_navn = "daniel"}
        
    };
    */

        public ActionResult Create(Spiller Model)
        {
            var spiller = new Spiller();
            spiller.Navn = new List<SelectListItem> {
     new SelectListItem { Value="1", Text = "John" },
     new SelectListItem { Value="2", Text = "patte" },
     new SelectListItem { Value="3", Text = "glenn" },
     new SelectListItem { Value="4", Text = "daniel" }
  };
            return View("Index", spiller);
        }

    }
}