using CompactStoreConnection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CompactStoreConnection.DBConnections
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Items> Items { get; set; }

        public DbSet<StorePositionItem> StorePositionItem { get; set; }
    }
}
