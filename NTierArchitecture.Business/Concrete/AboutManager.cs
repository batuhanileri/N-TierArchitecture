using NTierArchitecture.Business.Abstract;
using NTierArchitecture.Business.Services;
using NTierArchitecture.Core.Data;
using NTierArchitecture.Data.UnitOfWorks;
using NTierArchitecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Concrete
{
    public class AboutManager : Service<About>, IAboutService
    {
        public AboutManager(IUnitOfWork unitOfWork, IEntityRepository<About> repository) : base(unitOfWork, repository)
        {
        }
    }
}
