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
        List<Spiller> spiller = new List<Spiller> {
            new Spiller {spiller_navn = "john"},
            new Spiller {spiller_navn = "patte"},
            new Spiller {spiller_navn = "glenn"},
            new Spiller {spiller_navn = "daniel"}
        
    };
    }
}