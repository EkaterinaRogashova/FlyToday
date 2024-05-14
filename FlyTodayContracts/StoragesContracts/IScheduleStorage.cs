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
    public interface IScheduleStorage
    {
        List<ScheduleViewModel> GetFullList();
        List<ScheduleViewModel> GetFilteredList(ScheduleSearchModel model);
        ScheduleViewModel? GetElement(ScheduleSearchModel model);
        ScheduleViewModel? Insert(ScheduleBindingModel model);
        ScheduleViewModel? Update(ScheduleBindingModel model);
        ScheduleViewModel? Delete(ScheduleBindingModel model);
    }
}
