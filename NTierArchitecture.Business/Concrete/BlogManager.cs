using NTierArchitecture.Business.Abstract;
using NTierArchitecture.Business.Services;
using NTierArchitecture.Core.Data;
using NTierArchitecture.Data.UnitOfWorks;
using NTierArchitecture.Entity.Concrete;

namespace NTierArchitecture.Business.Concrete
{
    public class BlogManager : Service<Blog>, IBlogService
    {
        public BlogManager(IUnitOfWork unitOfWork, IEntityRepository<Blog> repository) : base(unitOfWork, repository)
        {
        }
    }
}
