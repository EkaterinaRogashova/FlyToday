using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.SearchModels
{
    public class PlaceSearchModel
    {
        public int? Id {  get; set; }
        public string? Place {  get; set; }
        public bool? IsFree {  get; set; }
    }
}
