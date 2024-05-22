using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Id { get; set; }
    }
}
