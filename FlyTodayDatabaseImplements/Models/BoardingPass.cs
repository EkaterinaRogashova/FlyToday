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
    public class BoardingPass : IBoardingPassModel
    {
        public int Id { get; private set; }
        [Required]
        public int TicketId { get; set;  }
        [Required]
        public int PlaceId { get; set; }
        public Ticket Ticket { get; set; }
        public Place Place { get; set; }

        public static BoardingPass? Create(BoardingPassBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new BoardingPass()
            {
                Id = model.Id,
                TicketId = model.TicketId,
                PlaceId = model.PlaceId
            };
        }
        public static BoardingPass Create(BoardingPassViewModel model)
        {
            return new BoardingPass()
            {
                Id = model.Id,
                TicketId = model.TicketId,
                PlaceId = model.PlaceId
            };
        }

        public BoardingPassViewModel GetViewModel => new()
        {
            Id = Id,
            TicketId = TicketId,
            PlaceId = PlaceId
        };

    }
}
