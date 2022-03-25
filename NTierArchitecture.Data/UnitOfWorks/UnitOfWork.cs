using NTierArchitecture.Data.Abstract;
using NTierArchitecture.Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
    
        private EfCategoryDal _categoryRepository;

        private EfAboutDal _aboutRepository;

        private EfContactDal _contactRepository;

        private EfCommentDal _commentRepository;

        private EfBlogDal _blogRepository;

        private EfWriterDal _writerRepository;

        public IAboutDal About => _aboutRepository = _aboutRepository ?? new EfAboutDal(_context);
        public ICategoryDal Category => _categoryRepository = _categoryRepository ?? new EfCategoryDal(_context);
        public IContactDal Contact => _contactRepository = _contactRepository ?? new EfContactDal(_context);
        public ICommentDal Comment => _commentRepository= _commentRepository?? new EfCommentDal(_context);
        public IBlogDal Blog => _blogRepository = _blogRepository ?? new EfBlogDal(_context);
        public IWriterDal Writer => _writerRepository = _writerRepository ?? new EfWriterDal(_context);

        

        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
