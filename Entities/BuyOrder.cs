using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class BuyOrder
    {
        [Key]
        public Guid BuyOrderID { get; set; }


        public string StockSymbol { get; set; }


        [Required(ErrorMessage = "Stock name cannot be empty")]
        public string StockName { get; set; }


        public DateTime DateAndTimeOfOrder { get; set; }


        [Range(1,100000, ErrorMessage = "You can buy 1-100000 shares per order")]
        public uint Quantity { get; set; }


        [Range(1, 10000, ErrorMessage = "Shares can be priced between 1-10000")]
        public double Price { get; set; }
    }
}
