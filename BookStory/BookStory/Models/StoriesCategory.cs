using System;
using System.Collections.Generic;

#nullable disable

namespace BookStory.Models
{
    public partial class StoriesCategory
    {
        public int Scid { get; set; }
        public int Sid { get; set; }
        public int Cid { get; set; }

        public virtual Category CidNavigation { get; set; }
        public virtual Story SidNavigation { get; set; }
    }
}
