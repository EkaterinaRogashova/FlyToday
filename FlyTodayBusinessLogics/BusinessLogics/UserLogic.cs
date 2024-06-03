﻿using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class UserLogic : IUserLogic
    {
        private readonly ILogger _logger;
        private readonly IUserStorage _userStorage;
        public UserLogic(ILogger<UserLogic> logger, IUserStorage userStorage)
        {
            _logger = logger;
            _userStorage = userStorage;
        }
        public bool Create(UserBindingModel model)
        {
            CheckModel(model);
            if (_userStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(UserBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id: {Id}", model.Id);
            if (_userStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public UserViewModel? ReadElement(UserSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. Email: {Email}. Id: {Id}.", model.Email, model.Id);
            var element = _userStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id: {Id}", element.Id);
            return element;
        }

        public List<UserViewModel>? ReadList(UserSearchModel? model)
        {
            _logger.LogInformation("ReadList. Email: {Email}. Id: {Id}.", model?.Email, model?.Id);
            var list = model == null ? _userStorage.GetFullList() : _userStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count: {Count}", list.Count);
            return list;
        }

        public bool Update(UserBindingModel model)
        {
            CheckModel(model);
            if (_userStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(UserBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            if (!withParams)
            {
                return;
            }
            if (string.IsNullOrEmpty(model.Surname))
            {
                throw new ArgumentNullException("Нет фамилии пользователя", nameof(model.Surname));
            }
            if (string.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentNullException("Нет имени пользователя", nameof(model.Name));
            }
            if (!Regex.IsMatch(model.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
            {
                throw new ArgumentException("Неправильно введенный email", nameof(model.Email));
            }

            if (!Regex.IsMatch(model.Password, @"^^((\w+\d+\W+)|(\w+\W+\d+)|(\d+\w+\W+)|(\d+\W+\w+)|(\W+\w+\d+)|(\W+\d+\w+))[\w\d\W]*$", RegexOptions.IgnoreCase))
            {
                throw new ArgumentException("Неправильно введенный пароль", nameof(model.Password));
            }
            if (model.DateOfBirthday < new DateTime(1900, 1, 1) || model.DateOfBirthday > DateTime.Now)
            {
                throw new ArgumentNullException("Неверная дата рождения", nameof(model.DateOfBirthday));
            }
            _logger.LogInformation("User. Surname:{Surname}. Name:{Name} LastName:{ LastName}. Email: {Email}. Password: {Password}. DateOfBirthday: {DateOfBirthday}. AccessRule: {AccessRule}. Id: { Id} ", model.Surname, model.Name, model.LastName, model.Email, model.Password, model.DateOfBirthday, model.AccessRule, model.Id);
            var element = _userStorage.GetElement(new UserSearchModel
            {
                Email = model.Email
            });
            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Пользователь с такой почтой уже есть");
            }
        }
    }
}