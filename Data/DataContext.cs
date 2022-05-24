using Entities;
using Entities.ListItem;
using Entities.Vendor;
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
            { RoleId = "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                RoleName = "Super Admin", 
                RoleSystemName = SystemUser.Name,
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.Entity<Person>().HasData(new Person 
            { Name = SystemUser.Name,
                PersonId = "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee 
            { EmployeeId = "5b6cd63e-e6bb-4168-bb33-ae73952c716f",
                UserName = SystemUser.UserName,
                Email = SystemUser.Email,
                PhoneNumber = "9841111111",
                PasswordHash = "AQAAAAEAAYagAAAAECYRvg4UxADgEMkvzWBbZ7BzwVeMhe23Iu/Yc2XANppkQ3VwbLpWuwPjziLJHQfoyA==", //Admin@123
                RoleId = "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                PersonId = "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            
            modelBuilder.Entity<Person>().HasData(new Person 
            { Name = "Check",
                PersonId = "che32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee 
            { EmployeeId = "test555-e6bb-4168-bb33-ae73952c716f",
                UserName = "Test",
                Email = "test@mail.com",
                PhoneNumber = "984111111",
                PasswordHash = "AQAAAAEAAYagAAAAECYRvg4UxADgEMkvzWBbZ7BzwVeMhe23Iu/Yc2XANppkQ3VwbLpWuwPjziLJHQfoyA==", //Admin@123
                RoleId = "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                PersonId = "che32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });

            modelBuilder.Entity<ListItemCategory>().HasData(new ListItemCategory
            {
                ListCategoryId = "VT-01",
                ListCategoryName = "Vendor Type",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.Entity<ListItemCategory>().HasData(new ListItemCategory
            {
                ListCategoryId = "VS-01",
                ListCategoryName = "Vendor Status",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.Entity<ListItem>().HasData(new ListItem
            {
                ListItemId = "VTI-01",
                ListItemName = "PAN",
                ListItemCategoryId = "VT-01",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.Entity<ListItem>().HasData(new ListItem
            {
                ListItemId = "VTI-02",
                ListItemName = "VAT",
                ListItemCategoryId = "VT-01",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.Entity<ListItem>().HasData(new ListItem
            {
                ListItemId = "VSL-01",
                ListItemName = "Active",
                ListItemCategoryId = "VS-01",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
            modelBuilder.Entity<ListItem>().HasData(new ListItem
            {
                ListItemId = "VSL-02",
                ListItemName = "Inactive",
                ListItemCategoryId = "VS-01",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });

            modelBuilder.Entity<Vendor>().HasData(new Vendor
            {
                VendorId = "V-01",
                VendorName = "SK Suppliers",
                VendorStatusListItem = "VSL-01",
                VendorTypeListItem = "VTI-01",
                TaxRegistrationNumber = "123456789",
                InsertDate = DateTimeOffset.UtcNow,
                InsertPersonId = "1",
                UpdateDate = DateTimeOffset.UtcNow,
                UpdatePersonId = "1"
            });
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<ListItemCategory> ListItemCategory { get; set; }
        public DbSet<ListItem> ListItem { get; set; }
        
    }
}
