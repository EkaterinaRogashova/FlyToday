using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;

namespace FlyTodayContracts.BusinessLogicContracts
{
    public interface IFlightSubscriberLogic
    {
        List<FlightSubscriberViewModel>? ReadList(FlightSubscriberSearchModel? model);
        FlightSubscriberViewModel? ReadElement(FlightSubscriberSearchModel model);
        bool Create(FlightSubscriberBindingModel model);
        bool Update(FlightSubscriberBindingModel model);
        bool Delete(FlightSubscriberBindingModel model);
    }
}
