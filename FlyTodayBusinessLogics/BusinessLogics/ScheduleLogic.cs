using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class ScheduleLogic : IScheduleLogic
    {
        private readonly ILogger _logger;
        private readonly IScheduleStorage _scheduleStorage;
        public ScheduleLogic(ILogger<ScheduleLogic> logger, IScheduleStorage scheduleStorage)
        {
            _logger = logger;
            _scheduleStorage = scheduleStorage;
        }
        public bool Create(ScheduleBindingModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ScheduleBindingModel model)
        {
            throw new NotImplementedException();
        }

        public ScheduleViewModel? ReadElement(ScheduleSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<ScheduleViewModel>? ReadList(ScheduleSearchModel? model)
        {
            throw new NotImplementedException();
        }

        public bool Update(ScheduleBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
