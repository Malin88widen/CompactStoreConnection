using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompactStoreConnection.Repositorys;
using Microsoft.AspNetCore.Mvc;
using CompactStoreConnection.Models;

namespace CompactStoreConnection.Controllers
{
    public class StorePositionItemController : Controller
    {
        public IStorePositionItemInterface repo;

        public StorePositionItemController(StorePositionItemRepository storePositionItemsrepository)
        {
            repo = storePositionItemsrepository;
        }
        public IActionResult List()
        {
            return View(repo.StorePositionItem);
        }

        public IActionResult Index()
        {
            return View();
        }
    }

}

