using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface ITicketModel : IId
    {
        int RentId { get; }
        string Surname { get; }
        string TypeTicket { get; }
        string Name { get; }
        string LastName { get; }
        string SeriesOfDocument { get; }
        string NumberOfDocument { get; }
        DateTime DateOfBirthday { get; }
        string Gender { get; }
        bool Bags { get; }
        int? SaleId { get; }
        double TicketCost { get; }
    }
}
