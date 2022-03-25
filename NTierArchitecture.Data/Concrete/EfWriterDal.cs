using NTierArchitecture.Data.Abstract;
using NTierArchitecture.Entity.Concrete;

namespace NTierArchitecture.Data.Concrete
{
    public class EfWriterDal : EfEntityRepositoryBase<Writer>, IWriterDal
    {
        private Context _appDbContext { get => _context as Context; }
        public EfWriterDal(Context context) : base(context)
        {
        }
    }
}
