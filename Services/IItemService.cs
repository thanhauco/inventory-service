using System.Threading.Tasks;
using System.Collections.Generic;
using InventoryService.Models;
namespace InventoryService.Services {
    public interface IItemService {
        Task<IEnumerable<Item>> GetAllAsync();
        // ... rest
    }
}