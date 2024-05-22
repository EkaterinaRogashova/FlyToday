using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class EmployeeBindingModel : IEmployeeModel
    {
        public string Surname { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public bool MedAnalys { get; set; }

        public DateTime DateMedAnalys { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; } = string.Empty;

        public string JobTitle { get; set; } = string.Empty;

        public int FlightId { get; set; }

        public int Id { get; set; }
    }
}
