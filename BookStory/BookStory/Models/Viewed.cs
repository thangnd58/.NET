using System;
using System.Collections.Generic;

#nullable disable

namespace BookStory.Models
{
    public partial class Viewed
    {
        public int Vid { get; set; }
        public int Sid { get; set; }
        public int Ctid { get; set; }
        public int Uid { get; set; }

        public virtual Chapter Ct { get; set; }
        public virtual Story SidNavigation { get; set; }
        public virtual User UidNavigation { get; set; }
    }
}
