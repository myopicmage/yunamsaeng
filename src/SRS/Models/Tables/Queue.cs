using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRS.Models.Tables {
    public class Queue {
        public int id { get; set; }

        public virtual User user { get; set; }
        public virtual Word word { get; set; }
        public DateTime nextreview { get; set; }
        public int level { get; set; }
    }
}
