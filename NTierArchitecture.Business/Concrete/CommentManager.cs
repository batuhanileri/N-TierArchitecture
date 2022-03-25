using NTierArchitecture.Business.Abstract;
using NTierArchitecture.Business.Services;
using NTierArchitecture.Core.Data;
using NTierArchitecture.Data.UnitOfWorks;
using NTierArchitecture.Entity.Concrete;

namespace NTierArchitecture.Business.Concrete
{
    public class CommentManager : Service<Comment>, ICommentService
    {
        public CommentManager(IUnitOfWork unitOfWork, IEntityRepository<Comment> repository) : base(unitOfWork, repository)
        {
        }
    }
}
