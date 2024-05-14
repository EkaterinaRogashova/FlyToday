using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BusinessLogicContracts
{
    public interface ITicketLogic
    {
        List<TicketViewModel>? ReadList(TicketSearchModel? model);
        TicketViewModel? ReadElement(TicketSearchModel model);
        bool Create(TicketBindingModel model);
        bool Delete(TicketBindingModel model);
    }
}
