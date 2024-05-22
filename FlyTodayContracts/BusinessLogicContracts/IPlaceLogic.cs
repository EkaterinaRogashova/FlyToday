using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BusinessLogicContracts
{
    public interface IPlaceLogic
    {
        List<PlaceViewModel>? ReadList(PlaceSearchModel? model);
        PlaceViewModel? ReadElement(PlaceSearchModel model);
        bool Create(PlaceBindingModel model);
        bool Update(PlaceBindingModel model);
        bool Delete(PlaceBindingModel model);
    }
}
