using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface IRentModel : IId
    {
        int FlightId { get; }
        int UserId { get; }
        double Cost { get; }
        int NumberOfBusiness {  get; }
        int NuberOfEconomy { get; }
        string Status { get; }
    }
}
