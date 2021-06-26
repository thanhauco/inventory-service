using System.Text.RegularExpressions;
namespace InventoryService.Services {
    public static class Sanitizer {
        public static string Clean(string input) => Regex.Replace(input, "<.*?>", string.Empty);
    }
}