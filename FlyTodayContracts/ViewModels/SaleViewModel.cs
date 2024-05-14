using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class SaleViewModel : ISaleModel
    {
        [DisplayName("Категория")]
        public string Category { get; set; } = string.Empty;
        [DisplayName("Размер скидки")]
        public double Percent { get; set; }

        public int Id { get; set; }
    }
}
