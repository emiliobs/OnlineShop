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


        public RequestProductViewModel Do(int Id) => context.Products.Where(p => p.Id.Equals(Id)).Select(p => new RequestProductViewModel()
        {
           
            Description = p.Description,
            Name = p.Name,            
            Value = p.Value,
        }).FirstOrDefault();
       
       
    }
}
