using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;

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
            CheckModel(model);
            if (_directionStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(DirectionBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_directionStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public DirectionViewModel? ReadElement(DirectionSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _logger.LogInformation("ReadElement. CountryFrom:{CountryFrom}. CountryTo:{CountryTo}. CityFrom:{CityFrom}. CityTo:{CityTo}. Id:{ Id}", model.CountryFrom, model.CountryTo, model.CityFrom, model.CityTo, model.Id);
            var element = _directionStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }
            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<DirectionViewModel>? ReadList(DirectionSearchModel? model)
        {
            _logger.LogInformation("ReadList. CountryFrom:{CountryFrom}. CountryTo:{CountryTo}. CityFrom:{CityFrom}. CityTo:{CityTo}. Id:{ Id}", model?.CountryFrom, model?.CountryTo, model?.CityFrom, model?.CityTo, model?.Id);
            var list = model == null ? _directionStorage.GetFullList() : _directionStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }

        public List<(DirectionViewModel, DirectionViewModel)> GetTwoDirectionsWithTransfer(DirectionSearchModel? model)
        {
            _logger.LogInformation("GetTwoDirectionsWithTransfer. CountryFrom:{CountryFrom}. CountryTo:{CountryTo}. CityFrom:{CityFrom}. CityTo:{CityTo}. Id:{ Id}", model?.CountryFrom, model?.CountryTo, model?.CityFrom, model?.CityTo, model?.Id);

            var list = new List<(DirectionViewModel, DirectionViewModel)>();
            if (model != null)
            {
                var listDirFrom = _directionStorage.GetFilteredList(new DirectionSearchModel
                {
                    CountryFrom = model.CountryFrom,
                    CityFrom = model.CityFrom
                });
                if (listDirFrom != null)
                {
                    foreach (var dirFrom in listDirFrom)
                    {
                        var directionTo = _directionStorage.GetCountryCityFrom(new DirectionSearchModel
                        {
                            CityFrom = dirFrom.CityTo,
                            CountryFrom = dirFrom.CountryTo
                        });
                        if (directionTo != null && (directionTo.CityTo.Equals(model.CityTo) || directionTo.CountryTo.Equals(model.CountryTo)))
                        {
                            list.Add((dirFrom, directionTo));
                        }
                    }
                }
            }
            _logger.LogInformation("GetTwoDirectionsWithTransfer. Count:{Count}", list.Count);
            return list;
        }

        public bool Update(DirectionBindingModel model)
        {
            CheckModel(model);
            if (_directionStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(DirectionBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (!withParams)
            {
                return;
            }

            if (string.IsNullOrEmpty(model.CountryFrom))
            {
                throw new ArgumentNullException("Не указана страна отправления", nameof(model.CountryFrom));
            }

            if (string.IsNullOrEmpty(model.CountryTo))
            {
                throw new ArgumentNullException("Не указана страна прибытия", nameof(model.CountryTo));
            }

            if (string.IsNullOrEmpty(model.CityFrom))
            {
                throw new ArgumentNullException("Не указан город отправления", nameof(model.CityFrom));
            }

            if (string.IsNullOrEmpty(model.CityTo))
            {
                throw new ArgumentNullException("Не указан город прибытия", nameof(model.CityTo));
            }

            _logger.LogInformation("Direction. CountryFrom:{CountryFrom}. CountryTo:{CountryTo}. CityFrom:{CityFrom}. CityTo:{CityTo}. Id:{Id}",
                model.CountryFrom, model.CountryTo, model.CityFrom, model.CityTo, model.Id);

            var element = _directionStorage.GetElement(new DirectionSearchModel
            {
                CountryFrom = model.CountryFrom,
                CountryTo = model.CountryTo,
                CityFrom = model.CityFrom,
                CityTo = model.CityTo
            });

            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такое направление уже существует.");
            }
            if (model.CityFrom == model.CityTo || (element != null && element.CityFrom == element.CityTo))
            {
                throw new InvalidOperationException("Конечный пункт не может совпадать с начальным.");
            }
        }
    }
}
