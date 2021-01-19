using Microsoft.AspNetCore.Mvc;
using InventoryService.Data;
using System.Linq;
namespace InventoryService.Controllers { [ApiController] [Route("[controller]")] public class ItemsController : ControllerBase { private readonly InventoryContext _ctx; public ItemsController(InventoryContext ctx) { _ctx = ctx; } [HttpGet] public IActionResult Get() => Ok(_ctx.Items.ToList()); } }