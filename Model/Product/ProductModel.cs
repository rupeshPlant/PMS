using Models.Common;

namespace Models.Product
{
    public class ProductModel
    {
        public string ProductId { get; set; } = System.Guid.NewGuid().ToString();
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string? ParentProductId { get; set; }
    }

    public class ProductDataTableModel : DataTableResponseModel<ProductModel>
    {

    }
}
