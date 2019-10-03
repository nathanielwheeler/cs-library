using System;
using System.Collections.Generic;
using library.Models;

namespace library.Services
{
    class InventoryService
    {
        private Branch Inventory { get; set; }


        public InventoryService()
        {
            Inventory = new Branch();
        }
    }
}