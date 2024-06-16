using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using Microsoft.Extensions.Logging;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class FlightLogic : IFlightLogic
    {
        private readonly ILogger _logger;
        private readonly IFlightStorage _flightStorage;
        public FlightLogic(ILogger<FlightLogic> logger, IFlightStorage flightStorage)
        {
            _logger = logger;
            _flightStorage = flightStorage;
        }
        public bool Create(FlightBindingModel model)
        {
            CheckModel(model);
            if (_flightStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(FlightBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_flightStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public FlightViewModel? ReadElement(FlightSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. DepartureDate:{DepartureDate}, FreePlacesCount:{FreePlacesCount}, EconomPrice:{EconomPrice}, BusinessPrice:{BusinessPrice}, Id:{Id}",
                model.DepartureDate, model.FreePlacesCountEconom, model.FreePlacesCountBusiness, model.EconomPrice, model.BusinessPrice, model.Id);
            var element = _flightStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public Dictionary<int, int> GetSubscribers(FlightSearchModel model)
        {
            var dictionary = _flightStorage.GetSubscribers(model);
            if (dictionary == null)
            {
                return null;
            }
            return dictionary;
        }

        public List<FlightViewModel>? ReadList(FlightSearchModel? model)
        {
            _logger.LogInformation("ReadList. DepartureDate:{DepartureDate}, FreePlacesCountEconom:{FreePlacesCountEconom}, FreePlacesCountBusiness:{FreePlacesCountBusiness}, EconomPrice:{EconomPrice}, BusinessPrice:{BusinessPrice}, Id:{Id}",
                model?.DepartureDate, model?.FreePlacesCountEconom, model?.FreePlacesCountBusiness, model?.EconomPrice, model?.BusinessPrice, model?.Id);
            var list = model == null ? _flightStorage.GetFullList() : _flightStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }


        public bool Update(FlightBindingModel model)
        {
            CheckModel(model);
            if (_flightStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        public bool UpdatePrices(FlightBindingModel model)
        {
            if (_flightStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(FlightBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (!withParams)
            {
                return;
            }

            if (model.PlaneId == 0)
            {
                throw new ArgumentException("Не указан ID самолета", nameof(model.PlaneId));
            }

            if (model.DepartureDate == default)
            {
                throw new ArgumentException("Не указана дата вылета", nameof(model.DepartureDate));
            }

            if (model.FreePlacesCountEconom < 0)
            {
                throw new ArgumentException("Количество свободных мест эконом класса должно быть больше или равно 0", nameof(model.FreePlacesCountEconom));
            }

            if (!int.TryParse(model.FreePlacesCountEconom.ToString(), out _))
            {
                throw new ArgumentException("Количество свободных мест эконом класса должно быть целым числом", nameof(model.FreePlacesCountEconom));
            }

            if (model.FreePlacesCountBusiness < 0)
            {
                throw new ArgumentException("Количество свободных мест бизнес класса должно быть больше или равно 0", nameof(model.FreePlacesCountBusiness));
            }

            if (!int.TryParse(model.FreePlacesCountBusiness.ToString(), out _))
            {
                throw new ArgumentException("Количество свободных мест бизнес класса должно быть целым числом", nameof(model.FreePlacesCountBusiness));
            }

            if (model.DirectionId == 0)
            {
                throw new ArgumentException("Не указан ID направления", nameof(model.DirectionId));
            }

            if (model.EconomPrice <= 0)
            {
                throw new ArgumentException("Цена эконом-класса должна быть больше 0", nameof(model.EconomPrice));
            }

            if (!double.TryParse(model.EconomPrice.ToString(), out _))
            {
                throw new ArgumentException("Цена эконом-класса должна быть числом", nameof(model.EconomPrice));
            }

            if (model.BusinessPrice <= 0)
            {
                throw new ArgumentException("Цена бизнес-класса должна быть больше 0", nameof(model.BusinessPrice));
            }

            if (!double.TryParse(model.BusinessPrice.ToString(), out _))
            {
                throw new ArgumentException("Цена бизнес-класса должна быть числом", nameof(model.BusinessPrice));
            }

            if (model.TimeInFlight <= 0)
            {
                throw new ArgumentException("Время в полете должно быть больше 0", nameof(model.TimeInFlight));
            }

            if (!int.TryParse(model.TimeInFlight.ToString(), out _))
            {
                throw new ArgumentException("Время в полете должно быть целым числом", nameof(model.TimeInFlight));
            }

            _logger.LogInformation("Flight. PlaneId:{PlaneId}, DepartureDate:{DepartureDate}, FreePlacesCountEconom:{FreePlacesCountEconom}, FreePlacesCountBusiness:{FreePlacesCountBusiness}, DirectionId:{DirectionId}, EconomPrice:{EconomPrice}, BusinessPrice:{BusinessPrice}, TimeInFlight:{TimeInFlight}, Id:{Id}",
                model.PlaneId, model.DepartureDate, model.FreePlacesCountEconom, model.FreePlacesCountBusiness, model.DirectionId, model.EconomPrice, model.BusinessPrice, model.TimeInFlight, model.Id);

            var element = _flightStorage.GetElement(new FlightSearchModel
            {
                DepartureDate = model.DepartureDate,
                FreePlacesCountEconom = model.FreePlacesCountEconom,
                FreePlacesCountBusiness = model.FreePlacesCountBusiness,
                EconomPrice = model.EconomPrice,
                BusinessPrice = model.BusinessPrice
            });

            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такой рейс уже существует.");
            }
        }

    }
}
