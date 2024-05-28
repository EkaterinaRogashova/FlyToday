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
    public class RentLogic : IRentLogic
    {
        private readonly ILogger _logger;
        private readonly IRentStorage _rentStorage;
        public RentLogic(ILogger<RentLogic> logger, IRentStorage rentStorage)
        {
            _logger = logger;
            _rentStorage = rentStorage;
        }
        public bool Create(RentBindingModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(RentBindingModel model)
        {
            throw new NotImplementedException();
        }

        public RentViewModel? ReadElement(RentSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<RentViewModel>? ReadList(RentSearchModel? model)
        {
            throw new NotImplementedException();
        }

        public bool Update(RentBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
