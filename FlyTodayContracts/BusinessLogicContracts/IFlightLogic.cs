using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;

namespace FlyTodayContracts.BusinessLogicContracts
{
    public interface IFlightLogic
    {
        List<FlightViewModel>? ReadList(FlightSearchModel? model);
        FlightViewModel? ReadElement(FlightSearchModel model);
        bool Create(FlightBindingModel model);
        bool Update(FlightBindingModel model);
        bool Delete(FlightBindingModel model);
        bool UpdatePrices(FlightBindingModel model);
        Dictionary<int, int> GetSubscribers(FlightSearchModel model);
    }
}
