using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class PositionAtWorkLogic : IPositionAtWorkLogic
    {
        private readonly ILogger _logger;
        private readonly IPositionAtWorkStorage _positionAtWorkStorage;
        public PositionAtWorkLogic(ILogger<PositionAtWorkLogic> logger, IPositionAtWorkStorage positionAtWorkStorage)
        {
            _logger = logger;
            _positionAtWorkStorage = positionAtWorkStorage;
        }
        public bool Create(PositionAtWorkBindingModel model)
        {
            CheckModel(model);
            if (_positionAtWorkStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(PositionAtWorkBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_positionAtWorkStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public PositionAtWorkViewModel? ReadElement(PositionAtWorkSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. Name:{Name}. TypeWork: {TypeWork}. Id:{ Id}", model.Name, model.TypeWork, model.Id);
            var element = _positionAtWorkStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<PositionAtWorkViewModel>? ReadList(PositionAtWorkSearchModel? model)
        {
            _logger.LogInformation("ReadList. Category:{Category}. TypeWork: {TypeWork}. Id:{ Id}", model?.Name, model?.TypeWork, model?.Id);
            var list = model == null ? _positionAtWorkStorage.GetFullList() : _positionAtWorkStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }

        public bool Update(PositionAtWorkBindingModel model)
        {
            CheckModel(model);
            if (_positionAtWorkStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(PositionAtWorkBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            if (!withParams)
            {
                return;
            }
            if (string.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentNullException("Нет названия должности", nameof(model.Name));
            }
            _logger.LogInformation("PositionAtWorks. Name:{Name}. TypeWork: {TypeWork}. Id: { Id} ", model.Name, model.Id, model.TypeWork);
            var element = _positionAtWorkStorage.GetElement(new PositionAtWorkSearchModel
            {
                Name = model.Name
            });
            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такая категория уже существует");
            }
        }
    }
}
