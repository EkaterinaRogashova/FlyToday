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
    public class FlightLogic : IFlightLogic
    {
        private readonly ILogger _logger;
        private readonly IFlightStorage _flightStorage;
        public FlightLogic(ILogger<FlightLogic> logger, IFlightStorage flightStorage)
        {
            _logger = logger;
            _flightStorage = flightStorage;
        }
        public bool Create(FlightBindingModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(FlightBindingModel model)
        {
            throw new NotImplementedException();
        }

        public FlightViewModel? ReadElement(FlightSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<FlightViewModel>? ReadList(FlightSearchModel? model)
        {
            throw new NotImplementedException();
        }

        public bool Update(FlightBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
