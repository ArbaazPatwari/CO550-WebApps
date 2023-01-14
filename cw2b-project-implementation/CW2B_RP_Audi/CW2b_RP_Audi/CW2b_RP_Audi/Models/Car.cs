using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW2b_RP_Audi.Models
{
    public class Car
    {
        public int CarID { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string ModelName { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Brand { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "Price")]
        public decimal Price { get; set; }

        [StringLength(255, MinimumLength = 10)]
        public string Description { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string EngineSize { get; set; }

        public decimal ZeroToSixty { get; set; }

        public int Power { get; set; }
        public int Torque { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string FuelType { get; set; }

        public int WishlistPersonID { get; set; }
        public int WishlistCarCarID { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Colour { get; set; }    

        // Navigation properties

        public CarImage CarImage { get; set; }

    }
}
