using Xunit;
using InventoryService.Services;
using InventoryService.Models;
public class ValidatorTests { [Fact] public void TestInvalid() { var v = new ItemValidator(); Assert.False(v.IsValid(new Item())); } }