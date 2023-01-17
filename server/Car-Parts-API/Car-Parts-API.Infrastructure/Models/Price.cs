namespace Car_Parts_API.Infrastructure.Models
{
    public class Price
    {
        // this table will store the price of the part, any discounts, and offer for each part along with the
        // currency.
        public int Id { get; set; }

        public int Part_Number { get; set; }

        public string Part_Name { get; set; }

        public string ManufacturerName { get; set; }


    }
}
