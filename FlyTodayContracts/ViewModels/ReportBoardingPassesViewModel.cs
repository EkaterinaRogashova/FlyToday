namespace FlyTodayContracts.ViewModels
{
    public class ReportBoardingPassesViewModel
    {
        public int Id { get; set; }
        public string FlightDirection { get; set; } = string.Empty;
        public DateTime DepartureDate { get; set; } 
        public string FIO { get; set; } = string.Empty;
        public string Seria { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
    }
}
