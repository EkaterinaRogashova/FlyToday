using FlyTodayDataModels.Enums;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class EmployeeViewModel : IEmployeeModel
    {
        [DisplayName("Фамилия")]
        public string Surname { get; set; } = string.Empty;
        [DisplayName("Имя")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Отчество")]
        public string LastName { get; set; } = string.Empty;
        [DisplayName("Наличие мед осмотра")]
        public bool MedAnalys { get; set; }
        [DisplayName("Мед осмотр действует до")]
        public DateTime DateMedAnalys { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Пол")]
        public string Gender { get; set; } = string.Empty;
        [DisplayName("Должность")]
        public int PositionAtWorkId { get; set; }
        [DisplayName("Рейс")]
        public int FlightId { get; set; }

        public int Id { get; set; }
        [DisplayName("Тип работы")]
        public TypeWorkEnum TypeWork {  get; set; }
    }
}
