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
    public interface IScheduleLogic
    {
        List<ScheduleViewModel>? ReadList(ScheduleSearchModel? model);
        ScheduleViewModel? ReadElement(ScheduleSearchModel model);
        bool Create(ScheduleBindingModel model);
        bool Update(ScheduleBindingModel model);
        bool Delete(ScheduleBindingModel model);
    }
}
