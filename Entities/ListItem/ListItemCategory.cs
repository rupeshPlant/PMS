using System.ComponentModel.DataAnnotations;

namespace Entities.ListItem;
using Microsoft.EntityFrameworkCore;

[Index(nameof(ListCategoryName),IsUnique =true)]
public class ListItemCategory : BaseEntity
{
    [Key]
    public string ListCategoryId { get; set; }
    public string ListCategoryName { get; set; }
}