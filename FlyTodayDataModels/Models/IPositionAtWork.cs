using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface IPositionAtWork: IId
    {
        string Name { get; }
        int? NumberOfEmployeesInShift { get; }
        string TypeWork { get; }
    }
}
