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
    public class FlightSubscriberLogic : IFlightSubscriberLogic
    {
        private readonly ILogger _logger;
        private readonly IFlightSubscriberStorage _flightSubscriberStorage;
        public FlightSubscriberLogic(ILogger<FlightSubscriberLogic> logger, IFlightSubscriberStorage flightSubscriberStorage)
        {
            _logger = logger;
            _flightSubscriberStorage = flightSubscriberStorage;
        }
        public bool Create(FlightSubscriberBindingModel model)
        {
            CheckModel(model);
            if (_flightSubscriberStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(FlightSubscriberBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_flightSubscriberStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public FlightSubscriberViewModel? ReadElement(FlightSubscriberSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. FlightId:{FlightId}. UserId:{UserId}. Id:{ Id}", model.FlightId, model.UserId, model.Id);
            var element = _flightSubscriberStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<FlightSubscriberViewModel>? ReadList(FlightSubscriberSearchModel? model)
        {
            _logger.LogInformation("ReadList. FlightId:{FlightId}. UserId:{UserId}. Id:{ Id}", model?.FlightId, model?.UserId, model?.Id);
            var list = model == null ? _flightSubscriberStorage.GetFullList() : _flightSubscriberStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }

        public bool Update(FlightSubscriberBindingModel model)
        {
            CheckModel(model);
            if (_flightSubscriberStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(FlightSubscriberBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            if (!withParams)
            {
                return;
            }
            if (model.UserId == 0)
            {
                throw new ArgumentNullException("Нет пользователя", nameof(model.UserId));
            }
            if (model.FlightId == 0)
            {
                throw new ArgumentNullException("Нет рейса", nameof(model.FlightId));
            }
            _logger.LogInformation("FlightSubscribers. FlightId:{FlightId}. UserId:{UserId}. Id:{ Id}", model.FlightId, model.UserId, model.Id);
            var element = _flightSubscriberStorage.GetElement(new FlightSubscriberSearchModel
            {
                UserId = model.UserId, FlightId = model.FlightId
            });
            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такой подписчик уже существует");
            }
        }
    }
}
