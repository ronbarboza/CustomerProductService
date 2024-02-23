using System.ComponentModel.DataAnnotations;

namespace CustomerProductService.Models
{
    public class CustomerPaymentInfo
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string CustomerCardNum { get; set; }
    }
}
