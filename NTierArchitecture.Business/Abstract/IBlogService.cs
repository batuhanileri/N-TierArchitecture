using NTierArchitecture.Core.Business;
using NTierArchitecture.Entity.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Abstract
{
    public interface IBlogService : IService<Blog>
    {
        Task<List<Blog>> GetListWithCategory();

    }
}
