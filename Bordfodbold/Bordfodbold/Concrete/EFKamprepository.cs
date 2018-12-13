using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bordfodbold.Abstract;
using Bordfodbold.Models;

namespace Bordfodbold.Concrete {
    public class EFKamprepository : IKampRepository {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Kamp> kampe {
            get { return context.Kampe;  }
        }
        //gemmer kamp i en repository
        public void SaveKamp(Kamp match) {
            if (match.Kamp_ID==0) {
                context.Kampe.Add(match);
            } else {
                Kamp DBEntry = context.Kampe.Find(match.Kamp_ID);
                if(DBEntry != null) {
                    DBEntry.Spiller1 = match.Spiller1;
                    DBEntry.Spiller2 = match.Spiller2;
                    DBEntry.Spiller3 = match.Spiller3;
                    DBEntry.Spiller4 = match.Spiller4;
                    DBEntry.blåmål = match.blåmål;
                    DBEntry.rødmål = match.rødmål;
                    DBEntry.Kamp_Dato = match.Kamp_Dato;

                }
            }
            context.SaveChanges();

        }
    public void gemKamp(Kamp kamp) {
      context.Kampe.Add(kamp);
      context.SaveChanges();
    }

    }
}