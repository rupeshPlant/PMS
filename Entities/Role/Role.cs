using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [Index(nameof(RoleSystemName), IsUnique = true)]
    public class Role : BaseEntity
    {
        [Key]
        public string RoleId { get; set; } = System.Guid.NewGuid().ToString();
        public string RoleName { get; set; }
        public string RoleSystemName { get; set; }
    }
}
