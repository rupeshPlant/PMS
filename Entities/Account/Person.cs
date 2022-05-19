using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Person : BaseEntity
    {
        [Key]
        public string PersonId { get; set; } = System.Guid.NewGuid().ToString();
        public string Name { get; set; }
    }
}
