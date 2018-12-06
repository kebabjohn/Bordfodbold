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
                    DBEntry.Hold1_ID = match.Hold1_ID;
                    DBEntry.Hold2_ID = match.Hold2_ID;
                    DBEntry.Dato = match.Dato;
                    DBEntry.Tid = match.Tid;

                }
            }
            context.SaveChanges();

        }

    }
}