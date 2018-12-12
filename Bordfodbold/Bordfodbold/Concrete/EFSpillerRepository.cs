using Bordfodbold.Abstract;
using Bordfodbold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bordfodbold.Concrete {
  public class EFSpillerRepository : ISpillerRepository {
    private EFDbContext context = new EFDbContext();
    public IEnumerable<Spiller> Spillere {
      get { return context.Spillere; }
    }
    public void SaveSpiller(Spiller spiller) {
      if (spiller.SpillerID == 0) {
        context.Spillere.Add(spiller);
      } 
      else {
        Spiller dbEntry = context.Spillere.Find(spiller.SpillerID);
        if (dbEntry != null) {
          dbEntry.Spiller_Name = spiller.Spiller_Name;
          dbEntry.Spiller_Maal = spiller.Spiller_Maal;
          dbEntry.Spiller_Kampe = spiller.Spiller_Kampe;
        }
      }

      context.SaveChanges();
    }

    public Spiller DeleteSpiller(int spillerID) {
      Spiller dbEntry = context.Spillere.Find(spillerID);
      if (dbEntry != null) {
        context.Spillere.Remove(dbEntry);
        context.SaveChanges();
      }
      return dbEntry;
    }
  }
}