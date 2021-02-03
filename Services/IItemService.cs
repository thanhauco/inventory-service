using System.Collections.Generic;
using InventoryService.Models;
namespace InventoryService.Services { public interface IItemService { IEnumerable<Item> GetAll(); Item Get(int id); void Add(Item i); } }