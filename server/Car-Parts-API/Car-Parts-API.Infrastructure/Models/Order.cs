namespace Car_Parts_API.Infrastructure.Models
{
    public class Order
    {

        //This table would store detailed information about customer orders, including customer information, order date,
        //shipping address, and the specific parts that were ordered along with their quantity.

        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int PartId { get; set; }

        public DateTime OrderDate { get; set; }

        public int Quantity { get; set; }

        public decimal TotalCost { get; set; }

        public string PaymentMethod { get; set; }

        public string ShippingAddress { get; set; }

        public string Status { get; set; }

        public string Notes { get; set; }
    }
}
