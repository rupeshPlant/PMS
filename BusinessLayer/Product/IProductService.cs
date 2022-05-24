using Models;
using Models.Common;
using Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Product
{
    public interface IProductService
    {
        Task<ResponseMessageModel> CreateProductAsync(CreateProductModel model);
        Task<ProductDataTableModel> GetAllProductAsync(DataTableRequestModel model);
        Task<List<ProductModel>> GetAllProductForDropdownAsync();
        Task<UpdateProductModel> GetProductByIdAsync(int productId);
        Task<ResponseMessageModel> UpdateProductAsync(UpdateProductModel model);
    }
}
