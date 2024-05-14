using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.StoragesContracts
{
    public interface ITicketStorage
    {
        List<TicketViewModel> GetFullList();
        List<TicketViewModel> GetFilteredList(TicketSearchModel model);
        TicketViewModel? GetElement(TicketSearchModel model);
        TicketViewModel? Insert(TicketBindingModel model);
        TicketViewModel? Update(TicketBindingModel model);
        TicketViewModel? Delete(TicketBindingModel model);
    }
}
