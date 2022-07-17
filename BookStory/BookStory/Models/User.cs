using System;
using System.Collections.Generic;

#nullable disable

namespace BookStory.Models
{
    public partial class User
    {
        public User()
        {
            Ratings = new HashSet<Rating>();
            Readings = new HashSet<Reading>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Reading> Readings { get; set; }
    }
}
