using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface IBoardingPassModel : IId
    {
        int TicketId { get; }
        int PlaceId { get; }
    }
}
