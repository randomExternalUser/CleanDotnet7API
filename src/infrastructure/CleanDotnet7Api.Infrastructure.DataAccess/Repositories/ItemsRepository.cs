using CleanDotnet7API.Domain.Interfaces;
using CleanDotnet7API.Domain.Model;

namespace CleanDotnet7Api.Infrastructure.DataAccess.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly ApplicationDbContext _db;

        public ItemsRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<Item> GetItems()
        {
            return _db.Items;
        }
    }
}
