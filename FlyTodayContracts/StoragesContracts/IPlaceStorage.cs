using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;

namespace FlyTodayContracts.StoragesContracts
{
    public interface IPlaceStorage
    {
        List<PlaceViewModel> GetFullList();
        List<PlaceViewModel> GetFilteredList(PlaceSearchModel model);
        PlaceViewModel? GetElement(PlaceSearchModel model);
        PlaceViewModel? Insert(PlaceBindingModel model);
        PlaceViewModel? Update(PlaceBindingModel model);
        PlaceViewModel? Delete(PlaceBindingModel model);
    }
}
