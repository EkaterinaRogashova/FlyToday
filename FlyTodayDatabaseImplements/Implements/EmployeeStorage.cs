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
    public class EmployeeStorage : IEmployeeStorage
    {
        public EmployeeViewModel? Delete(EmployeeBindingModel model)
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel? GetElement(EmployeeSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeViewModel> GetFilteredList(EmployeeSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel? Insert(EmployeeBindingModel model)
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel? Update(EmployeeBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
