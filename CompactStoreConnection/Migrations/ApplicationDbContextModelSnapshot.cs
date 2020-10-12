﻿// <auto-generated />
using CompactStoreConnection.DBConnections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompactStoreConnection.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompactStoreConnection.Models.Items", b =>
                {
                    b.Property<string>("ItemNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemNo");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CompactStoreConnection.Models.StorePositionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("StorePositionItem");
                });
#pragma warning restore 612, 618
        }
    }
}
