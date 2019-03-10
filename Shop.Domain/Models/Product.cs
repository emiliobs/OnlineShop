using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Domain.Models
{
    public class Product
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "0:C2", ApplyFormatInEditMode = false)]
        public decimal Value { get; set; }

        public ICollection<Stock> Stocks { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
