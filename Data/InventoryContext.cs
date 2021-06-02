using Microsoft.EntityFrameworkCore;
// ... imports
namespace InventoryService.Data {
    public class InventoryContext : DbContext {
        // ... existing
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Item>().HasIndex(i => i.Name);
        }
    }
}