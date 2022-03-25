using NTierArchitecture.Business.Abstract;
using NTierArchitecture.Business.Services;
using NTierArchitecture.Core.Data;
using NTierArchitecture.Data.UnitOfWorks;
using NTierArchitecture.Entity.Concrete;

namespace NTierArchitecture.Business.Concrete
{
    public class ContactManager : Service<Contact>, IContactService
    {
        public ContactManager(IUnitOfWork unitOfWork, IEntityRepository<Contact> repository) : base(unitOfWork, repository)
        {
        }
    }
}
