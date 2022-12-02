using CleanDotnet7API.Domain.Interfaces;
using CleanDotnet7API.Domain.Model;

namespace CleanDotnet7API.Application.Handlers
{
    public interface IItemsHandler
    {
        List<Item> GetItems();
    }
    public class ItemsHandler : IItemsHandler
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsHandler(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }
        public List<Item> GetItems()
        {
            return _itemsRepository.GetItems();
        }
    }
}