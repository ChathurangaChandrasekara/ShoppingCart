﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingCart.Models;

namespace ShoppingCart.Migrations
{
    [DbContext(typeof(ShoppingCartDbContext))]
    partial class ShoppingCartDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShoppingCart.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("ItemCategoryId");

                    b.Property<string>("ItemCode");

                    b.Property<string>("ItemName");

                    b.Property<int>("Quantity");

                    b.Property<int?>("SignUpId");

                    b.Property<int>("UnitPrice");

                    b.HasKey("ItemId");

                    b.HasIndex("ItemCategoryId");

                    b.HasIndex("SignUpId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ShoppingCart.Models.ItemCategory", b =>
                {
                    b.Property<int>("ItemCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemCategoryName");

                    b.HasKey("ItemCategoryId");

                    b.ToTable("ItemCategories");
                });

            modelBuilder.Entity("ShoppingCart.Models.MoreDetail", b =>
                {
                    b.Property<int>("MoreDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionAddress");

                    b.Property<string>("AdditionPhoneNumber");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Location");

                    b.Property<int?>("SignUpId");

                    b.HasKey("MoreDetailId");

                    b.HasIndex("SignUpId");

                    b.ToTable("MoreDetails");
                });

            modelBuilder.Entity("ShoppingCart.Models.SignUp", b =>
                {
                    b.Property<int>("SignUpId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<string>("LoginType");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("SignUpId");

                    b.ToTable("SignUps");
                });

            modelBuilder.Entity("ShoppingCart.Models.Item", b =>
                {
                    b.HasOne("ShoppingCart.Models.ItemCategory", "itemCategory")
                        .WithMany()
                        .HasForeignKey("ItemCategoryId");

                    b.HasOne("ShoppingCart.Models.SignUp", "signUp")
                        .WithMany()
                        .HasForeignKey("SignUpId");
                });

            modelBuilder.Entity("ShoppingCart.Models.MoreDetail", b =>
                {
                    b.HasOne("ShoppingCart.Models.SignUp", "signUp")
                        .WithMany()
                        .HasForeignKey("SignUpId");
                });
#pragma warning restore 612, 618
        }
    }
}
