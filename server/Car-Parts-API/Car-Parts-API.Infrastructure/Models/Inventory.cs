﻿namespace Car_Parts_API.Infrastructure.Models
{
    public class Inventory
    {
        //This table would store detailed information about the current inventory of parts, including the
        //quantity on hand, reorder level, and the supplier details.
        //Ask chatgpt Inventory and Vendor

        public int InventoryId { get; set; }

        public int PartId { get; set; }

        public int Quantity { get; set; }

        public string Location { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string SupplierDetails { get; set; }
    }
}
