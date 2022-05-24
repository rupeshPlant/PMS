using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Vendor;

[Index(nameof(VendorName),IsUnique =true)]
public class Vendor : BaseEntity
{
    [Key]
    public string VendorId { get; set; } = Guid.NewGuid().ToString();
    public string VendorName { get; set; }
    public string VendorTypeListItem { get; set; }
    public string VendorStatusListItem { get; set; }
    public string TaxRegistrationNumber { get; set; }
    
    [ForeignKey(nameof(VendorStatusListItem))]
    public ListItem.ListItem StatusListItem { get; set; } 
    
    [ForeignKey(nameof(VendorTypeListItem))]
    public ListItem.ListItem TypeListItem { get; set; } 
}