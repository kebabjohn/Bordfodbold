using Bordfodbold.Abstract;
using Bordfodbold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Bordfodbold.Controllers {
  public class HomeController : Controller {


        private ISpillerRepository spilrepository;
        private IKampRepository kamprepository;

        public HomeController(ISpillerRepository spillerRepository, IKampRepository kampRepository)
        {
            this.spilrepository = spillerRepository;
            this.kamprepository = kampRepository;
        }
      
     
        public ActionResult Index() {
      KampViewModel viewmodel = new KampViewModel();
      viewmodel.spillere = spilrepository.Spillere;
      
      return View(viewmodel);
    }


   [HttpPost]    
    public ActionResult GemKamp(KampViewModel viewmodel) {
      
      Kamp kamp = new Kamp();
      
      kamp.Spiller1 = viewmodel.Spiller1;
      kamp.Spiller2 = viewmodel.Spiller2;
      kamp.Spiller3 = viewmodel.Spiller3;
      kamp.Spiller4 = viewmodel.Spiller4;

      kamp.rødmål = viewmodel.rødmål;
      kamp.blåmål = viewmodel.blåmål;
      kamp.Kamp_Dato = DateTime.Now;
      
      return View(kamp);
        }
    [HttpPost]
    public ActionResult AfslutKamp(Kamp kamp) {
            Spiller p1 = spilrepository.Spillere.FirstOrDefault(s => s.Spiller_Name == kamp.Spiller1);
            Spiller p2 = spilrepository.Spillere.FirstOrDefault(s => s.Spiller_Name == kamp.Spiller2);
            Spiller p3 = spilrepository.Spillere.FirstOrDefault(s => s.Spiller_Name == kamp.Spiller3);
            Spiller p4 = spilrepository.Spillere.FirstOrDefault(s => s.Spiller_Name == kamp.Spiller4);

            p1.Spiller_Kampe++;
            p1.Spiller_Maal += kamp.rødmål;
            spilrepository.SaveSpiller(p1);
            p2.Spiller_Kampe++;
            p2.Spiller_Maal += kamp.rødmål;
            spilrepository.SaveSpiller(p2);
            p3.Spiller_Kampe++;
            p3.Spiller_Maal += kamp.blåmål;
            spilrepository.SaveSpiller(p3);
            p4.Spiller_Kampe++;
            p4.Spiller_Maal += kamp.blåmål;
            spilrepository.SaveSpiller(p4);

            kamprepository.gemKamp(kamp);
      return RedirectToAction("Index", "Home");
    }
  }
}