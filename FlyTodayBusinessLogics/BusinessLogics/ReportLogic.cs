using FlyTodayBusinessLogics.OfficePackage;
using FlyTodayBusinessLogics.OfficePackage.HelperModels;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class ReportLogic : IReportLogic
    {
        private readonly IEmployeeStorage _employeeStorage;
        private readonly IScheduleStorage _scheduleStorage;
        private readonly IBoardingPassStorage _boardingPassStorage;
        private readonly IFlightStorage _flightStorage;
        private readonly IDirectionStorage _directionStorage;
        private readonly IRentStorage _rentStorage;
        private readonly ITicketStorage _ticketStorage;
        private readonly IPlaceStorage _placeStorage;
        private readonly AbstractSaveToPdf _saveToPdf;
        public ReportLogic(IEmployeeStorage employeeStorage, IScheduleStorage scheduleStorage, AbstractSaveToPdf saveToPdf, IBoardingPassStorage boardingPassStorage, IFlightStorage flightStorage, IRentStorage rentStorage, ITicketStorage ticketStorage, IDirectionStorage directionStorage, IPlaceStorage placeStorage)
        {
            _saveToPdf = saveToPdf;
            _employeeStorage = employeeStorage;
            _scheduleStorage = scheduleStorage;
            _boardingPassStorage = boardingPassStorage;
            _flightStorage = flightStorage;
            _rentStorage = rentStorage;
            _ticketStorage = ticketStorage;
            _directionStorage = directionStorage;
            _placeStorage = placeStorage;
        }
        public List<ReportScheduleViewModel> GetSchedule(List<int> Ids)
        {
            var listAll = new List<ReportScheduleViewModel>();
/*
            var listRecipes = _scheduleStorage.GetFilteredList(new RecipesSearchModel
            {
                ClientId = model.ClientId,
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            });

            foreach (var recipe in listRecipes)
            {
                listAll.Add(new ReportScheduleViewModel
                {
                    Date = recipe.Date,
                    Dose = recipe.Dose,
                    ModeofApplication = recipe.ModeOfApplication
                });
            }*/
            return listAll;
        }

        public List<ReportScheduleViewModel> GetScheduleForEmployee(List<int> Ids)
        {
            throw new NotImplementedException();
        }

        public List<ReportBoardingPassesViewModel> GetBoardingPasses(ReportBindingModel model)
        {
            List<ReportBoardingPassesViewModel> list = new();
            var flight = _flightStorage.GetElement(new FlightSearchModel
            {
                Id = model.FlightId
            });
            if (flight != null)
            {
                var direction = _directionStorage.GetElement(new DirectionSearchModel
                {
                    Id = flight.DirectionId
                });
                if (direction != null)
                {
                    var rents = _rentStorage.GetFilteredList(new RentSearchModel
                    {
                        FlightId = flight.Id
                    });
                    if (rents != null)
                    {
                        foreach (var rent in rents)
                        {
                            var tickets = _ticketStorage.GetFilteredList(new TicketSearchModel
                            {
                                RentId = rent.Id
                            });
                            if (tickets != null)
                            {
                                foreach (var ticket in tickets)
                                {
                                    var boardingPass = _boardingPassStorage.GetElement(new BoardingPassSearchModel
                                    {
                                        TicketId = ticket.Id
                                    });
                                    if (boardingPass != null)
                                    {
                                        var place = _placeStorage.GetElement(new PlaceSearchModel
                                        {
                                            Id = boardingPass.PlaceId
                                        });
                                        if (place != null)
                                        {
                                            list.Add(new ReportBoardingPassesViewModel
                                            {
                                                FIO = ticket.Surname + " " + ticket.Name + " " + ticket.LastName,
                                                Seria = ticket.SeriesOfDocument,
                                                Number = ticket.NumberOfDocument,
                                                Place = place.PlaceName,
                                                FlightDirection = direction.CityFrom + " - " + direction.CityTo,
                                                DepartureDate = flight.DepartureDate
                                            });                                            
                                        }                                        
                                    }
                                }
                            }
                        }
                    }
                }                              
            }
            return list;
        }

        public void SaveBoardingPassesToPdf(ReportBindingModel model)
        {
            if (model.FlightId == null)
            {
                throw new ArgumentException("Рейс не выбран");
            }
            var flight = _flightStorage.GetElement(new FlightSearchModel { Id = model.FlightId});
            var direction = _directionStorage.GetElement(new DirectionSearchModel { Id = flight.DirectionId });
            _saveToPdf.CreateDocReportBoardingPasses(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Посадочные талоны",
                BoardingPasses = GetBoardingPasses(model),
                Direction = direction.CityFrom + " - " + direction.CityTo, 
                DepartureDate = flight.DepartureDate.ToShortDateString() + " " + flight.DepartureDate.ToShortTimeString()
            });
        }

        public void SaveRecipesToPdfFile(ReportBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
