using System;

namespace NTierArchitecture.Entity.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }


    }
}
