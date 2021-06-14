using System.ComponentModel.DataAnnotations;
namespace InventoryService.Models {
    public class Item {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(0, 10000)]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
    }
}