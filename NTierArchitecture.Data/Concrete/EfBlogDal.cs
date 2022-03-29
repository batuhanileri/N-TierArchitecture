using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Data.Abstract;
using NTierArchitecture.Entity.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NTierArchitecture.Data.Concrete
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog>, IBlogDal
    {
        private Context _appDbContext { get => _context as Context; }
        public EfBlogDal(Context context) : base(context)
        {
        }

        public async Task<List<Blog>> GetListWithCategory()
        {
            return await _appDbContext.Blogs.Include(x => x.Category).ToListAsync();
        }
    }
}
