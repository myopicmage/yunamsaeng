using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRS.Models {
    public class Word {
        public int id { get; set; }

        public string hangeul { get; set; }
        public string english { get; set; }
        public string definition { get; set; }

        public virtual ICollection<Conjugation> conjugations { get; set; }
        public virtual ICollection<Sentence> sentences { get; set; }
    }
}
