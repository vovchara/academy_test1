using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    public class MainMenuView
    {
        public void ShowHeader()
        {
            Console.WriteLine("Hello brodyaga, how can I help you?");
        }

        public void ShowTripsTable(List<TripModel> trips)
        {
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                Console.WriteLine($"{oneTrip.Id} : {oneTrip.DepartureTime.ToShortDateString()} : {oneTrip.TripFrom} .....");
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("1 - Show all");
            Console.WriteLine("2 - Find by Id");
            Console.WriteLine("3 - Find by destination");
        }

        private void ShowTripsHeader()
        {
            Console.WriteLine("N     DEPARTURE      FROM     .....");
        }
    }
}
