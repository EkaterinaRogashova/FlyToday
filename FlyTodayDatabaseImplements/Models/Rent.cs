using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyTodayDataModels.Models;

namespace FlyTodayDatabaseImplements.Models
{
    public class Rent : IRentModel
    {
        public int Id { get; private set; }
        [Required]
        public int FlightId { get; private set; }
        [Required]
        public int UserId { get; private set; }
        [Required]
        public double Cost { get; private set; }
        [Required]
        public int NumberOfBusiness { get; private set; }
        [Required]
        public int NuberOfEconomy { get; private set; }
        [Required]
        public string Status { get; private set; } = string.Empty;

        public int NumberOfEconomy => throw new NotImplementedException();
    }
}
