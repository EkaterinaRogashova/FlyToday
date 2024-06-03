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
    public interface IPositionAtWorkStorage
    {
        List<PositionAtWorkViewModel> GetFullList();
        List<PositionAtWorkViewModel> GetFilteredList(PositionAtWorkSearchModel model);
        PositionAtWorkViewModel? GetElement(PositionAtWorkSearchModel model);
        PositionAtWorkViewModel? Insert(PositionAtWorkBindingModel model);
        PositionAtWorkViewModel? Update(PositionAtWorkBindingModel model);
        PositionAtWorkViewModel? Delete(PositionAtWorkBindingModel model);
    }
}
