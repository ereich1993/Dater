﻿// <auto-generated />
using System;
using Dater;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dater.Migrations
{
    [DbContext(typeof(DatingContext))]
    partial class DatingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dater.Entity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("entities");
                });

            modelBuilder.Entity("Dater.Models.MenuItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("Descrition");

                    b.Property<int?>("MenuUserId");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<int?>("Spicy");

                    b.Property<int?>("Vegetarian");

                    b.HasKey("Id");

                    b.HasIndex("MenuUserId");

                    b.ToTable("menuItems");
                });

            modelBuilder.Entity("Dater.Models.MenuUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("menuUsers");
                });

            modelBuilder.Entity("Dater.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Dater.Models.MenuItems", b =>
                {
                    b.HasOne("Dater.Models.MenuUser")
                        .WithMany("menuItems")
                        .HasForeignKey("MenuUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
