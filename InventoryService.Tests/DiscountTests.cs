using Xunit;
using InventoryService.Services;
using InventoryService.Models;
public class DiscountTests { [Fact] public void TestSale() { var s = new DiscountService(); var i = new Item { Price = 100 }; Assert.Equal(90, s.Apply(i, "SALE")); } }