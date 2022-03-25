using NTierArchitecture.Data.Abstract;
using NTierArchitecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Data.Concrete
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category>, ICategoryDal
    {
        private Context _appDbContext { get => _context as Context; }
        public EfCategoryDal(Context context) : base(context)
        {
        }
    }
}
