using BusinessLayer.Product;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Common;
using Models.Product;

namespace API.Controllers
{
    public class ProductController : BaseApiController
    {
        private readonly IProductService _iProductService;

        public ProductController(IProductService iProductService)
        {
            _iProductService = iProductService;
        }
        [HttpPost("CreateProduct")]
        public async Task<ResponseMessageModel> CreateProduct(CreateProductModel createProductModel)
        {
            return await _iProductService.CreateProductAsync(createProductModel);
        }

        [HttpPost("GetAllProduct")]
        public async Task<ProductDataTableModel> GetAllProduct(DataTableRequestModel model)
        {
            return await _iProductService.GetAllProductAsync(model);
        }
        [HttpPost("GetAllProductForDropdown")]
        public async Task<List<ProductModel>> GetAllProductForDropdown()
        {
            return await _iProductService.GetAllProductForDropdownAsync();
        }




        //    [HttpGet("GetProductId/{productId}")]
        //    public async Task<IActionResult> GetProductById(int productId)
        //    {
        //        return _iProductService.GetProductById(productId);
        //    }

    }
}
