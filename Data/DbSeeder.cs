using System.Linq;
using InventoryService.Models;
namespace InventoryService.Data { public static class DbSeeder { public static void Seed(InventoryContext ctx) { if(!ctx.Items.Any()) { ctx.Items.Add(new Item { Name="Laptop", Price=1000, Stock=10, Category="Tech" }); ctx.SaveChanges(); } } } }