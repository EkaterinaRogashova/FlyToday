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
    public class UserViewModel : IUserModel
    {
        [DisplayName("Фамилия")]
        public string Surname { get; set; } = string.Empty;
        [DisplayName("Имя")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Отчество")]
        public string LastName { get; set; } = string.Empty;
        [DisplayName("Почта")]
        public string Email { get; set; } = string.Empty;
        [DisplayName("Пароль")]
        public string Password { get; set; } = string.Empty;
        [DisplayName("Дата рождения")]
        public DateTime DateOfBirthday { get; set; }
        public AccessEnum AccessRule { get; set; } = AccessEnum.Неизвестен;
        public bool AllowNotifications { get; set; }
        public int Id { get; set; }
    }
}
