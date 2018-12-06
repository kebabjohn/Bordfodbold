using Bordfodbold.Abstract;
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

    private ISpillerRepository repository;

    public GameController(ISpillerRepository spillerRepository) {
      repository = spillerRepository;
    }
    // GET: Game
    public ActionResult GameScreen(Spiller spiller)
        {
      List<Spiller> searchedSpillerList = new List<Spiller>();

      if (spiller.Spiller_Name != null && spiller.Spiller_Maal != 0 && spiller.Spiller_Kampe != 0) {
        foreach (Spiller s in repository.Spillere) {
          if (spiller.Spiller_Name == s.Spiller_Name && spiller.Spiller_Maal == s.Spiller_Maal && spiller.Spiller_Kampe == s.Spiller_Kampe) {
            searchedSpillerList.Add(s);
          }
        }
      } else if (spiller.Spiller_Name != null) {
        foreach (Spiller s in repository.Spillere) {
          if (spiller.Spiller_Name == s.Spiller_Name) {
            searchedSpillerList.Add(s);
          }
        }
      } else if (spiller.Spiller_Maal != 0) {
        foreach (Spiller s in repository.Spillere) {
          if (spiller.Spiller_Maal == s.Spiller_Maal) {
            searchedSpillerList.Add(s);
          }
        }
      } else if (spiller.Spiller_Kampe != 0) {
        foreach (Spiller s in repository.Spillere) {
          if (spiller.Spiller_Kampe == s.Spiller_Kampe) {
            searchedSpillerList.Add(s);
          }
        }
      }

      return View(searchedSpillerList);




    }

  }
    
}