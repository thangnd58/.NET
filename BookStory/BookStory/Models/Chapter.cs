using System;
using System.Collections.Generic;

#nullable disable

namespace BookStory.Models
{
    public partial class Chapter
    {
        public Chapter()
        {
            Ratings = new HashSet<Rating>();
            Readings = new HashSet<Reading>();
        }

        public int Ctid { get; set; }
        public string Name { get; set; }
        public string Subname { get; set; }
        public string Chapnumber { get; set; }
        public string Content { get; set; }
        public int Sid { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Story SidNavigation { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Reading> Readings { get; set; }
    }
}
