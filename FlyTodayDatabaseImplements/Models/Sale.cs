using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Models
{
    public class Sale : ISaleModel
    {
        public int Id {  get; private set; }
        [Required]
        public string Category { get; private set; } = string.Empty;
        [Required]
        public double Percent { get; private set; }
        public int? AgeTo {  get; private set; }
        public int? AgeFrom { get; private set; }

        public static Sale? Create(SaleBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Sale()
            {
                Id = model.Id,
                Category = model.Category,
                Percent = model.Percent,
                AgeFrom = model.AgeFrom,
                AgeTo = model.AgeTo
            };
        }
        public static Sale Create(SaleViewModel model)
        {
            return new Sale
            {
                Id = model.Id,
                Category = model.Category,
                Percent = model.Percent,
                AgeFrom = model.AgeFrom,
                AgeTo = model.AgeTo
            };
        }
        public void Update(SaleBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            Category = model.Category;
            Percent = model.Percent;
            AgeFrom = model.AgeFrom;
            AgeTo = model.AgeTo;
        }
        public SaleViewModel GetViewModel => new()
        {
            Id = Id,
            Category = Category,
            Percent = Percent,
            AgeFrom = AgeFrom,
            AgeTo = AgeTo
        };
    }
}
