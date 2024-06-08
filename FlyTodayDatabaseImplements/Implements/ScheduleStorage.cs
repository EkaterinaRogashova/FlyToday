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
    public class ScheduleStorage : IScheduleStorage
    {
        public ScheduleViewModel? Delete(ScheduleBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var element = context.Schedules.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Schedules.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public ScheduleViewModel? GetElement(ScheduleSearchModel model)
        {
            //using var context = new FlyTodayDatabase();
            //if (model.Id.HasValue)
            //    return context.Schedules.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
            //if (!string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(model.Password))
            //    return context.Schedules.FirstOrDefault(x => x.Email.Equals(model.Email) && x.Password.Equals(model.Password))?.GetViewModel;
            //if (!string.IsNullOrEmpty(model.Email))
            //    return context.Schedules.FirstOrDefault(x => x.Email.Equals(model.Email))?.GetViewModel;
            return null;
        }

        public List<ScheduleViewModel> GetFilteredList(ScheduleSearchModel model)
        {
            if (string.IsNullOrEmpty(model.Shift))
            {
                return new();
            }
            using var context = new FlyTodayDatabase();
            return context.Schedules.Where(x => x.Shift == model.Shift).Select(x => x.GetViewModel).ToList();
        }

        public List<ScheduleViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.Schedules.Select(x => x.GetViewModel).ToList();
        }

        public ScheduleViewModel? Insert(ScheduleBindingModel model)
        {
            var newSchedule = Schedule.Create(model);
            if (newSchedule == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.Schedules.Add(newSchedule);
            context.SaveChanges();
            return newSchedule.GetViewModel;
        }

        public ScheduleViewModel? Update(ScheduleBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var schedule = context.Schedules.FirstOrDefault(x => x.Id == model.Id);
            if (schedule == null)
            {
                return null;
            }
            schedule.Update(model);
            context.SaveChanges();
            return schedule.GetViewModel;
        }
    }
}
