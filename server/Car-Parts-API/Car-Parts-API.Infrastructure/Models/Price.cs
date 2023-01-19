namespace Car_Parts_API.Infrastructure.Models
{
    public class Price
    {
        // this table will store the price of the part, any discounts, and offer for each part along with the
        // currency.
        public int Id { get; set; }

        public int PartId { get; set; }

        public decimal PartPrice { get; set; }

        public decimal Discount { get; set; }

        public string Currency { get; set; }

        public string Availability { get; set; }

        public decimal ShippingCost { get; set; }

        public int PartNumber { get; set; }

        public string Part_Name { get; set; }

        public string ManufacturerName { get; set; }

        public string Notes { get; set; }
    }
}
