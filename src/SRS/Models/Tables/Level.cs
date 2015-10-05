using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRS.Models {
    public class Level {
        public int id { get; set; }

        public string name { get; set; }
        public int nextmonths { get; set; }
        public int nextdays { get; set; }
        public int nexthours { get; set; }
        public int nextminutes { get; set; }
    }
}
