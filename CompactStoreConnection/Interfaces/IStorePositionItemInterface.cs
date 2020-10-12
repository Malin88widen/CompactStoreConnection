using CompactStoreConnection.Controllers;
using CompactStoreConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CompactStoreConnection.Repositorys
{
    public interface IStorePositionItemInterface
    {
        IEnumerable<StorePositionItem> StorePositionItem { get; }
    }
}
