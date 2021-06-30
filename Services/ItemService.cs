using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
// ... imports
public class ItemService : IItemService {
    // ... existing
    public async Task<IEnumerable<Item>> GetAllAsync() => await _ctx.Items.ToListAsync();
}