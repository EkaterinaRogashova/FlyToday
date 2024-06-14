using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface ISaleModel : IId
    {
        string Category { get; }
        double Percent {  get; }
        int? AgeFrom { get; }
        int? AgeTo { get; }
    }
}
