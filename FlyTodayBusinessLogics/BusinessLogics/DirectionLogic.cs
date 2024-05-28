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
    public class DirectionLogic : IDirectionLogic
    {
        private readonly ILogger _logger;
        private readonly IDirectionStorage _directionStorage;
        public DirectionLogic(ILogger<DirectionLogic> logger, IDirectionStorage directionStorage)
        {
            _logger = logger;
            _directionStorage = directionStorage;
        }
        public bool Create(DirectionBindingModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DirectionBindingModel model)
        {
            throw new NotImplementedException();
        }

        public DirectionViewModel? ReadElement(DirectionSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<DirectionViewModel>? ReadList(DirectionSearchModel? model)
        {
            throw new NotImplementedException();
        }

        public bool Update(DirectionBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
