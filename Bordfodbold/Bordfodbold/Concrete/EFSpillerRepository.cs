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
  }
}