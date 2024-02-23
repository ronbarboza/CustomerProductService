using System.ComponentModel.DataAnnotations;

namespace CustomerProductService.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }

        [Required]
        public string CustomerName { get; set; } 
        [Required]
        public string CustomerEmail { get; set; } 
        public string CustomerPhone { get; set; } 
        public string CustomerCity { get; set; } 
        public string CustomerState { get; set; } 
        public string CustomerPostalCode { get; set; } 
        
    }
}
