using FlyTodayDataModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface IUserModel : IId
    {
        string Surname { get; }
        string Name { get; }
        string LastName { get; }
        string Email { get; }
        string Password { get; }
        DateTime DateOfBirthday { get; }
        AccessEnum AccessRule { get; }
    }
}
