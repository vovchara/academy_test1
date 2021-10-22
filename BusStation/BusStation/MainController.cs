using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    public class MainController
    {
        private readonly InputComponent _input;
        private readonly MainMenuController _menuController;

        public MainController()
        {
            _input = new InputComponent();
            _menuController = new MainMenuController();
        }

        public void Run()
        {
            _menuController.ShowMainMenu();
            var result = _input.GetInputInt();
            switch (result)
            {
                case 1:
                    _menuController.ShowTripsTable();
                    break;
                case 2:
                    //todo for example only
                    Console.WriteLine("SHOW FIND BY ID");
                    break;
            }
        }
    }
}
