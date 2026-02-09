
using System.ComponentModel.DataAnnotations;

namespace Productcatalog_assignment2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; } = "";

        [Range(0.01, 999999)]
        public decimal ProductPrice { get; set; }

        public string Description { get; set; } = "";

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
