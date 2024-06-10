using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
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
        public int NumberOfEconomy { get; private set; }
        [Required]
        public string Status { get; private set; } = string.Empty;

        public Flight Flight { get; set; }
        public User User { get; set; }
        public static Rent? Create(RentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Rent()
            {
                Id = model.Id,
                FlightId = model.FlightId,
                UserId = model.UserId,
                Cost = model.Cost,
                NumberOfBusiness = model.NumberOfBusiness,
                NumberOfEconomy = model.NumberOfEconomy,
                Status = model.Status
            };
        }
        public static Rent Create(RentViewModel model)
        {
            return new Rent
            {
                Id = model.Id,
                FlightId = model.FlightId,
                UserId = model.UserId,
                Cost = model.Cost,
                NumberOfBusiness = model.NumberOfBusiness,
                NumberOfEconomy = model.NumberOfEconomy,
                Status = model.Status
            };
        }
        public void Update(RentBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            Cost = model.Cost;
            Status = model.Status;
        }
        public RentViewModel GetViewModel => new()
        {
            Id = Id,
            FlightId = FlightId, 
            UserId = UserId,
            Cost = Cost,
            NumberOfBusiness = NumberOfBusiness,
            NumberOfEconomy = NumberOfEconomy,
            Status = Status
        };
    }
}
