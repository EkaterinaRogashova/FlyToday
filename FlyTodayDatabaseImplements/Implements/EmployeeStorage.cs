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
    public class EmployeeStorage : IEmployeeStorage
    {
        public EmployeeViewModel? Delete(EmployeeBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Employees.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public EmployeeViewModel? GetElement(EmployeeSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            if (model.Id.HasValue)
                return context.Employees.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
            if (!string.IsNullOrEmpty(model.Surname) && model.PositionAtWorkId != null)
                return context.Employees.FirstOrDefault(x => x.Surname.Equals(model.Surname) && x.PositionAtWorkId.Equals(model.PositionAtWorkId))?.GetViewModel;
            return null;
        }

        public List<EmployeeViewModel> GetFilteredList(EmployeeSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.Employees.Select(x => x.GetViewModel).ToList();
        }

        public EmployeeViewModel? Insert(EmployeeBindingModel model)
        {
            var newEmployee = Employee.Create(model);
            if (newEmployee == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.Employees.Add(newEmployee);
            context.SaveChanges();
            return newEmployee.GetViewModel;
        }

        public EmployeeViewModel? Update(EmployeeBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var employee = context.Employees.FirstOrDefault(x => x.Id == model.Id);
            if (employee == null)
            {
                return null;
            }
            employee.Update(model);
            context.SaveChanges();
            return employee.GetViewModel;
        }
    }
}
