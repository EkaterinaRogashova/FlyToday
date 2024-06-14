using FlyTodayDataModels.Models;
using System.ComponentModel.DataAnnotations;

namespace FlyTodayDatabaseImplements.Models
{
    public class FlightSubscriber : IFlightSubscriberModel
    {
        public int Id { get; private set; }
        [Required]
        public int FlightId { get; private set; }
        [Required]
        public int UserId { get; private set; }
        public virtual Flight Flight { get; set; } = new();
        public virtual User User { get; set; } = new();        
    }
}

