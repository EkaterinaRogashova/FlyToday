using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            throw new NotImplementedException();
        }

        public bool Delete(UserBindingModel model)
        {
            throw new NotImplementedException();
        }

        public UserViewModel? ReadElement(UserSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<UserViewModel>? ReadList(UserSearchModel? model)
        {
            throw new NotImplementedException();
        }

        public bool Update(UserBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
