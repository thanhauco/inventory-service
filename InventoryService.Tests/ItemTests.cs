using Xunit;
using InventoryService.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
public class ItemTests {
    [Fact]
    public void TestValidation() {
        var i = new Item { Name = "" };
        var ctx = new ValidationContext(i);
        var results = new List<ValidationResult>();
        Assert.False(Validator.TryValidateObject(i, ctx, results, true));
    }
}