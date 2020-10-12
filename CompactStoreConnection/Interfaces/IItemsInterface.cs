using CompactStoreConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompactStoreConnection.Repositorys
{
    public interface IItemsInterface
    {
        IEnumerable<Items> Items { get; }

    
    }
}
