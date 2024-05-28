using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Implements
{
    public class UserStorage : IUserStorage
    {
        public UserViewModel? Delete(UserBindingModel model)
        {
            throw new NotImplementedException();
        }

        public UserViewModel? GetElement(UserSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<UserViewModel> GetFilteredList(UserSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<UserViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public UserViewModel? Insert(UserBindingModel model)
        {
            throw new NotImplementedException();
        }

        public UserViewModel? Update(UserBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
