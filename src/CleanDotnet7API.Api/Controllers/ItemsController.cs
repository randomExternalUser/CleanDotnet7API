using CleanDotnet7API.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanDotnet7API.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            var items = _itemsRepository.GetItems();
            return Ok(items);
        }
    }
}
