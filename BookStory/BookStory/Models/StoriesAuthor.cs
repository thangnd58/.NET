using System;
using System.Collections.Generic;

#nullable disable

namespace BookStory.Models
{
    public partial class StoriesAuthor
    {
        public int Said { get; set; }
        public int Sid { get; set; }
        public int Aid { get; set; }

        public virtual Author AidNavigation { get; set; }
        public virtual Story SidNavigation { get; set; }
    }
}
