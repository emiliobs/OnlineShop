namespace Shop.Application.Products
{
    using Shop.Database;
    using Shop.Domain.Models;
    public class GetProduct
    {
        private readonly ApplicationDbContext context;

        public GetProduct(ApplicationDbContext context)
        {
            this.context = context;
        }

       
    }
}
