namespace Shop.UI.Controller
{
    using Microsoft.AspNetCore.Mvc;
    using Shop.Application.ProductAdmin;
    using Shop.Database;
    using Shop.Domain.ViewModels;
    using System.Threading.Tasks;

    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;

        public AdminController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("products")]
        public IActionResult GetProducts() => Ok(new GetProducts(context).Do());

        [HttpGet("products/{Id}")]
        public IActionResult GetProduct(int id) => Ok(new GetProduct(context).Do(id));

        [HttpPost("products")]
        public async Task<IActionResult> CreateProducts([FromBody] RequestProductViewModel productViewModel) => Ok(await new CreateProduct(context).Do(productViewModel));

        [HttpPut("products")]
        public async Task<IActionResult> UpdateProduct([FromBody] RequestProductViewModel productViewModel) => Ok(await new UpdateProduct(context).Do(productViewModel));

        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(int id) => Ok(await new DeleteProduct(context).Do(id));
    }
}