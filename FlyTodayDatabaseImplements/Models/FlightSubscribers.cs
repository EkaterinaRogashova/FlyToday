using FlyTodayContracts.ViewModels;

namespace FlyTodayDatabaseImplements.Models
{
    public class FlightSubscribers
    {
        public Dictionary<FlightViewModel, UserViewModel> Subscribers = new();
    }
}
