using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class SaleBindingModel : ISaleModel
    {
        public string Category { get; set; } = string.Empty;

        public double Percent { get; set; }
        public int? AgeFrom { get; set; }
        public int? AgeTo { get; set; }

        public int Id { get; set; }
    }
}
