using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class PositionAtWorkViewModel: IPositionAtWork
    {
        public int Id { get; set; }
        [DisplayName("Название должности")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Количество человек на смене")]
        public int? NumberOfEmployeesInShift { get; set; }
        [DisplayName("Тип работы")]
        public string TypeWork { get; set; } = string.Empty;
    }
}
