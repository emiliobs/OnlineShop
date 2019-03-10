namespace Shop.UI.Controller
{
    using Microsoft.AspNetCore.Mvc;
    using Shop.Application.ProductAdmin;
    using Shop.Database;
    using Shop.Domain.ViewModels;

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
        public IActionResult CreateProducts(ProductViewModel productViewModel) => Ok(new CreateProduct(context).Do(productViewModel));

        [HttpPut("products")]
        public IActionResult UpdateProduct(ProductViewModel productViewModel) => Ok(new UpdateProduct(context).Do(productViewModel));

        [HttpDelete("products/{id}")]
        public IActionResult DeleteProduct(int id) => Ok(new DeleteProduct(context).Do(id));
    }
}