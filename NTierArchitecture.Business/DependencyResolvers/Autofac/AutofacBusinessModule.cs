using Autofac;
using NTierArchitecture.Business.Abstract;
using NTierArchitecture.Business.Concrete;
using NTierArchitecture.Business.Services;
using NTierArchitecture.Core.Business;
using NTierArchitecture.Core.Data;
using NTierArchitecture.Data.Concrete;
using NTierArchitecture.Data.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>));
            builder.RegisterGeneric(typeof(EfEntityRepositoryBase<>)).As(typeof(IEntityRepository<>));

            builder.RegisterType<CategoryManager>().As<ICategoryService>();

            builder.RegisterType<AboutManager>().As<IAboutService>();
            builder.RegisterType<BlogManager>().As<IBlogService>();
            builder.RegisterType<CommentManager>().As<ICommentService>();
            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<WriterManager>().As<IWriterService>();

           

           
        }

    }
}
