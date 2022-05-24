using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.ListItem;

[Index(nameof(ListItemName),IsUnique =true)]
public class ListItem : BaseEntity
{
    [Key]
    public string ListItemId { get; set; }
    public string ListItemName { get; set; }
    public string ListItemCategoryId { get; set; }
    [ForeignKey(nameof(ListItemCategoryId))]
    public ListItemCategory ListItemCategory { get; set; }
}