using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRS.Models {
    public class Review {
        public int id { get; set; }
        
        public Word word { get; set; }
        public DateTime time { get; set; }
        public bool pass { get; set; }
    }
}
