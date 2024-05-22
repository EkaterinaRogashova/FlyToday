using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface IPlaneModel : IId
    {
        string ModelName { get; }
        int EconomPlacesCount { get; }
        int BusinessPlacesCount { get; }
    }
}
