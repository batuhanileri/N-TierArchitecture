using NTierArchitecture.Business.Abstract;
using NTierArchitecture.Business.Services;
using NTierArchitecture.Core.Data;
using NTierArchitecture.Data.UnitOfWorks;
using NTierArchitecture.Entity.Concrete;

namespace NTierArchitecture.Business.Concrete
{
    public class WriterManager : Service<Writer>, IWriterService
    {
        public WriterManager(IUnitOfWork unitOfWork, IEntityRepository<Writer> repository) : base(unitOfWork, repository)
        {
        }
    }
}
