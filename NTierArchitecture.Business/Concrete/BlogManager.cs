using NTierArchitecture.Business.Abstract;
using NTierArchitecture.Business.Services;
using NTierArchitecture.Core.Data;
using NTierArchitecture.Data.UnitOfWorks;
using NTierArchitecture.Entity.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Concrete
{
    public class BlogManager : Service<Blog>, IBlogService
    {
        public BlogManager(IUnitOfWork unitOfWork, IEntityRepository<Blog> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<List<Blog>> GetListWithCategory()
        {

            return await _unitOfWork.Blog.GetListWithCategory();
        }
    }
}
