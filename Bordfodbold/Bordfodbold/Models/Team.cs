using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bordfodbold.Models {
    public class Team {
        public int Team_ID { get; set; }
        public int Team_Name { get; set; } // er enten 1 eller 0
        public int Spiller1_ID { get; set; }
        public int Spiller2_ID { get; set; }
        public int Team_Maal { get; set; }


    }
}