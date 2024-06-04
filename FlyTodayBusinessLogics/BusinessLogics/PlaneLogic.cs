using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class PlaneLogic : IPlaneLogic
    {
        private readonly ILogger _logger;
        private readonly IPlaneStorage _planeStorage;
        public PlaneLogic(ILogger<PlaneLogic> logger, IPlaneStorage planeStorage)
        {
            _logger = logger;
            _planeStorage = planeStorage;
        }
        public bool Create(PlaneBindingModel model)
        {
            CheckModel(model);
            if (_planeStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(PlaneBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_planeStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public PlaneViewModel? ReadElement(PlaneSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. ModelName:{ModelName}, Id:{Id}",
                model.ModelName, model.Id);
            var element = _planeStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<PlaneViewModel>? ReadList(PlaneSearchModel? model)
        {
            _logger.LogInformation("ReadList. ModelName:{ModelName}, Id:{Id}",
                model?.ModelName, model?.Id);
            var list = model == null ? _planeStorage.GetFullList() : _planeStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }


        public bool Update(PlaneBindingModel model)
        {
            CheckModel(model);
            if (_planeStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(PlaneBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (!withParams)
            {
                return;
            }

            if (string.IsNullOrEmpty(model.ModelName))
            {
                throw new ArgumentException("Не указано название модели самолета", nameof(model.ModelName));
            }

            if (model.EconomPlacesCount <= 0)
            {
                throw new ArgumentException("Количество мест эконом-класса должно быть больше 0", nameof(model.EconomPlacesCount));
            }

            if (model.BusinessPlacesCount <= 0)
            {
                throw new ArgumentException("Количество мест бизнес-класса должно быть больше 0", nameof(model.BusinessPlacesCount));
            }

            _logger.LogInformation("Plane. ModelName:{ModelName}, EconomPlacesCount:{EconomPlacesCount}, BusinessPlacesCount:{BusinessPlacesCount}, Id:{Id}",
                model.ModelName, model.EconomPlacesCount, model.BusinessPlacesCount, model.Id);

            var element = _planeStorage.GetElement(new PlaneSearchModel
            {
                ModelName = model.ModelName
            });

            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такой самолет уже существует.");
            }
        }

    }
}
