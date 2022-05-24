using System.ComponentModel.DataAnnotations;

namespace Models.Product
{
    public class CreateProductModel
    {

        [Required(ErrorMessage ="Product Name is Required")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "Product Code is Required")]
        public string ProductCode { get; set; } // Make No White Space??

        public string? ParentProductId { get; set; }
    }
}
