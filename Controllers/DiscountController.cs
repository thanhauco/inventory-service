using Microsoft.AspNetCore.Mvc;
using InventoryService.Services;
using InventoryService.Models;
namespace InventoryService.Controllers { [ApiController] [Route("[controller]")] public class DiscountController : ControllerBase { [HttpPost] public IActionResult Calculate(Item i, string code) { return Ok(new DiscountService().Apply(i, code)); } } }