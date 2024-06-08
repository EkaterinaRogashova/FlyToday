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
    public interface IDirectionStorage
    {
        List<DirectionViewModel> GetFullList();
        List<DirectionViewModel> GetFilteredList(DirectionSearchModel model);
        DirectionViewModel? GetElement(DirectionSearchModel model);
        DirectionViewModel? Insert(DirectionBindingModel model);
        DirectionViewModel? Update(DirectionBindingModel model);
        DirectionViewModel? Delete(DirectionBindingModel model);
        List<DirectionViewModel> Search(DirectionSearchModel model);
    }
}
