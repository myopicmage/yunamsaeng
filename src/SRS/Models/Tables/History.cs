using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRS.Models {
    public class History {
        public int id { get; set; }
        public DateTime created { get; set; }
        public string createdby { get; set; }
        public string operation { get; set; }
    }
}
