using Entities;
using Entities.Product;
using Microsoft.EntityFrameworkCore;
using Models.Common.Authorization;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var superAdmin =  _context.Person.Where(x => x.UserName == SystemUser.UserName).FirstOrDefaultAsync();

            modelBuilder.Entity<Role>().HasData(new Role 
            {   
                RoleId = "1",
                RoleName = "Super Admin", 
                RoleSystemName = SystemUser.Name,
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.Entity<Person>().HasData(new Person 
            {   
                Name = SystemUser.Name,
                PersonId = "1",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee 
            {   
                EmployeeId = "1",
                UserName = SystemUser.UserName,
                Email = SystemUser.Email,
                PhoneNumber = "9841111111",
                PasswordHash = "AQAAAAEAAYagAAAAECYRvg4UxADgEMkvzWBbZ7BzwVeMhe23Iu/Yc2XANppkQ3VwbLpWuwPjziLJHQfoyA==", //Admin@123
                RoleId = "1",
                PersonId = "1",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.HasCollation("case_insensitive_collation", locale: "en-u-ks-primary", provider: "icu", deterministic: false);

            modelBuilder.Entity<Product>().HasIndex(x => x.ProductCode)
                .UseCollation("case_insensitive_collation")
                .IsUnique();
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
