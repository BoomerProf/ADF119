using System;
using System.Collections.Generic;

namespace ADF_202209_ClarkeEric
{
    public class Menu
    {
        private string _title;
        private List<string> menuItems = null;
       
        public Menu()
        {
            
        }

        public void Init(string title, string[] menuArray)
        {
            _title = title;
            menuItems = new List<string>();
            foreach(string menu in menuArray)
            {
                menuItems.Add(menu);
            }
           
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(_title);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Clear();
            for (int x = 0; x < menuItems.Count; x++)
            {
                Console.WriteLine((x + 1) + "). " + menuItems[x]);
            }
        }
    }
}
