using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Models
{
    public class FlightSubscriber : IFlightSubscriberModel
    {
        public int Id { get; private set; }
        [Required]
        public int FlightId { get; private set; }
        [Required]
        public int UserId { get; private set; }
        public static FlightSubscriber? Create(FlightSubscriberBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new FlightSubscriber()
            {
                Id = model.Id,
                FlightId = model.FlightId,
                UserId = model.UserId,
            };
        }
        public void Update(FlightSubscriberBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            FlightId = model.FlightId;
            UserId = model.UserId;
        }
        public FlightSubscriberViewModel GetViewModel => new()
        {
            FlightId = FlightId,
            UserId = UserId
        };
    }
}

