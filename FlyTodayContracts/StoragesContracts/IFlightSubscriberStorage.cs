using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;

namespace FlyTodayContracts.StoragesContracts
{
    public interface IFlightSubscriberStorage
    {
        List<FlightSubscriberViewModel> GetFullList();
        List<FlightSubscriberViewModel> GetFilteredList(FlightSubscriberSearchModel model);
        FlightSubscriberViewModel? GetElement(FlightSubscriberSearchModel model);
        FlightSubscriberViewModel? Insert(FlightSubscriberBindingModel model);
        FlightSubscriberViewModel? Update(FlightSubscriberBindingModel model);
        FlightSubscriberViewModel? Delete(FlightSubscriberBindingModel model);
    }
}
