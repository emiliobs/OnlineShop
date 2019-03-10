namespace Shop.Application.ProductAdmin
{
    using Shop.Database;
    using Shop.Domain.Models;
    using Shop.Domain.ViewModels;
    using System.Linq;

    public class GetProduct
    {
        private readonly ApplicationDbContext context;

        public GetProduct(ApplicationDbContext context)
        {
            this.context = context;
        }


        public ProductViewModel Do(int Id) => context.Products.Where(p => p.Id.Equals(Id)).Select(p => new ProductViewModel()
        {
            Id = p.Id,
            Description = p.Description,
            Name = p.Name,
            OrderProducts =p.OrderProducts,
            Stocks = p.Stocks,
            Value = p.Value,
        }).FirstOrDefault();
       
       
    }
}
