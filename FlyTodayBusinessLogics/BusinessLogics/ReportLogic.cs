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
        public List<ReportScheduleViewModel> GetSchedule(ReportScheduleBindingModel model)
        {
            var listAll = new List<ReportScheduleViewModel>();

            var listSchedule = _scheduleStorage.GetFilteredList(new ScheduleSearchModel
/*
            var listRecipes = _scheduleStorage.GetFilteredList(new RecipesSearchModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            });
            
            foreach (var schedule in listSchedule)
            {
                var employee = _employeeStorage.GetElement(new EmployeeSearchModel
                {
                    Id = schedule.EmployeeId,
                });
                listAll.Add(new ReportScheduleViewModel
                {
                    Date = schedule.Date,
                    Shift = schedule.Shift,
                    EmployeeFIO = employee.Surname + " " + employee.Name + " " + employee.LastName
                });
            }*/
            return listAll;
        }

        public List<ReportScheduleForEmployeeViewModel> GetScheduleForEmployee(List<int> Ids)
        {
            if (Ids == null || Ids.Count == 0)
            {
                return new List<ReportScheduleForEmployeeViewModel>();
            }

            var employees = _employeeStorage.GetFilteredList(new EmployeeSearchModel { Id = null }); // получаем всех сотрудников
            var schedules = _scheduleStorage.GetFilteredList(new ScheduleSearchModel { EmployeeId = null }); // получаем все расписания

            var result = new List<ReportScheduleForEmployeeViewModel>();

            foreach (var employeeId in Ids)
            {
                var employee = _employeeStorage.GetElement(new EmployeeSearchModel { Id = employeeId });

                var employeeSchedules = _scheduleStorage.GetFilteredList(new ScheduleSearchModel { EmployeeId = employeeId });

                var reportSchedule = new ReportScheduleForEmployeeViewModel
                {
                    EmployeeFIO = employee.Surname + " " + employee.Name + "" + employee.LastName,
                    Schedule = employeeSchedules.Select(s => new Tuple<DateTime, string>(s.Date, s.Shift)).ToList()
                };

                result.Add(reportSchedule);
            }
            return result;
        }

        public void SaveReportScheduleToPdfFile(ReportScheduleBindingModel model)
        {
            if (model.DateFrom == null)
            {
                throw new ArgumentException("Дата начала не задана");
            }

            if (model.DateTo == null)
            {
                throw new ArgumentException("Дата окончания не задана");
            }
            _saveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Расписание",
                DateFrom = model.DateFrom!.Value,
                DateTo = model.DateTo!.Value,
                Schedule = GetSchedule(model)
            });
        }

        public void SaveReportScheduleForEmployeeToPdfFile(ReportScheduleBindingModel model)
        {
            if (model.EmployeeId == 0 && (model.Ids == null || model.Ids.Count == 0))
            {
                throw new ArgumentException("Сотрудник не найден");
            }

            var scheduleForEmployees = GetScheduleForEmployee(model.Ids ?? new List<int> { model.EmployeeId });
            var scheduleViewModels = scheduleForEmployees.SelectMany(s => s.Schedule.Select(t => new ReportScheduleViewModel
            {
                Date = t.Item1,
                Shift = t.Item2,
                EmployeeFIO = s.EmployeeFIO
            })).ToList();

            _saveToPdf.CreateDocReportForEmployee(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Расписание сотрудника",
                EmployeeFIO = scheduleForEmployees.First().EmployeeFIO,
                ScheduleForEmployee = scheduleForEmployees
            });
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
