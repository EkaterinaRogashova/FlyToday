using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;

namespace FlyTodayContracts.StoragesContracts
{
    public interface IPlaneStorage
    {
        List<PlaneViewModel> GetFullList();
        List<PlaneViewModel> GetFilteredList(PlaneSearchModel model);
        PlaneViewModel? GetElement(PlaneSearchModel model);
        PlaneViewModel? Insert(PlaneBindingModel model);
        PlaneViewModel? Update(PlaneBindingModel model);
        PlaneViewModel? Delete(PlaneBindingModel model);
    }
}
