﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CompactStoreConnection.Models
{
    public class StorePositionItem
    {
        public int Id { get; set; }
        public string StorePosition { get; }

        
        public int ItemNo { get; }


    }
}
