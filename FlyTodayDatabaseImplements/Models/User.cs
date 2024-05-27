using FlyTodayDataModels.Enums;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Models
{
    public class User : IUserModel
    {
        public int Id { get; private set; }

        public string Surname => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string LastName => throw new NotImplementedException();

        public string Email => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public DateTime DateOfBirthday => throw new NotImplementedException();

        public AccessEnum AccessRule => throw new NotImplementedException();
    }
}
