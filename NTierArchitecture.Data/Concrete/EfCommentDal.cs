using NTierArchitecture.Data.Abstract;
using NTierArchitecture.Entity.Concrete;

namespace NTierArchitecture.Data.Concrete
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment>, ICommentDal
    {
        private Context _appDbContext { get => _context as Context; }
        public EfCommentDal(Context context) : base(context)
        {
        }
    }
}
