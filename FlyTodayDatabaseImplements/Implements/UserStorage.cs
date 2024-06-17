using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
                return context.Users.Where(x => x.Id == model.Id).Select(x => x.GetViewModel).FirstOrDefault();
            if (!string.IsNullOrEmpty(model.Email))
                return context.Users.FirstOrDefault(x => x.Email.Equals(model.Email))?.GetViewModel;
            return null;
        }

        public List<UserViewModel> GetFilteredList(UserSearchModel model)
        {
            using var context = new FlyTodayDatabase();

                return context.Users
             .Where(x => 
                (model.Id.HasValue && x.Id == model.Id)).ToList()
            .Select(x => x.GetViewModel).ToList();          

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
