namespace Shop.Application.ProductAdmin
{
    using Shop.Database;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DeleteProduct
    {
        private readonly ApplicationDbContext context;

        public DeleteProduct(ApplicationDbContext context)    
        {
            this.context = context;
        }

        public async Task<bool> Do(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.Id.Equals(id));
            context.Products.Remove(product);
            await context.SaveChangesAsync();

            return true;
        }
    }
}
