using NTierArchitecture.Data.Abstract;
using NTierArchitecture.Entity.Concrete;

namespace NTierArchitecture.Data.Concrete
{
    public class EfContactDal : EfEntityRepositoryBase<Contact>, IContactDal
    {
        private Context _appDbContext { get => _context as Context; }
        public EfContactDal(Context context) : base(context)
        {
        }
    }
}
