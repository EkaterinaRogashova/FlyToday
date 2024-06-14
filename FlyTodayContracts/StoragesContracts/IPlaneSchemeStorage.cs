using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;

namespace FlyTodayContracts.StoragesContracts
{
    public interface IPlaneSchemeStorage
    {
        List<PlaneSchemeViewModel> GetFullList();
        List<PlaneSchemeViewModel> GetFilteredList(PlaneSchemeSearchModel model);
        PlaneSchemeViewModel? GetElement(PlaneSchemeSearchModel model);
        PlaneSchemeViewModel? Insert(PlaneSchemeBindingModel model);
        PlaneSchemeViewModel? Update(PlaneSchemeBindingModel model);
        PlaneSchemeViewModel? Delete(PlaneSchemeBindingModel model);
    }
}
