using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Models
{
    public class Plane : IPlaneModel
    {
        public int Id { get; private set; }

        public string ModelName => throw new NotImplementedException();

        public int EconomPlacesCount => throw new NotImplementedException();

        public int BusinessPlacesCount => throw new NotImplementedException();
    }
}
