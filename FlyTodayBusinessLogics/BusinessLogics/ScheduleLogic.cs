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
            CheckModel(model);
            if (_scheduleStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(ScheduleBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_scheduleStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public ScheduleViewModel? ReadElement(ScheduleSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. EmployeeId:{EmployeeId}. Date:{ Date}. Shift: {Shift}. Id: { Id} ", model.EmployeeId, model.Shift, model.Date, model.Id);
            var element = _scheduleStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<ScheduleViewModel>? ReadList(ScheduleSearchModel? model)
        {
            _logger.LogInformation("ReadList. EmployeeId:{EmployeeId}. Date:{ Date}. Shift: {Shift}. Id: { Id} ", model?.EmployeeId, model?.Shift, model?.Date, model?.Id);
            var list = model == null ? _scheduleStorage.GetFullList() : _scheduleStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }

        public bool Update(ScheduleBindingModel model)
        {
            CheckModel(model);
            if (_scheduleStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(ScheduleBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            if (!withParams)
            {
                return;
            }
            if (string.IsNullOrEmpty(model.Shift))
            {
                throw new ArgumentNullException("Нет названия смены", nameof(model.Shift));
            }
            if (model.EmployeeId < 0)
            {
                throw new ArgumentNullException("Неверный идентификатор сотрудника", nameof(model.EmployeeId));
            }
            _logger.LogInformation("Schedule. EmployeeId:{EmployeeId}. Date:{ Date}. Shift: {Shift}. Presence: {Presence}. Id: { Id} ", model.EmployeeId, model.Shift, model.Date, model.Presence, model.Id);
            var element = _scheduleStorage.GetElement(new ScheduleSearchModel
            {
                EmployeeId = model.EmployeeId,
                Shift = model.Shift,
                Date = model.Date
            });
            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такая запись в расписании уже есть");
            }
        }
    }
}
