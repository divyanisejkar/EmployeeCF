﻿// <auto-generated />
using EmployeeCF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeCF.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeCF.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("salary")
                        .HasColumnType("real");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Address = "New York",
                            CompanyName = "XYZ Inc",
                            Designation = "Developer",
                            Name = "John",
                            salary = 30000f
                        },
                        new
                        {
                            EmployeeId = 2,
                            Address = "New York",
                            CompanyName = "ABC Inc",
                            Designation = "Manager",
                            Name = "Chris",
                            salary = 50000f
                        },
                        new
                        {
                            EmployeeId = 3,
                            Address = "New Delhi",
                            CompanyName = "XYZ Inc",
                            Designation = "Consultant",
                            Name = "Mukesh",
                            salary = 20000f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
