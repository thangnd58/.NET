using System;
using System.Collections.Generic;

#nullable disable

namespace BookStory.Models
{
    public partial class Rating
    {
        public int CommentId { get; set; }
        public int? Uid { get; set; }
        public string CommentContent { get; set; }
        public int? Sid { get; set; }
        public int? Rating1 { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Ctid { get; set; }

        public virtual Chapter Ct { get; set; }
        public virtual Story SidNavigation { get; set; }
        public virtual User UidNavigation { get; set; }
    }
}
