namespace Shop.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Order
    {
        public int Id{ get; set; }

        [Display(Name = "Order Reference")]
        public string OrderReference { get; set; }

        [Display(Name = "Address 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        public string Address2 { get; set; }
        public string City { get; set; }

        [Display(Name = "Post Code")]
        public string PostCode { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
