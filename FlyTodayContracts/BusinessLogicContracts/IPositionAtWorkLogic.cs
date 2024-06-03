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
    public interface IPositionAtWorkLogic
    {
        List<PositionAtWorkViewModel>? ReadList(PositionAtWorkSearchModel? model);
        PositionAtWorkViewModel? ReadElement(PositionAtWorkSearchModel model);
        bool Create(PositionAtWorkBindingModel model);
        bool Update(PositionAtWorkBindingModel model);
        bool Delete(PositionAtWorkBindingModel model);
    }
}
