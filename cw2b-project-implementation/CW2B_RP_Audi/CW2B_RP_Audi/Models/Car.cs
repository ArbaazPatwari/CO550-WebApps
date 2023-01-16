using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CW2B_RP_Audi.Models
{
    public class Car
    {
        public int CarID { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string ModelName { get; set; } = string.Empty;

        [StringLength(30, MinimumLength = 3)]
        public string Brand { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "Price")]
        public decimal Price { get; set; }

        [StringLength(255, MinimumLength = 10)]
        public string Description { get; set; } = string.Empty;

        [StringLength(30, MinimumLength = 3)]
        public string EngineSize { get; set; } = string.Empty;

        [Column(TypeName = "0-60")]
        public decimal ZeroToSixty { get; set; }

        public int Power { get; set; }
        public int Torque { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string FuelType { get; set; } = string.Empty;

        public int WishlistPersonID { get; set; }
        public int WishlistCarCarID { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Colour { get; set; } = string.Empty;
    }
}
