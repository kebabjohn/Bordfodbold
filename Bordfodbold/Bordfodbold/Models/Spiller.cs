using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bordfodbold.Models
{
    public class Spiller
    {
        public int spiller_id { get; set; }

        public string spiller_navn { get; set; }

        public int spiller_mål { get; set; }

        public int spillede_kampe { get; set; }


    }
}