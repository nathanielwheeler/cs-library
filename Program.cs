using System;
using library.Controllers;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            InventoryController ic = new InventoryController();
            bool running = true;
            while (running)
            {
                System.Console.WriteLine(@"
 ____  _____         _   __                     _         
|_   \|_   _|       / |_[  |                   | |        
  |   \ | |   ,--. `| |-'| |--.   ,--.   _ .--.\_|.--.    
  | |\ \| |  `'_\ : | |  | .-. | `'_\ : [ `.-. | ( (`\]   
 _| |_\   |_ // | |,| |, | | | | // | |, | | | |  `'.'.   
|_____|\____|\'-;__/\__/[___]|__]\'-;__/[___||__][\__) )  
 |_   _|    (_) [  |                                      
   | |      __   | |.--.   _ .--.  ,--.   _ .--.  _   __  
   | |   _ [  |  | '/'`\ \[ `/'`\]`'_\ : [ `/'`\][ \ [  ] 
  _| |__/ | | |  |  \__/ | | |    // | |, | |     \ '/ /  
 |________|[___][__;.__.' [___]   \'-;__/[___]  [\_:  /   
                                                 \__.'    
                ");
                running = ic.Start();
            }
        }
    }
}
