using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Entities.Product
{
    [Index(nameof(ProductCode), IsUnique = true)]
    [Index(nameof(ProductName),nameof(ParentProductId), IsUnique = true)]
    public class Product: BaseEntity
    {
        [Key]
        public string ProductId { get; set; } = System.Guid.NewGuid().ToString();
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string? ParentProductId { get; set; }
    }
}
