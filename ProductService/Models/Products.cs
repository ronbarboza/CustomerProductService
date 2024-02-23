using System.ComponentModel.DataAnnotations;

namespace ProductService.Models
{
    public class Products
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductQty { get; set; }
        [Required]
        public string SKU { get; set; }
        public string productImage { get; set; }
    }
}
