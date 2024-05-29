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
    public interface IRentStorage
    {
        List<RentViewModel> GetFullList();
        List<RentViewModel> GetFilteredList(RentSearchModel model);
        RentViewModel? GetElement(RentSearchModel model);
        RentViewModel? Insert(RentBindingModel model);
        RentViewModel? Delete(RentBindingModel model);
    }
}
