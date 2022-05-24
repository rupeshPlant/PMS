using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Common;
using Models.Constant.ResponseMesssage;
using Models.Product;
using System.Net;
using UI.Services.Refit;


namespace UI.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _iProductService;

        public ProductController(IProductService iProductService)
        {
            _iProductService = iProductService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            await InitializedViewBagAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(CreateProductModel model)
        {

            if (ModelState.IsValid)
            {
                var response = await _iProductService.CreateProduct(model);
                if (response.IsSuccessStatusCode)
                {
                    var responseMessage = await response.Content.ReadAsStringAsync();
                    if(responseMessage == ResponseMessage.ProductCreatedSucessfully)
                    {
                        TempData["Success"] = $"Successfully created Company Rate of {model.ProductName}";
                        return RedirectToAction("Index", "Product");
                    }
                    if(responseMessage == ResponseMessage.ProductCodeAlreadyExists)
                    {
                        TempData["Error"] = $"{model.ProductCode} already exists";
                        await InitializedViewBagAsync();
                        return View(model);
                    }
                }
                TempData["Error"] = $"Bad Request ";
                return RedirectToAction("Index", "Product");
            }
            await InitializedViewBagAsync();
            return View(model);
        }

        #region Helpers
        private async Task InitializedViewBagAsync()
        {
            var productRequest = await _iProductService.GetAllProductForDropdown();
            if (productRequest.IsSuccessStatusCode)
            {
                var product = await productRequest.Content.ReadAsAsync<List<ProductModel>>();
                ViewBag.product = new SelectList(product, "ProductId", "ProductName");
            }
        }
        #endregion
    }
}
