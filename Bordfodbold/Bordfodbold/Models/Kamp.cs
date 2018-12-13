using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bordfodbold.Models {
    public class Kamp {
        [Key]
        public int Kamp_ID { get; set; }
        public string Spiller1 { get; set; }
        public string Spiller2 { get; set; }
        public string Spiller3 { get; set; }
        public string Spiller4 { get; set; }
        public int rødmål { get; set; }
        public int blåmål { get; set; }
        public DateTime Kamp_Dato { get; set; }
    }
}