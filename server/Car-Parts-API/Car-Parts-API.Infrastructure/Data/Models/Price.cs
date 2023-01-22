<<<<<<< HEAD:server/Car-Parts-API/Car-Parts-API.Infrastructure/Models/Price.cs
﻿namespace Car_Parts_API.Infrastructure.Models
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
>>>>>>> 01432d4daee875c3bbd2613ee2eba64ffd36032e:server/Car-Parts-API/Car-Parts-API.Infrastructure/Data/Models/Price.cs
{
    public class Price
    {
        // this table will store the price of the part, any discounts, and offer for each part along with the
        // currency.
        public int Id { get; set; }

<<<<<<< HEAD:server/Car-Parts-API/Car-Parts-API.Infrastructure/Models/Price.cs
        public int PartId { get; set; }
=======

>>>>>>> 01432d4daee875c3bbd2613ee2eba64ffd36032e:server/Car-Parts-API/Car-Parts-API.Infrastructure/Data/Models/Price.cs

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
