using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bordfodbold.Abstract;
using Bordfodbold.Models;


namespace Bordfodbold.Controllers{

  public class AdminController : Controller {


    private ISpillerRepository repos;

    public AdminController(ISpillerRepository repo) {
      this.repos = repo;
    }

    // GET: Admin
    public ActionResult Admin(Spiller spiller) {
      List<Spiller> searchedSpillerList = new List<Spiller>();
      
      if (spiller.Spiller_Name != null) {
        foreach (Spiller s in repos.Spillere) {
           
          if (spiller.Spiller_Name == s.Spiller_Name) {
            searchedSpillerList.Add(s);
          }
        }
        return View(searchedSpillerList);

      } else
        return View(repos.Spillere);
    }

    public ViewResult Edit(int SpillerId) {
      Spiller spiller = repos.Spillere.FirstOrDefault(s => s.SpillerID == SpillerId);
      return View(spiller);
    }
    [HttpPost]
    public ActionResult Edit(Spiller spiller) {
      if (ModelState.IsValid) {
        repos.SaveSpiller(spiller);
        TempData["message"] = spiller.Spiller_Name + " has been saved";
        return RedirectToAction("Admin");
      } else {
        return View(spiller);
      }
    }

    public ViewResult Create() {
      return View("Edit", new Spiller());
    }

    [HttpPost]
    public ActionResult Delete(int spillerID) {
      Spiller deletedSpiller = repos.DeleteSpiller(spillerID);
      if (deletedSpiller != null) {
        TempData["message"] = deletedSpiller.Spiller_Name + " was deleted";
      }
      return RedirectToAction("Admin");
    }
  }
}