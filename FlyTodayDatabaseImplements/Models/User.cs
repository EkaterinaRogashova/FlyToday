using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Enums;
using FlyTodayDataModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyTodayDatabaseImplements.Models
{
    public class User : IUserModel
    {
        public int Id { get; private set; }
        [Required]
        public string Surname { get; private set; } = string.Empty;
        [Required]
        public string Name { get; private set; } = string.Empty;

        public string LastName { get; private set; } = string.Empty;
        [Required]
        public string Email { get; private set; } = string.Empty;
        [Required]
        public string Password { get; private set; } = string.Empty;
        [Required]
        public DateTime DateOfBirthday { get; private set; }
        [Required]
        public AccessEnum AccessRule { get; private set; }
        [Required]
        public bool AllowNotifications { get; private set; }
        [ForeignKey("UserId")]
        public virtual List<FlightSubscriber> FlightSubscribers { get; set; } = new();

        public static User? Create(UserBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new User()
            {
                Id = model.Id,
                Surname = model.Surname,
                Name = model.Name,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password,
                DateOfBirthday = model.DateOfBirthday,
                AccessRule = model.AccessRule,
                AllowNotifications = false
            };
        }
        public static User Create(UserViewModel model)
        {
            return new User
            {
                Id = model.Id,
                Surname = model.Surname,
                Name = model.Name,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password,
                DateOfBirthday = model.DateOfBirthday,
                AccessRule = model.AccessRule,
                AllowNotifications = false
            };
        }
        public void Update(UserBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            Surname = model.Surname;
            Name = model.Name;
            LastName = model.LastName;
            Email = model.Email;
            Password = model.Password;
            DateOfBirthday = model.DateOfBirthday;
            AccessRule = model.AccessRule;
            AllowNotifications = model.AllowNotifications;
        }
        public UserViewModel GetViewModel => new()
        {
            Id = Id,
            Name = Name,
            Surname = Surname,
            LastName = LastName,  
            Email = Email,
            Password = Password,
            DateOfBirthday = DateOfBirthday,
            AccessRule = AccessRule,
            AllowNotifications = AllowNotifications
        };       
    }
}
