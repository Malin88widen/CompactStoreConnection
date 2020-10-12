using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CompactStoreConnection.Models
{
   
    public class Items
    {
       
        [Key]
        public string ItemNo { get; set; }

        public string ItemDescription { get; set; }
    }
}
