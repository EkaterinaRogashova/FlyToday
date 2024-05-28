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
    public class BoardingPassLogic : IBoardingPassLogic
    {
        private readonly ILogger _logger;
        private readonly IBoardingPassStorage _boardingPassStorage;
        public BoardingPassLogic(ILogger<BoardingPassLogic> logger, IBoardingPassStorage boardingPassStorage)
        {
            _logger = logger;
            _boardingPassStorage = boardingPassStorage;
        }
        public bool Create(BoardingPassBindingModel model)
        {
            throw new NotImplementedException();
        }

        public BoardingPassViewModel? ReadElement(BoardingPassSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<BoardingPassViewModel>? ReadList(BoardingPassSearchModel? model)
        {
            throw new NotImplementedException();
        }
    }
}
