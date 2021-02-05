using System.Collections.Generic;
using System.Linq;
using InventoryService.Data;
using InventoryService.Models;
namespace InventoryService.Services { public class ItemService : IItemService { private readonly InventoryContext _ctx; public ItemService(InventoryContext ctx) { _ctx = ctx; } public IEnumerable<Item> GetAll() => _ctx.Items.ToList(); public Item Get(int id) => _ctx.Items.Find(id); public void Add(Item i) { _ctx.Items.Add(i); _ctx.SaveChanges(); } } }