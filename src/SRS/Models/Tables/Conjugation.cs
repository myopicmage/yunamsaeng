namespace SRS.Models {
    public class Conjugation {
        public int id { get; set; }

        public virtual Word word { get; set; }

        public string tense { get; set; }
        public string politeness { get; set; }
        public string hangeul { get; set; }
        public string english { get; set; }
    }
}