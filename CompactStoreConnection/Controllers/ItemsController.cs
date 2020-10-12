using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompactStoreConnection.Models;
using CompactStoreConnection.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompactStoreConnection.Controllers
{

 
    public class ItemsController : Controller
    {
        public IItemsInterface repo;
        public ItemsController(ItemsRepository itemsrepository)
        {
            repo = itemsrepository;
        }
        public IActionResult List()
        {
            return View(repo.Items);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
