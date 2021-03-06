// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations.Core
{
    [DbContext(typeof(DataContext))]
    [Migration("20220517065217_Seed-Person")]
    partial class SeedPerson
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entities.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("InsertDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InsertPersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatePersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmployeeId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PersonId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Entities.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("InsertDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InsertPersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatePersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PersonId");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            PersonId = "fc32092d-d2dc-4a6a-a0b0-a4a482d21c07",
                            InsertDate = new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2508), new TimeSpan(0, 0, 0, 0, 0)),
                            InsertPersonId = "1",
                            Name = "superadmin",
                            UpdateDate = new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2509), new TimeSpan(0, 0, 0, 0, 0)),
                            UpdatePersonId = "1"
                        });
                });

            modelBuilder.Entity("Entities.Role", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("InsertDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InsertPersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleSystemName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatePersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RoleId");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            RoleId = "d0b3eab9-9f9d-45cc-95c0-b28fb7062868",
                            InsertDate = new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2397), new TimeSpan(0, 0, 0, 0, 0)),
                            InsertPersonId = "1",
                            RoleName = "Super Admin",
                            RoleSystemName = "superadmin",
                            UpdateDate = new DateTimeOffset(new DateTime(2022, 5, 17, 6, 52, 17, 43, DateTimeKind.Unspecified).AddTicks(2399), new TimeSpan(0, 0, 0, 0, 0)),
                            UpdatePersonId = "1"
                        });
                });

            modelBuilder.Entity("Entities.Employee", b =>
                {
                    b.HasOne("Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
