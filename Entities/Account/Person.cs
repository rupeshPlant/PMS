using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Person : BaseEntity
    {
        [Key]
        public string PersonId { get; set; } = System.Guid.NewGuid().ToString();

        [StringLength(50)]
        public string Name { get; set; }
    }
}
