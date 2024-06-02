using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
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
            using var context = new FlyTodayDatabase();
            var element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Users.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public UserViewModel? GetElement(UserSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            if (model.Id.HasValue)
                return context.Users.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
            if (!string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(model.Password))
                return context.Users.FirstOrDefault(x => x.Email.Equals(model.Email) && x.Password.Equals(model.Password))?.GetViewModel;
            if (!string.IsNullOrEmpty(model.Email))
                return context.Users.FirstOrDefault(x => x.Email.Equals(model.Email))?.GetViewModel;
            return null;
        }

        public List<UserViewModel> GetFilteredList(UserSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<UserViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.Users.Select(x => x.GetViewModel).ToList();
        }

        public UserViewModel? Insert(UserBindingModel model)
        {
            var newUser = User.Create(model);
            if (newUser == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.Users.Add(newUser);
            context.SaveChanges();
            return newUser.GetViewModel;
        }

        public UserViewModel? Update(UserBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var user = context.Users.FirstOrDefault(x => x.Id == model.Id);
            if (user == null)
            {
                return null;
            }
            user.Update(model);
            context.SaveChanges();
            return user.GetViewModel;
        }
    }
}
