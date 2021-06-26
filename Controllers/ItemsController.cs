using InventoryService.Services;
// ... imports
public class ItemsController : ControllerBase {
    [HttpPost]
    public IActionResult Create(Item i) {
        i.Name = Sanitizer.Clean(i.Name);
        // ... rest
    }
}