using FlyTodayDataModels.Models;
using System.ComponentModel.DataAnnotations;

namespace FlyTodayDatabaseImplements.Models
{
    public class FlightSubscriber : IFlightSubscriberModel
    {
        public int Id { get; set; }
        [Required]
        public int FlightId { get; set; }
        [Required]
        public int UserId { get; set; }
        public virtual Flight Flight { get; set; } = new();
        public virtual User User { get; set; } = new();        
    }
}

