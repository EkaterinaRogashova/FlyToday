using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;
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
            using var context = new FlyTodayDatabase();
            var element = context.Tickets.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Tickets.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public TicketViewModel? GetElement(TicketSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            if (model.Id.HasValue)
                return context.Tickets.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
            //if (!string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(model.Password))
            //    return context.Tickets.FirstOrDefault(x => x.Email.Equals(model.Email) && x.Password.Equals(model.Password))?.GetViewModel;
            //if (!string.IsNullOrEmpty(model.Email))
            //    return context.Tickets.FirstOrDefault(x => x.Email.Equals(model.Email))?.GetViewModel;
            return null;
        }

        public List<TicketViewModel> GetFilteredList(TicketSearchModel model)
        {
            if (model.RentId == null)
            {
                return new();
            }
            using var context = new FlyTodayDatabase();
            return context.Tickets
                .Include(x => x.Rent)
            .Where(x => x.RentId.Equals(model.RentId))
            .ToList()
            .Select(x => x.GetViewModel)
            .ToList();
        }

        public List<TicketViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.Tickets.Select(x => x.GetViewModel).ToList();
        }

        public TicketViewModel? Insert(TicketBindingModel model)
        {
            var newTicket = Ticket.Create(model);
            if (newTicket == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.Tickets.Add(newTicket);
            context.SaveChanges();
            return newTicket.GetViewModel;
        }

        public TicketViewModel? Update(TicketBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var ticket = context.Tickets.FirstOrDefault(x => x.Id == model.Id);
            if (ticket == null)
            {
                return null;
            }
            ticket.Update(model);
            context.SaveChanges();
            return ticket.GetViewModel;
        }
    }
}
