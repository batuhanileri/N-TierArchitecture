using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NTierArchitecture.Entity.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public string ThumbnailImage { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; } // Bir bloğa birden fazla yorum yapılabilir 1-n
                                                    // 1 = Blog
                                                    // n = Comment

    }
}
