using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bordfodbold.Abstract;
using Bordfodbold.Models;


namespace Bordfodbold.Controllers{
    [Authorize]
    public class AdminController : Controller{


        private ISpillerRepository repos;

        public AdminController(ISpillerRepository repo) {
            this.repos = repo;
        }

        // GET: Admin
        public ActionResult Admin(){


            return View(repos.Spillere);
        }
    }
}