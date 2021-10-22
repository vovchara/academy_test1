using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    public class MainMenuController
    {
        private MainMenuView _menuView;

        public MainMenuController()
        {
            _menuView = new MainMenuView();
        }

        public void ShowMainMenu()
        {
            _menuView.ShowHeader();
            _menuView.ShowMenu();
        }

        public void ShowTripsTable()
        {
            _menuView.ShowTripsTable(TripsStorage.Trips);
        }
    }
}
