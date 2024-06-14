using FlyTodayDataModels.Models;
using System.ComponentModel;

namespace FlyTodayContracts.ViewModels
{
    public class PlaneViewModel : IPlaneModel
    {
        [DisplayName("Название модели")]
        public string ModelName { get; set; } = string.Empty;
        [DisplayName("Места эконом")]
        public int EconomPlacesCount { get; set; }
        [DisplayName("Места бизнес")]
        public int BusinessPlacesCount { get; set; }
        [DisplayName("Схема размещения мест")]
        public int PlaneSchemeId { get; set; }

        public int Id { get; set; }
    }
}
