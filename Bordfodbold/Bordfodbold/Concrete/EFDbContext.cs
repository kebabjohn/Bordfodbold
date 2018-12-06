using Bordfodbold.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bordfodbold.Concrete {
  public class EFDbContext : DbContext {
    public DbSet<Spiller> Spillere { get; set; }
    public DbSet<Kamp> Kampe { get; set; }

    }
}