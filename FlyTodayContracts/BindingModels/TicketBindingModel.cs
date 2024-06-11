using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class TicketBindingModel : ITicketModel
    {
        public int RentId { get; set; }
        public string TypeTicket { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string SeriesOfDocument { get; set; } = string.Empty;

        public string NumberOfDocument { get; set; } = string.Empty;

        public DateTime DateOfBirthday { get; set; }

        public string Gender { get; set; } = string.Empty;

        public bool Bags { get; set; }

        public int? SaleId { get; set; }

        public double TicketCost { get; set; }

        public int Id { get; set; }
    }
}
