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
            throw new NotImplementedException();
        }

        public bool Delete(TicketBindingModel model)
        {
            throw new NotImplementedException();
        }

        public TicketViewModel? ReadElement(TicketSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<TicketViewModel>? ReadList(TicketSearchModel? model)
        {
            throw new NotImplementedException();
        }
    }
}
