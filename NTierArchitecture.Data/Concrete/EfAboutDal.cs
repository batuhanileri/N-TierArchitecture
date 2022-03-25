using NTierArchitecture.Data.Abstract;
using NTierArchitecture.Entity.Concrete;

namespace NTierArchitecture.Data.Concrete
{
    public class EfAboutDal : EfEntityRepositoryBase<About>, IAboutDal
    {
        private Context _appDbContext { get => _context as Context; }
        public EfAboutDal(Context context) : base(context)
        {
        }
    }
}
