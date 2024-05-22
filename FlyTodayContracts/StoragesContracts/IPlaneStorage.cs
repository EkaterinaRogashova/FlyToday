using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
