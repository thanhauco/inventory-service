using Microsoft.AspNetCore.Mvc;
// ... imports
namespace InventoryService.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase {
        // ... existing
        [HttpGet]
        [ResponseCache(Duration = 60)]
        public IActionResult Get() => Ok(_ctx.Items.ToList());
        // ... rest
    }
}