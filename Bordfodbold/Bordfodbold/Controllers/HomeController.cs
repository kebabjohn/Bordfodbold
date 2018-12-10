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

        public HomeController(ISpillerRepository spillerRepository)
        {
            spilrepository = spillerRepository;
        }


        public ActionResult Index(Spiller spiller) {

            List<Spiller> søgSpillerList = new List<Spiller>();

            if (spiller.Spiller_Name != null && spiller.Spiller_Maal != 0 && spiller.Spiller_Kampe != 0)
            {
                foreach (Spiller s in spilrepository.Spillere)
                {
                    if (spiller.Spiller_Name == s.Spiller_Name && spiller.Spiller_Maal == s.Spiller_Maal && spiller.Spiller_Kampe == s.Spiller_Kampe)
                    {
                        søgSpillerList.Add(s);
                    }
                }
            }
            else if (spiller.Spiller_Name != null)
            {
                foreach (Spiller s in spilrepository.Spillere)
                {
                    if (spiller.Spiller_Name == s.Spiller_Name)
                    {
                        søgSpillerList.Add(s);
                    }
                }
            }
            else if (spiller.Spiller_Maal != 0)
            {
                foreach (Spiller s in spilrepository.Spillere)
                {
                    if (spiller.Spiller_Maal == s.Spiller_Maal)
                    {
                        søgSpillerList.Add(s);
                    }
                }
            }
            else if (spiller.Spiller_Kampe != 0)
            {
                foreach (Spiller s in spilrepository.Spillere)
                {
                    if (spiller.Spiller_Kampe == s.Spiller_Kampe)
                    {
                        søgSpillerList.Add(s);
                    }
                }
            }

            return View(spilrepository.Spillere);
    }

    //public ActionResult Database() {
    //        BFDBEntities entity = new BFDBEntities();
    //        var getspillere = entity.Spillers.ToList();
    //        SelectList list = new SelectList(getspillere,"Id", "Name");
    //        ViewBag.spillerelistname = list;


    //  return View("Index");
    //}

    [HttpPost]    //der sendes info fra system til serverdatabase 
    public ActionResult GemKamp( int rødmål, int blåmål) {
            int SpillerID = 0;
            Kamp match = new Kamp();
            match.rødmål = rødmål;
            match.blåmål = blåmål;


            return View("Index",match);
        }
  }
}