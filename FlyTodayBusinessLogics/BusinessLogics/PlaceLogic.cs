using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class PlaceLogic : IPlaceLogic
    {
        private readonly ILogger _logger;
        private readonly IPlaceStorage _placeStorage;
        public PlaceLogic(ILogger<PlaceLogic> logger, IPlaceStorage placeStorage)
        {
            _logger = logger;
            _placeStorage = placeStorage;
        }
        public bool Create(PlaceBindingModel model)
        {
            CheckModel(model);
            if (_placeStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(PlaceBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_placeStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public PlaceViewModel? ReadElement(PlaceSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. PlaceName:{PlaceName}, IsFree:{IsFree}, Id:{Id}",
                model.PlaceName, model.IsFree, model.Id);
            var element = _placeStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<PlaceViewModel>? ReadList(PlaceSearchModel? model)
        {
            _logger.LogInformation("ReadList. PlaceName:{PlaceName}, IsFree:{IsFree}, Id:{Id}",
                model?.PlaceName, model?.IsFree, model?.Id);
            var list = model == null ? _placeStorage.GetFullList() : _placeStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }


        public bool Update(PlaceBindingModel model)
        {
            CheckModel(model);
            if (_placeStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(PlaceBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (!withParams)
            {
                return;
            }

            if (string.IsNullOrEmpty(model.PlaceName))
            {
                throw new ArgumentException("Не указано название места", nameof(model.PlaceName));
            }

            if (model.FlightId == 0)
            {
                throw new ArgumentException("Не указан ID рейса", nameof(model.FlightId));
            }

            _logger.LogInformation("Place. PlaceName:{PlaceName}, FlightId:{FlightId}, IsFree:{IsFree}, Id:{Id}",
                model.PlaceName, model.FlightId, model.IsFree, model.Id);

            var element = _placeStorage.GetElement(new PlaceSearchModel
            {
                PlaceName = model.PlaceName,
                IsFree = model.IsFree
            });

            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такое место на данном рейсе уже существует.");
            }
        }
    }
}
