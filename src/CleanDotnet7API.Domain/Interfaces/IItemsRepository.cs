using CleanDotnet7API.Domain.Model;

namespace CleanDotnet7API.Domain.Interfaces
{
    public interface IItemsRepository
    {
        public List<Item> GetItems();
    }
}
