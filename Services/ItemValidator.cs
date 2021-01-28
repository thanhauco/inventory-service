using InventoryService.Models;
namespace InventoryService.Services { public class ItemValidator { public bool IsValid(Item i) => !string.IsNullOrEmpty(i.Name) && i.Price > 0; } }