using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface IEmployeeModel : IId
    {
        string Surname { get; }
        string Name { get; }
        string LastName { get; }
        bool MedAnalys {  get; }
        DateTime DateMedAnalys { get; }
        DateTime DateOfBirth {  get; }
        string Sex { get; }
        string JobTitle { get; }
        int FlightId { get; }

    }
}
