using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRS.Models.Tables {
    public class SRSContext : DbContext {
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Conjugation> Conjugations { get; set; }
        public virtual DbSet<Sentence> Sentences { get; set; }
        public virtual DbSet<Word> Words { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Queue> Queues { get; set; }
    }
}
