using FlyTodayDataModels.Models;
using System.ComponentModel;

namespace FlyTodayContracts.ViewModels
{
    public class PlaneSchemeViewModel : IPlaneSchemeModel
    {
        [DisplayName("Название схемы")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Количество мест бизнес-класса")]
        public int BusinessPlacesCount { get; set; }
        [DisplayName("Количество мест эконом-класса")]
        public int EconomPlacesCount { get; set; }
        [DisplayName("Количество мест в первом ряду эконом-класса")]
        public int PlacesInFirstLineEconom { get; set; }
        [DisplayName("Количество мест в среднем ряду эконом-класса")]
        public int PlacesInMiddleLineEconom { get; set; }
        [DisplayName("Количество мест в последнем ряду эконом-класса")]
        public int PlacesInLastLineEconom { get; set; }
        [DisplayName("Количество мест в первом ряду бизнес-класса")]
        public int PlacesInFirstLineBusiness { get; set; }
        [DisplayName("Количество мест в последнем ряду бизнес-класса")]
        public int PlacesInLastLineBusiness { get; set; }
        public int Id { get; set; }
    }
}
