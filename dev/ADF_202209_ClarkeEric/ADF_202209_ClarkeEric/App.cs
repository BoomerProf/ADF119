using System;
namespace ADF_202209_ClarkeEric
{
    public class App
    {
        private User _mainUser;
        bool menuRunning = false;
        public App()
        {
            Menu menu = new Menu();
            menu.Init("Main Menu",new String[]{ "Login", "About", "Exit"});
            menu.Display();
            _mainUser = new User();
            menuRunning = Selection();
        }

        private static bool Selection()
        {
            return true;
        }
    }
}
