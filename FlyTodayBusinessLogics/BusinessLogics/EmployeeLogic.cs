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
    public class EmployeeLogic : IEmployeeLogic
    {
        private readonly ILogger _logger;
        private readonly IEmployeeStorage _employeeStorage;
        public EmployeeLogic(ILogger<EmployeeLogic> logger, IEmployeeStorage employeeStorage)
        {
            _logger = logger;
            _employeeStorage = employeeStorage;
        }
        public bool Create(EmployeeBindingModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(EmployeeBindingModel model)
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel? ReadElement(EmployeeSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeViewModel>? ReadList(EmployeeSearchModel? model)
        {
            throw new NotImplementedException();
        }

        public bool Update(EmployeeBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
