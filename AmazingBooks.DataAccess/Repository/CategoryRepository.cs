using AmazingBooks.DataAccess.Data;
using AmazingBooks.DataAccess.Repository.IRepository;
using AmazingBooks.Models;

namespace AmazingBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
