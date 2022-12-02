using CleanDotnet7API.Application.Handlers;
using CleanDotnet7API.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanDotnet7API.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsHandler _itemsHanlder;

        public ItemsController(IItemsHandler itemsHanlder)
        {
            _itemsHanlder = itemsHanlder;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            var items = _itemsHanlder.GetItems();
            return Ok(items);
        }
    }
}
