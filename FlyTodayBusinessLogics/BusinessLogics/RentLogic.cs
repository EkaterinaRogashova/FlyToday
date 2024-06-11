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
    public class RentLogic : IRentLogic
    {
        private readonly ILogger _logger;
        private readonly IRentStorage _rentStorage;
        public RentLogic(ILogger<RentLogic> logger, IRentStorage rentStorage)
        {
            _logger = logger;
            _rentStorage = rentStorage;
        }
        public bool Create(RentBindingModel model)
        {
            CheckModel(model);
            if (_rentStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(RentBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_rentStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public RentViewModel? ReadElement(RentSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. FlightId: {FlightId}. UserId: {UserId}. Status: {Status} Id:{ Id}", model.FlightId, model.UserId, model.Status, model.Id);
            var element = _rentStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<RentViewModel>? ReadList(RentSearchModel? model)
        {
            _logger.LogInformation("ReadList. FlightId: {FlightId}. UserId: {UserId}. Status: {Status} Id:{ Id}", model?.FlightId, model?.UserId, model?.Status, model?.Id);
            var list = model == null ? _rentStorage.GetFullList() : _rentStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }
        public bool Update(RentBindingModel model)
        {
            CheckModel(model);
            if (_rentStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(RentBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            if (!withParams)
            {
                return;
            }
            if (string.IsNullOrEmpty(model.Status))
            {
                throw new ArgumentNullException("Нет статуса", nameof(model.Status));
            }
            if (model.FlightId < 0)
            {
                throw new ArgumentNullException("Неверныый идентификатор рейса", nameof(model.FlightId));
            }
            if (model.UserId < 0)
            {
                throw new ArgumentNullException("Неверныый идентификатор пользователя", nameof(model.UserId));
            }
            if (model.Cost < 0)
            {
                throw new ArgumentNullException("Неверная цена", nameof(model.Cost));
            }
            if (model.NumberOfBusiness < 0)
            {
                throw new ArgumentNullException("Неверныое количество мест бизнесс-класса", nameof(model.NumberOfBusiness));
            }
            if (model.NumberOfEconomy < 0)
            {
                throw new ArgumentNullException("Неверныое количество мест эконом-класса", nameof(model.NumberOfEconomy));
            }
            _logger.LogInformation("Rent. FlightId: {FlightId}. UserId: {UserId}. Cost: {Cost}. NumberOfBusiness: {NumberOfBusiness}. NumberOfEconomy: {NumberOfEconomy}. Status: {Status}. Id: {Id}", model.FlightId, model.UserId, model.Cost, model.NumberOfBusiness, model.NumberOfEconomy, model.Status, model.Id);
            var element = _rentStorage.GetElement(new RentSearchModel
            {
                UserId = model.UserId,
                FlightId = model.FlightId,
                Status = model.Status
            });
            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такое бронирование уже есть");
            }
        }
    }
}
