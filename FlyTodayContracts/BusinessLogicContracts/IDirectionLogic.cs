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
    public interface IDirectionLogic
    {
        List<DirectionViewModel>? ReadList(DirectionSearchModel? model);
        DirectionViewModel? ReadElement(DirectionSearchModel model);
        bool Create(DirectionBindingModel model);
        bool Update(DirectionBindingModel model);
        bool Delete(DirectionBindingModel model);
    }
}
