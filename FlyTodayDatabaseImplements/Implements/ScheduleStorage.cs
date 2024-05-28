using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Implements
{
    public class ScheduleStorage : IScheduleStorage
    {
        public ScheduleViewModel? Delete(ScheduleBindingModel model)
        {
            throw new NotImplementedException();
        }

        public ScheduleViewModel? GetElement(ScheduleSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<ScheduleViewModel> GetFilteredList(ScheduleSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<ScheduleViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public ScheduleViewModel? Insert(ScheduleBindingModel model)
        {
            throw new NotImplementedException();
        }

        public ScheduleViewModel? Update(ScheduleBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
