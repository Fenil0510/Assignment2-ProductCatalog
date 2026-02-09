
using System.ComponentModel.DataAnnotations;

namespace Productcatalog_assignment2.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; } = "";

        public List<Product> Products { get; set; } = new();
    }
}
