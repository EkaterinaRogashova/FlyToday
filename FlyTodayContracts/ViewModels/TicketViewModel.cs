using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class TicketViewModel : ITicketModel
    {
        public int RentId { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; } = string.Empty;
        [DisplayName("Имя")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Отчество")]
        public string LastName { get; set; } = string.Empty;
        [DisplayName("Серия документа")]
        public string SeriesOfDocument { get; set; } = string.Empty;
        [DisplayName("Номер документа")]
        public string NumberOfDocument { get; set; } = string.Empty;
        [DisplayName("Дата рождения")]
        public DateTime DateOfBirthday { get; set; }
        [DisplayName("Пол")]
        public string Sex { get; set; } = string.Empty;
        [DisplayName("Дополнительный багаж")]
        public bool Bags { get; set; }
        [DisplayName("Льгота")]
        public int SaleId { get; set; }
        [DisplayName("Стоимость билета")]
        public double TicketCost { get; set; }

        public int Id { get; set; }
    }
}
