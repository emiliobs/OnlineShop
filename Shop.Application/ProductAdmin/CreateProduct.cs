namespace Shop.Application.ProductAdmin
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

        public async Task<ResponseProductViewModel> Do(RequestProductViewModel requestProductViewModel)
        {

            var product = new Product
            {
                Description = requestProductViewModel.Description,
                Name = requestProductViewModel.Name,
                Value = requestProductViewModel.Value,
            };

            context.Products.Add(product);
            await context.SaveChangesAsync();

            return  new ResponseProductViewModel()
            {
                Description = product.Description,
                Name = product.Name,
                Value = product.Value,
                 Id = product.Id,
            };
        }

    }
}
