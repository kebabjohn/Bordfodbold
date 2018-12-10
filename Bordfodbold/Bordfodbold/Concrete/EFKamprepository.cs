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
                    DBEntry.Spiller1_ID = match.Spiller1_ID;
                    DBEntry.Spiller2_ID = match.Spiller2_ID;
                    DBEntry.Spiller4_ID = match.Spiller3_ID;
                    DBEntry.Spiller4_ID = match.Spiller4_ID;
                    DBEntry.Dato = match.Dato;
                    DBEntry.Tid = match.Tid;

                }
            }
            context.SaveChanges();

        }

    }
}