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
    public class SaleLogic : ISaleLogic
    {
        private readonly ILogger _logger;
        private readonly ISaleStorage _saleStorage;
        public SaleLogic(ILogger<SaleLogic> logger, ISaleStorage saleStorage)
        {
            _logger = logger;
            _saleStorage = saleStorage;
        }
        public bool Create(SaleBindingModel model)
        {
            CheckModel(model);
            if (_saleStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(SaleBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_saleStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public SaleViewModel? ReadElement(SaleSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. Category:{Category}. Id:{ Id}", model.Category, model.Id);
            var element = _saleStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<SaleViewModel>? ReadList(SaleSearchModel? model)
        {
            _logger.LogInformation("ReadList. Category:{Category}. Id:{ Id}", model?.Category, model?.Id);
            var list = model == null ? _saleStorage.GetFullList() : _saleStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }

        public bool Update(SaleBindingModel model)
        {
            CheckModel(model);
            if (_saleStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(SaleBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            if (!withParams)
            {
                return;
            }
            if (string.IsNullOrEmpty(model.Category))
            {
                throw new ArgumentNullException("Нет названия льготы", nameof(model.Category));
            }
            if (model.Percent < 0)
            {
                throw new ArgumentNullException("Неверно введенный процент", nameof(model.Percent));
            }
            _logger.LogInformation("Sales. Category:{Category}. Percent:{ Percent}. Id: { Id} ", model.Category, model.Percent, model.Id);
            var element = _saleStorage.GetElement(new SaleSearchModel
            {
                Category = model.Category
            });
            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такая категория уже существует");
            }
        }
    }
}
