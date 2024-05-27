using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Models
{
    public class Schedule : IScheduleModel
    {
        public int Id { get; private set; }
        [Required]
        public int EmployeeId { get; private set; }
        [Required]
        public DateTime Date { get; private set; }
        [Required]
        public string Shift { get; private set; } = string.Empty;
        [Required]
        public bool Presence { get; private set; }

        public static Schedule? Create(ScheduleBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Schedule()
            {
                Id = model.Id,
                EmployeeId = model.EmployeeId,
                Date = model.Date,
                Shift = model.Shift,
                Presence = model.Presence
            };
        }
        public static Schedule Create(ScheduleViewModel model)
        {
            return new Schedule
            {
                Id = model.Id,
                EmployeeId= model.EmployeeId,
                Date = model.Date,
                Shift = model.Shift,
                Presence = model.Presence
            };
        }
        public void Update(ScheduleBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            Date = model.Date;
            Shift = model.Shift;
            Presence = model.Presence;
        }
        public ScheduleViewModel GetViewModel => new()
        {
            Id = Id,
            EmployeeId = EmployeeId,
            Date = Date,
            Shift = Shift,
            Presence = Presence
        };
    }
}
