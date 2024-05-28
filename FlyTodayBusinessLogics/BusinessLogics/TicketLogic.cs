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
    public class TicketLogic : ITicketLogic
    {
        private readonly ILogger _logger;
        private readonly ITicketStorage _ticketStorage;
        public TicketLogic(ILogger<TicketLogic> logger, ITicketStorage ticketStorage)
        {
            _logger = logger;
            _ticketStorage = ticketStorage;
        }
        public bool Create(TicketBindingModel model)
        {
            CheckModel(model);
            if (_ticketStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(TicketBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_ticketStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public TicketViewModel? ReadElement(TicketSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. RentId:{RentId}. SeriesOfDocument:{SeriesOfDocument}. NumberOfDocument:{NumberOfDocument}. Bags:{Bags}. Id:{ Id}", model.RentId, model.SeriesOfDocument, model.NumberOfDocument, model.Bags, model.Id);
            var element = _ticketStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<TicketViewModel>? ReadList(TicketSearchModel? model)
        {
            _logger.LogInformation("ReadList. RentId:{RentId}. SeriesOfDocument:{SeriesOfDocument}. NumberOfDocument:{NumberOfDocument}. Bags:{Bags}. Id:{ Id}", model?.RentId, model?.SeriesOfDocument, model?.NumberOfDocument, model?.Bags, model?.Id);
            var list = model == null ? _ticketStorage.GetFullList() : _ticketStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }

        private void CheckModel(TicketBindingModel model, bool withParams = true)
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
                throw new ArgumentNullException("Нет фамилии пассажира", nameof(model.Surname));
            }
            if (string.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentNullException("Нет имени пассажира", nameof(model.Name));
            }
            if (string.IsNullOrEmpty(model.SeriesOfDocument))
            {
                throw new ArgumentNullException("Нет серии документа", nameof(model.SeriesOfDocument));
            }
            if (string.IsNullOrEmpty(model.NumberOfDocument))
            {
                throw new ArgumentNullException("Нет номера документа", nameof(model.NumberOfDocument));
            }
            if (string.IsNullOrEmpty(model.Gender))
            {
                throw new ArgumentNullException("Не указан пол пассажира", nameof(model.Gender));
            }
            if (model.RentId < 0)
            {
                throw new ArgumentNullException("Неверный идентификатор бронирования", nameof(model.RentId));
            }
            if (model.SaleId < 0)
            {
                throw new ArgumentNullException("Неверный идентификатор льготы", nameof(model.SaleId));
            }
            if (model.TicketCost < 0)
            {
                throw new ArgumentNullException("Неверная стоимость", nameof(model.TicketCost));
            }
            if (model.DateOfBirthday < new DateTime(1900, 1, 1) || model.DateOfBirthday > DateTime.Now)
            {
                throw new ArgumentNullException("Неверная дата рождения пассажира", nameof(model.DateOfBirthday));
            }
            _logger.LogInformation("Ticket. RentId:{RentId}. Surname:{ Surname}. Name:{Name}. LastName:{LastName}. SeriesOfDocument:{SeriesOfDocument}. NumberOfDocument:{NumberOfDocument}. DateOfBirthday:{DateOfBirthday}. Gender:{Gender}. Bags:{Bags}. SaleId:{SaleId}. TicketCost:{TicketCost}. Id: { Id} ", model.RentId, model.Surname, model.SaleId, model.LastName, model.Name, model.SeriesOfDocument, model.NumberOfDocument, model.DateOfBirthday, model.Gender, model.Bags, model.TicketCost, model.Id);
            var element = _ticketStorage.GetElement(new TicketSearchModel
            {
                RentId = model.RentId,
                SeriesOfDocument = model.SeriesOfDocument,
                NumberOfDocument = model.NumberOfDocument,
                Bags = model.Bags
            });
            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("такой билет уже существует");
            }
        }
    }
}
