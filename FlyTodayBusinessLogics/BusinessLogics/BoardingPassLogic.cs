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
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class BoardingPassLogic : IBoardingPassLogic
    {
        private readonly ILogger _logger;
        private readonly IBoardingPassStorage _boardingPassStorage;
        public BoardingPassLogic(ILogger<BoardingPassLogic> logger, IBoardingPassStorage boardingPassStorage)
        {
            _logger = logger;
            _boardingPassStorage = boardingPassStorage;
        }
        public bool Create(BoardingPassBindingModel model)
        {
            CheckModel(model);
            if (_boardingPassStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public BoardingPassViewModel? ReadElement(BoardingPassSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. PlaceId:{PlaceId}. TicketId:{TicketId}. Id:{ Id}", model.PlaceId, model.TicketId, model.Id);
            var element = _boardingPassStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id: {Id}", element.Id);
            return element;
        }

        public List<BoardingPassViewModel>? ReadList(BoardingPassSearchModel? model)
        {
            _logger.LogInformation("ReadList. PlaceId:{PlaceId}. TicketId:{TicketId}. Id:{ Id}", model?.PlaceId, model?.TicketId, model?.Id);
            var list = model == null ? _boardingPassStorage.GetFullList() : _boardingPassStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }
        private void CheckModel(BoardingPassBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            if (!withParams)
            {
                return;
            }
            if (model.PlaceId < 0)
            {
                throw new ArgumentNullException("Неверныый идентификатор места", nameof(model.PlaceId));
            }
            if (model.TicketId < 0)
            {
                throw new ArgumentNullException("Неверныый идентификатор билета", nameof(model.TicketId));
            }
            _logger.LogInformation("BoardingPass. PlaceId: {PlaceId}. TicketId: {TicketId}. Id: {Id}", model.PlaceId, model.TicketId, model.Id);
            var element = _boardingPassStorage.GetElement(new BoardingPassSearchModel
            {
                PlaceId = model.PlaceId
            });
            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Посадочный талон с таким местом уже есть");
            }
        }
    }
}
