using NTierArchitecture.Data.Abstract;
using NTierArchitecture.Entity.Concrete;

namespace NTierArchitecture.Data.Concrete
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog>, IBlogDal
    {
        private Context _appDbContext { get => _context as Context; }
        public EfBlogDal(Context context) : base(context)
        {
        }
    }
}
