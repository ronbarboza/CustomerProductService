namespace OrderManagementService.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public double ProductqtyOrdered { get; set; }

    }
}
