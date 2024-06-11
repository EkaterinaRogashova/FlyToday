using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FlyTodayDatabaseImplements.Models
{
    public class Ticket : ITicketModel
    {
        public int Id { get; private set; }
        [Required]
        public int RentId { get; private set; }
        [Required]
        public string TypeTicket { get; private set; } = string.Empty;
        [Required]
        public string Surname { get; private set; } = string.Empty;
        [Required]
        public string Name { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        [Required]
        public string SeriesOfDocument { get; private set; } = string.Empty;
        [Required]
        public string NumberOfDocument { get; private set; } = string.Empty;
        [Required]
        public DateTime DateOfBirthday { get; private set; }
        [Required]
        public string Gender { get; private set; } = string.Empty;
        [Required]
        public bool Bags { get; private set; }

        public int? SaleId { get; private set; }
        [Required]
        public double TicketCost { get; private set; }

        public Sale Sale { get; set; }
        public Rent Rent { get; set; }
        public static Ticket? Create(TicketBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Ticket()
            {
                Id = model.Id,
                TypeTicket = model.TypeTicket,
                Surname = model.Surname,
                Name = model.Name,
                LastName = model.LastName,
                SeriesOfDocument = model.SeriesOfDocument,
                NumberOfDocument = model.NumberOfDocument,
                DateOfBirthday = model.DateOfBirthday,
                Gender = model.Gender,
                Bags = model.Bags,
                SaleId = model.SaleId,
                TicketCost = model.TicketCost,
                RentId = model.RentId
            };
        }
        public static Ticket Create(TicketViewModel model)
        {
            return new Ticket
            {
                Id = model.Id,
                TypeTicket = model.TypeTicket,
                Surname = model.Surname,
                Name = model.Name,
                LastName = model.LastName,
                SeriesOfDocument = model.SeriesOfDocument,
                NumberOfDocument = model.NumberOfDocument,
                DateOfBirthday = model.DateOfBirthday,
                Gender = model.Gender,
                Bags = model.Bags,
                SaleId = model.SaleId,
                TicketCost = model.TicketCost,
                RentId = model.RentId
            };
        }
        public void Update(TicketBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            TypeTicket = model.TypeTicket; 
            Surname = model.Surname;
            Name = model.Name;
            LastName = model.LastName;
            SeriesOfDocument = model.SeriesOfDocument;
            NumberOfDocument = model.NumberOfDocument;
            DateOfBirthday = model.DateOfBirthday;
            Gender = model.Gender;
            Bags = model.Bags;
            SaleId = model.SaleId;
            TicketCost = model.TicketCost;
            RentId = model.RentId;
        }
        public TicketViewModel GetViewModel => new()
        {
            Id = Id,
            TypeTicket = TypeTicket,
            Surname = Surname,
            Name = Name,
            LastName = LastName,
            SeriesOfDocument = SeriesOfDocument,
            NumberOfDocument = NumberOfDocument,
            DateOfBirthday = DateOfBirthday,
            Gender = Gender,
            Bags = Bags,
            SaleId = SaleId,
            TicketCost = TicketCost,
            RentId = RentId
        };
    }
}
