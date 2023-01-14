using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW2b_RP_Audi.Models
{
    public class OrderItem
    {
        public int OrderID { get; }
        public int CarID { get; }
        
        public decimal SalePrice { get; set; }

        public int Quantity { get; set; }

        // Navigation properties 

        public Car Car { get; set; }
    }
}
