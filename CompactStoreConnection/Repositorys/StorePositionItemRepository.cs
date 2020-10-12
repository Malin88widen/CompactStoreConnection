using CompactStoreConnection.Controllers;
using CompactStoreConnection.DBConnections;
using CompactStoreConnection.Models;
using CompactStoreConnection.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompactStoreConnection.Models
{
    public class StorePositionItemRepository : IStorePositionItemInterface
    {
        private ApplicationDbContext ctx;

        public StorePositionItemRepository(ApplicationDbContext context)
        {
            ctx = context;
        }

        public IEnumerable<StorePositionItem> StorePositionItem => ctx.StorePositionItem;


    }
}
