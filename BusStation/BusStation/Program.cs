using System;

namespace BusStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainController = new MainController();
            while (true)
            {
                mainController.Run();
            }
        }
    }
}
