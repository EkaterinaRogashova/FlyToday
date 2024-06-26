﻿using FlyTodayDataModels.Enums;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class UserBindingModel : IUserModel
    {
        public string Surname { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public DateTime DateOfBirthday { get; set; }

        public AccessEnum AccessRule { get; set; }
        public bool AllowNotifications { get; set; }

        public int Id { get; set; }
    }
}
