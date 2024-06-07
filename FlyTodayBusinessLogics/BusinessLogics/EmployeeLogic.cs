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
    public class EmployeeLogic : IEmployeeLogic
    {
        private readonly ILogger _logger;
        private readonly IEmployeeStorage _employeeStorage;
        public EmployeeLogic(ILogger<EmployeeLogic> logger, IEmployeeStorage employeeStorage)
        {
            _logger = logger;
            _employeeStorage = employeeStorage;
        }
        public bool Create(EmployeeBindingModel model)
        {
            CheckModel(model);
            if (_employeeStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(EmployeeBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_employeeStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public EmployeeViewModel? ReadElement(EmployeeSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. Employee. Surname: {Surname}. MedAnalys: {MedAnalys}. PositionAtWorkId: {PositionAtWorkId}. TypeWork: {TypeWork}. Id: {Id}", model.Surname, model.MedAnalys, model.PositionAtWorkId, model.TypeWork, model.Id);
            var element = _employeeStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<EmployeeViewModel>? ReadList(EmployeeSearchModel? model)
        {
            _logger.LogInformation("ReadList. Surname: {Surname}. MedAnalys: {MedAnalys}. PositionAtWorkId: {PositionAtWorkId}. TypeWork: {TypeWork}. Id: {Id}", model?.Surname, model?.MedAnalys, model?.PositionAtWorkId, model?.TypeWork, model?.Id);
            var list = model == null ? _employeeStorage.GetFullList() : _employeeStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }

        public bool Update(EmployeeBindingModel model)
        {
            CheckModel(model);
            if (_employeeStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(EmployeeBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            if (!withParams)
            {
                return;
            }
            if (string.IsNullOrEmpty(model.Surname))
            {
                throw new ArgumentNullException("Нет фамилии сотрудника", nameof(model.Surname));
            }
            if (string.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentNullException("Нет имени сотрудника", nameof(model.Name));
            }
            if (string.IsNullOrEmpty(model.Gender))
            {
                throw new ArgumentNullException("Нет пола сотрудника", nameof(model.Gender));
            }
            if (model.DateOfBirth < new DateTime(1900, 1, 1) || model.DateOfBirth > DateTime.Now)
            {
                throw new ArgumentNullException("Неверная дата рождения сотрудника", nameof(model.DateOfBirth));
            }
            if (model.PositionAtWorkId < 0)
            {
                throw new ArgumentNullException("Неверный идентификатор должности", nameof(model.PositionAtWorkId));
            }
            _logger.LogInformation("Employee. Surname: {Surname}. Name: {Name}. LastName: {LastName}. DateOfBirth: {DateOfBirth}. MedAnalys: {MedAnalys}. DateMedAnalys: {DateMedAnalys}. Gender: {Gender}. PositionAtWorkId: {PositionAtWorkId}. TypeWork: {TypeWork}. Id: {Id}", model.Name, model.Surname, model.LastName, model.DateOfBirth, model.DateMedAnalys, model.MedAnalys, model.PositionAtWorkId, model.Gender, model.TypeWork, model.Id);
            var element = _employeeStorage.GetElement(new EmployeeSearchModel
            {
                Surname = model.Surname,
                PositionAtWorkId = model.PositionAtWorkId
            });
            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такой сотрудник уже есть");
            }
        }
    }
}
