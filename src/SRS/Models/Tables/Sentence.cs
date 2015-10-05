using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRS.Models {
    public class Sentence {
        public int id { get; set; }

        public virtual ICollection<Word> words { get; set; }

        public string hangeul { get; set; }
        public string english { get; set; }
    }
}
