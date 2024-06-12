namespace FlyTodayContracts.BindingModels
{
    public class ReportBindingModel
    {
        public string FileName { get; set; } = string.Empty;
        public int? FlightId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
