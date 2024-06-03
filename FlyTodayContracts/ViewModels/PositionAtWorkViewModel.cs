using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class PositionAtWorkViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название должности")]
        public string Name { get; set; } = string.Empty;
    }
}
