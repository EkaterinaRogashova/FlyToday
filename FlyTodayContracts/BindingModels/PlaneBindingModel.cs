using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class PlaneBindingModel : IPlaneModel
    {
        public string ModelName { get; set; } = string.Empty;

        public int EconomPlacesCount { get; set; }

        public int BusinessPlacesCount { get; set; }

        public int Id { get; set; }

        public int PlaneSchemeId { get; set; }
    }
}
