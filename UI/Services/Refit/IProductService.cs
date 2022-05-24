using Models.Common;
using Models.Product;
using Refit;

namespace UI.Services.Refit
{
    public interface IProductService
    {
        [Post("/api/Product/CreateProduct")]
        Task<HttpResponseMessage> CreateProduct([Body] CreateProductModel createProductModel);

        [Post("/api/Product/GetAllProduct")]
        Task<HttpResponseMessage> GetAllProduct([Body] DataTableRequestModel model);

        [Post("/api/Product/GetAllProductForDropdown")]
        Task<HttpResponseMessage> GetAllProductForDropdown();
    }
}
