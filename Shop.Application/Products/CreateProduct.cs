namespace Shop.Application.Products
{
    using Shop.Database;
    using Shop.Domain.Models;
    using Shop.Domain.ViewModels;
    using System.Threading.Tasks;

    public class CreateProduct
    {
        private readonly ApplicationDbContext context;



        public CreateProduct(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task Do(ProductViewModel productViewModel)
        {
            context.Products.Add(new Product()
            {

                Description = productViewModel.Description,
                Name = productViewModel.Name,
                Value = productViewModel.Value,
            });

            await context.SaveChangesAsync();
        }

    }
}
