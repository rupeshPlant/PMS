namespace Entities
{
    public class Role : BaseEntity
    {
        public string RoleId { get; set; } = System.Guid.NewGuid().ToString();
        public string RoleName { get; set; }

        public string RoleSystemName { get; set; }
    }
}
