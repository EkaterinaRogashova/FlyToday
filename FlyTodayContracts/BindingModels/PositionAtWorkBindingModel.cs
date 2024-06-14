using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class PositionAtWorkBindingModel: IPositionAtWork
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? NumberOfEmployeesInShift { get; set; }
        public string TypeWork { get; set; } = string.Empty;
    }
}
