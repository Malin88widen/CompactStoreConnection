using CompactStoreConnection.Controllers;
using CompactStoreConnection.DBConnections;
using CompactStoreConnection.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompactStoreConnection.Models
{
    public class ItemsRepository : IItemsInterface
    {
        private ApplicationDbContext ctx;

        public ItemsRepository(ApplicationDbContext context)
        {
            ctx = context;
        }

        public IEnumerable<Items> Items => ctx.Items;

      


    }
}
