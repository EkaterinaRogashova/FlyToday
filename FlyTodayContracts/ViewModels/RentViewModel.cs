using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class RentViewModel : IRentModel
    {
        [DisplayName("Рейс")]
        public int FlightId { get; set; }

        public int UserId { get; set; }
        [DisplayName("Стоимость")]
        public double Cost { get; set; }
        [DisplayName("Количество билетов бизнес-класса:")]
        public int NumberOfBusiness { get; set; }
        [DisplayName("Количество билетов эконом-класса")]
        public int NumberOfEconomy { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; } = string.Empty;
        public int Id { get; set; }
    }
}
