using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bordfodbold.Models {
    public class Kamp {

        public int Kamp_ID { get; set; }
        public int Spiller1_ID { get; set; }
        public int Spiller2_ID { get; set; }
        public int Spiller3_ID { get; set; }
        public int Spiller4_ID { get; set; }
        public int rødmål { get; set; }
        public int blåmål { get; set; }
        public DateTime Dato { get; set; }
        public int Tid { get; set; }
    }
}