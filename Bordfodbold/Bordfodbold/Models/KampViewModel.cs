using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bordfodbold.Models {
  public class KampViewModel {
    public string Spiller1 { get; set; }
    public string Spiller2 { get; set; }
    public string Spiller3 { get; set; }
    public string Spiller4 { get; set; }
    public IEnumerable<Spiller> spillere { get; set; }

    public int rødmål { get; set; }
    public int blåmål { get; set; }
  }
}