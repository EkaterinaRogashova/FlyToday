using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyTodayDatabaseImplements.Models
{
    public class Direction : IDirectionModel
    {
        public int Id { get; private set; }
        [Required]
        public string CountryFrom { get; private set; } = string.Empty;
        [Required]
        public string CountryTo { get; private set; } = string.Empty;
        [Required]
        public string CityFrom { get; private set; } = string.Empty;
        [Required]
        public string CityTo { get; private set; } = string.Empty;

        [ForeignKey("DirectionId")]
        public virtual List<Flight> Flights { get; set; } = new();

        public static Direction? Create(DirectionBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Direction()
            {
                Id = model.Id,
                CountryFrom = model.CountryFrom,
                CountryTo = model.CountryTo,
                CityFrom = model.CityFrom,
                CityTo = model.CityTo
            };
        }

        public void Update(DirectionBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            CountryFrom = model.CountryFrom;
            CountryTo = model.CountryTo;
            CityFrom = model.CityFrom;
            CityTo = model.CityTo;
        }

        public DirectionViewModel GetViewModel => new()
        {
            Id = Id,
            CountryFrom = CountryFrom,
            CountryTo = CountryTo,
            CityFrom = CityFrom,
            CityTo = CityTo
        };
    }
}
