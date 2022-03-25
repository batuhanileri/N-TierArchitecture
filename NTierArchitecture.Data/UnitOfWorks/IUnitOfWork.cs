using NTierArchitecture.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Data.UnitOfWorks
{
    public interface IUnitOfWork
    {
        
        ICategoryDal Category { get; }
        IAboutDal About { get; }
        IContactDal Contact { get; }
        ICommentDal Comment { get; }
        IBlogDal Blog { get; }
        IWriterDal Writer { get; }
        Task CommitAsync();//implemente ettiğimiz zaman ef tarafında ki savechanges metodunu çağırıcak
        void Commit();
    }
}
