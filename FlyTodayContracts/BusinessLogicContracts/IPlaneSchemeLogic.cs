using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;

namespace FlyTodayContracts.BusinessLogicContracts
{
    public interface IPlaneSchemeLogic
    {
        List<PlaneSchemeViewModel>? ReadList(PlaneSchemeSearchModel? model);
        PlaneSchemeViewModel? ReadElement(PlaneSchemeSearchModel model);
        bool Create(PlaneSchemeBindingModel model);
        bool Update(PlaneSchemeBindingModel model);
        bool Delete(PlaneSchemeBindingModel model);
    }
}
