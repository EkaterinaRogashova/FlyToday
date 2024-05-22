using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface IDirectionModel : IId
    {
        string CountryFrom { get; }
        string CountryTo { get; }
        string CityFrom { get; }
        string CityTo { get; }
    }
}
