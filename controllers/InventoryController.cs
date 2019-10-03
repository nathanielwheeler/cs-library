using System;
using library.Services;

namespace library.Controllers
{
    class InventoryController
    {
        private InventoryService InventoryService { get; set; }
        private string Menu { get; set; }

        public bool Start()
        {
            return true;
        }

        // public void PrintBooks()
        // {
        //     for (int i = 0; i < Books.Count; i++)
        //     {
        //         Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
        //     }
        // }



        public InventoryController()
        {
            InventoryService = new InventoryService();
        }
    }
}