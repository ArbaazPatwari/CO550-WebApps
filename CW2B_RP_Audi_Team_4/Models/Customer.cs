using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CW2B_RP_Audi_Team_4.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public string CustomerEmail { get; set; } = string.Empty;

        public string CustomerPhone { get; set; } = string.Empty;

        public string CustomerCity { get; set; } = string.Empty;

        public string CustomerRegion { get; set; } = string.Empty;

        public string CustomerAddress { get; set; } = string.Empty;

        public string OrderID { get; set; } = string.Empty;

        public string OrderStatus { get; set; } = string.Empty;


    }
}
