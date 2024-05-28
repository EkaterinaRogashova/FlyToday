using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Implements
{
    public class TicketStorage : ITicketStorage
    {
        public TicketViewModel? Delete(TicketBindingModel model)
        {
            throw new NotImplementedException();
        }

        public TicketViewModel? GetElement(TicketSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<TicketViewModel> GetFilteredList(TicketSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<TicketViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public TicketViewModel? Insert(TicketBindingModel model)
        {
            throw new NotImplementedException();
        }

        public TicketViewModel? Update(TicketBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
