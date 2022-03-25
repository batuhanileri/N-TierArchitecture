using System;
using System.ComponentModel.DataAnnotations;

namespace NTierArchitecture.Entity.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
