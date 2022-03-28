using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entity.Dto
{
    public class CategoryDto
    {
        public int CategoryId { set; get; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
