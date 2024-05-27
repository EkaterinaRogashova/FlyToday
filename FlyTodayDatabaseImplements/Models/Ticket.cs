using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FlyTodayDatabaseImplements.Models
{
    public class Ticket : ITicketModel
    {
        public int Id { get; private set; }

        public int RentId { get; private set; }

        public string Surname { get; private set; } = string.Empty;

        public string Name { get; private set; } = string.Empty;

        public string LastName { get; private set; } = string.Empty;

        public string SeriesOfDocument { get; private set; } = string.Empty;

        public string NumberOfDocument { get; private set; } = string.Empty;

        public DateTime DateOfBirthday { get; private set; }

        public string Sex { get; private set; } = string.Empty;

        public bool Bags { get; private set; }

        public int SaleId { get; private set; }

        public double TicketCost { get; private set; }

        //public static Ticket? Create(TicketBindingModel model)
        //{
        //    if (model == null)
        //    {
        //        return null;
        //    }
        //    return new Ticket()
        //    {
        //        Id = model.Id,
        //        EmployeeId = model.EmployeeId,
        //        Date = model.Date,
        //        Shift = model.Shift,
        //        Presence = model.Presence
        //    };
        //}
        //public static Ticket Create(TicketViewModel model)
        //{
        //    return new Ticket
        //    {
        //        Id = model.Id,
        //        EmployeeId = model.EmployeeId,
        //        Date = model.Date,
        //        Shift = model.Shift,
        //        Presence = model.Presence
        //    };
        //}
        //public void Update(TicketBindingModel model)
        //{
        //    if (model == null)
        //    {
        //        return;
        //    }
        //    Date = model.Date;
        //    Shift = model.Shift;
        //    Presence = model.Presence;
        //}
        //public TicketViewModel GetViewModel => new()
        //{
        //    Id = Id,
        //    EmployeeId = EmployeeId,
        //    Date = Date,
        //    Shift = Shift,
        //    Presence = Presence
        //};
    }
}
