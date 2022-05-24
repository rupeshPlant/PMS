using System.ComponentModel.DataAnnotations;

namespace Models.Product
{
    public class UpdateProductModel
    {
        public string ProductId { get; set; } = System.Guid.NewGuid().ToString();

        [Required(ErrorMessage = "Product Name is Required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product Code is Required")]
        public string ProductCode { get; set; }
        public string? ParentProductId { get; set; }
    }
}
