﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bordfodbold.Models {
    public class Kamp {

        public int Kamp_ID { get; set; }
        public int Hold1_ID { get; set; }
        public int Hold2_ID { get; set; }
        public DateTime Dato { get; set; }
        public int Tid { get; set; }
    }
}