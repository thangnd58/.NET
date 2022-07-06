using System;
using System.Collections.Generic;

#nullable disable

namespace BookStory.Models
{
    public partial class Chapter
    {
        public Chapter()
        {
            Readings = new HashSet<Reading>();
            Vieweds = new HashSet<Viewed>();
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
        public virtual ICollection<Reading> Readings { get; set; }
        public virtual ICollection<Viewed> Vieweds { get; set; }
    }
}
