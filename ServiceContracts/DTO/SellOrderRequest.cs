using Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ServiceContracts.DTO
{
    public class SellOrderRequest : IValidatableObject
    {
        [Required(ErrorMessage = "Stock symbol cannot be empty")]
        public string StockSymbol { get; set; }


        [Required(ErrorMessage = "Stock name cannot be empty")]
        public string StockName { get; set; }


        public DateTime DateAndTimeOfOrder { get; set; }


        [Range(1, 100000, ErrorMessage = "You can buy 1-100000 shares per order")]
        public uint Quantity { get; set; }


        [Range(1, 10000, ErrorMessage = "Shares can be priced between 1-10000")]
        public double Price { get; set; }

        public SellOrderResponse ToSellOrder()
        {
            return new SellOrder()
            {
                StockSymbol = this.StockSymbol,
                StockName = this.StockName,
                Price = this.Price,
                DateAndTimeOfOrder = this.DateAndTimeOfOrder,
                Quantity = this.Quantity
            };
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> results = new List<ValidationResult>();

            if (DateAndTimeOfOrder < Convert.ToDateTime("2000-01-01"))
            {
                results.Add(new ValidationResult("Date of the order cannot be older than Jan 01, 2000"));
            }
            return results;
        }
    }
}
