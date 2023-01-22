namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class PartManufacturer
    {
        //This table would establish a many-to-many relationship between the parts and the manufacturers,
        //linking the specific parts with the manufacturer, including the part's warranty information and production date.
        public int Id { get; set; }

        public required string ManufacturerName { get; set; }

    }
}
