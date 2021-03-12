using System.Collections.Generic;
using System.Linq;
namespace InventoryService.Models { public class PagedList<T> { public List<T> Items { get; set; } public int Total { get; set; } public PagedList(IEnumerable<T> items, int page, int size) { Total = items.Count(); Items = items.Skip((page-1)*size).Take(size).ToList(); } } }