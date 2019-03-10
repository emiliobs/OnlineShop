namespace Shop.Application.ProductAdmin
{
    using Shop.Database;
    using Shop.Domain.ViewModels;
    using System.Collections.Generic;
    using System.Linq;
    public class GetProducts
    {
        private readonly ApplicationDbContext context;

        public GetProducts(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<ProductViewModel> Do() => context.Products.ToList().Select(p => new ProductViewModel()
        {
             Id = p.Id,
            Description = p.Description,
            Name = p.Name,
            Value = p.Value
        });

    }
}
