using System.ComponentModel.DataAnnotations;

namespace Shop.Domain.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Description { get; set; }

       
        [DisplayFormat(DataFormatString = "0:N2", ApplyFormatInEditMode = false)]
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
