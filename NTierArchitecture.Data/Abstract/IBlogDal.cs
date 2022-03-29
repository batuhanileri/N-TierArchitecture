using NTierArchitecture.Core.Data;
using NTierArchitecture.Entity.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NTierArchitecture.Data.Abstract
{
    public interface IBlogDal : IEntityRepository<Blog>
    {
        Task<List<Blog>> GetListWithCategory();
    }
}
