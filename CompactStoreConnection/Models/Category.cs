using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompactStoreConnection.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Items> Items { get; set; }

        public virtual List<StorePositionItem> StorePositionItems { get; set; }
    }
}
