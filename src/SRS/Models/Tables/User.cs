using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRS.Models.Tables {
    public class User {
        public int id { get; set; }
        
        public string username { get; set; }
        public int level { get; set; }
        public DateTime lastreview { get; set; }
    }
}
