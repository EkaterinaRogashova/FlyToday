using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.StoragesContracts;
using FlyTodayDatabaseImplements.Implements;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace FlyTodayViews
{
    internal static class Program
    {
        private static ServiceProvider? _serviceProvider;
        public static ServiceProvider? ServiceProvider => _serviceProvider;
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
            Application.Run(_serviceProvider.GetRequiredService<FormMainMenu>());
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging(option =>
            {
                option.SetMinimumLevel(LogLevel.Information);
                option.AddNLog("nlog.config");
            });
            services.AddTransient<IUserStorage, UserStorage>();
            services.AddTransient<IBoardingPassStorage, BoardingPassStorage>();
            services.AddTransient<IDirectionStorage, DirectionStorage>();
            services.AddTransient<IEmployeeStorage, EmployeeStorage>();
            services.AddTransient<IFlightStorage, FlightStorage>();
            services.AddTransient<IPlaceStorage, PlaceStorage>();
            services.AddTransient<IPlaneStorage, PlaneStorage>();
            services.AddTransient<IPositionAtWorkStorage, PositionAtWorkStorage>();
            services.AddTransient<IRentStorage, RentStorage>();
            services.AddTransient<ISaleStorage, SaleStorage>();
            services.AddTransient<IScheduleStorage, ScheduleStorage>();
            services.AddTransient<ITicketStorage, TicketStorage>();

            services.AddTransient<IUserLogic, UserLogic>();
            services.AddTransient<IBoardingPassLogic, BoardingPassLogic>();
            services.AddTransient<IDirectionLogic, DirectionLogic>();
            services.AddTransient<IEmployeeLogic, EmployeeLogic>();
            services.AddTransient<IFlightLogic, FlightLogic>();
            services.AddTransient<IPlaceLogic, PlaceLogic>();
            services.AddTransient<IPlaneLogic, PlaneLogic>();
            services.AddTransient<IPositionAtWorkLogic, PositionAtWorkLogic>();
            services.AddTransient<IRentLogic, RentLogic>();
            services.AddTransient<ISaleLogic, SaleLogic>();
            services.AddTransient<IScheduleLogic, ScheduleLogic>();
            services.AddTransient<ITicketLogic, TicketLogic>();

            services.AddTransient<FormMainMenu>();
            services.AddTransient<FormDirection>();
            services.AddTransient<FormDirections>();
            services.AddTransient<FormEmployee>();
            services.AddTransient<FormEmployees>();
            services.AddTransient<FormEnter>();
            services.AddTransient<FormPositionAtWork>();
            services.AddTransient<FormPositionAtWorks>();
            services.AddTransient<FormRegistration>();
            services.AddTransient<FormSale>();
            services.AddTransient<FormSales>();
            services.AddTransient<FormPlane>();
            services.AddTransient<FormPlanes>();
            services.AddTransient<FormFlight>();
            services.AddTransient<FormFlights>();
        }
    }
}