using System;
using System.Collections.Generic;

#nullable disable

namespace BookStory.Models
{
    public partial class User
    {
        public User()
        {
            Readings = new HashSet<Reading>();
            Vieweds = new HashSet<Viewed>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Reading> Readings { get; set; }
        public virtual ICollection<Viewed> Vieweds { get; set; }
    }
}
