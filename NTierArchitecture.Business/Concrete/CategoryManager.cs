using NTierArchitecture.Business.Abstract;
using NTierArchitecture.Business.Services;
using NTierArchitecture.Core.Data;
using NTierArchitecture.Data.UnitOfWorks;
using NTierArchitecture.Entity.Concrete;

namespace NTierArchitecture.Business.Concrete
{
    public class CategoryManager : Service<Category>, ICategoryService
    {
        public CategoryManager(IUnitOfWork unitOfWork, IEntityRepository<Category> repository) : base(unitOfWork, repository)
        {
        }      
    }
}
