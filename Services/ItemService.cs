using System.Collections.Generic;
using System.Linq;
using InventoryService.Data;
using InventoryService.Models;
namespace InventoryService.Services { public class ItemService : IItemService { private readonly InventoryContext _ctx; private readonly CacheService _cache = new CacheService(); public ItemService(InventoryContext ctx) { _ctx = ctx; } public IEnumerable<Item> GetAll() => _ctx.Items.ToList(); public Item Get(int id) { var c = _cache.Get(id.ToString()); if(c!=null) return (Item)c; var i = _ctx.Items.Find(id); if(i!=null) _cache.Set(id.ToString(), i); return i; } public void Add(Item i) { _ctx.Items.Add(i); _ctx.SaveChanges(); } } }