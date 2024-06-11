using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayBusinessLogics.MailWorker;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.StoragesContracts;
using FlyTodayDatabaseImplements.Implements;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System.Configuration;
using Microsoft.Extensions.Configuration.Json;
using FlyTodayContracts.BindingModels;

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
            try
            {
                var mailSender =
                _serviceProvider.GetService<AbstractMailWorker>();
                mailSender?.MailConfig(new MailConfigBindingModel
                {
                    MailLogin = System.Configuration.ConfigurationManager.AppSettings["MailLogin"] ?? string.Empty,
                    MailPassword = System.Configuration.ConfigurationManager.AppSettings["MailPassword"] ?? string.Empty,
                    SmtpClientHost = System.Configuration.ConfigurationManager.AppSettings["SmtpClientHost"] ?? string.Empty,
                    SmtpClientPort = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SmtpClientPort"]),
                    PopHost = System.Configuration.ConfigurationManager.AppSettings["PopHost"] ?? string.Empty,
                    PopPort = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["PopPort"])
                });
            }
            catch (Exception ex)
            {
                var logger = _serviceProvider.GetService<ILogger>();
                logger?.LogError(ex, "Ошибка работы с почтой");
            }

            Application.Run(_serviceProvider.GetRequiredService<FormMainMenu>());           
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging(option =>
            {
                option.SetMinimumLevel(LogLevel.Information);
                option.AddNLog("nlog.config");
            });
            services.AddTransient<IUserLogic, UserLogic>();
            services.AddTransient<IUserStorage, UserStorage>();
            services.AddSingleton<AbstractMailWorker, MailKitWorker>();

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
            services.AddTransient<ConfirmationDialog>();
            services.AddTransient<ConfirmationDialogPassword>();
            services.AddTransient<FormProfile>();
            services.AddTransient<FormSchedule>();
            services.AddTransient<FormEditProfile>();
            services.AddTransient<FormScheduleForEmployee>();
            services.AddTransient<FormSearchFlights>();
            services.AddTransient<FormViewFlight>();
            services.AddTransient<FormRent>();
            services.AddTransient<FormTickets>();
            services.AddTransient<FormMyRents>();
            services.AddTransient<FormRentTickets>();
            services.AddTransient<FormCreatePlaces>();
        }
    }
}