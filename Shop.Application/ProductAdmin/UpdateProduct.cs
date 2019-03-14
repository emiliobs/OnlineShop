namespace Shop.Application.ProductAdmin
{
    using Shop.Database;
    using Shop.Domain.ViewModels;
    using System.Threading.Tasks;

    public class UpdateProduct
    {
        private readonly ApplicationDbContext context;

        public UpdateProduct(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<ResponseProductViewModel> Do(RequestProductViewModel productViewModel)
        {
            await context.SaveChangesAsync();

            return new ResponseProductViewModel();
        }

    }

}
