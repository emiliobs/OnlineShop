﻿namespace Shop.UI.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Shop.Application.ProductAdmin;
    using Shop.Database;
    using Shop.Domain.ViewModels;
    using System.Collections.Generic;

    public class IndexModel : PageModel
    {

        #region Attributes
        private readonly ApplicationDbContext context;
        #endregion

        #region Properties

        [BindProperty]
        public RequestProductViewModel ProductViewModel { get; set; }
        public IEnumerable<RequestProductViewModel> ProductList { get; set; }

        #endregion

        #region onstructor

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        #endregion

        #region Methods
        public void OnGet()
        {
            ProductList = new GetProducts(context).Do();

        }



        //public async Task<ActionResult> OnPost()
        //{
        //    await new CreateProduct(context).Do(ProductViewModel);

        //    return RedirectToPage("Index");
        //}
        #endregion
    }
}
