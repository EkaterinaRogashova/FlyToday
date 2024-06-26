﻿using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BusinessLogicContracts
{
    public interface IPlaneLogic
    {
        List<PlaneViewModel>? ReadList(PlaneSearchModel? model);
        PlaneViewModel? ReadElement(PlaneSearchModel model);
        bool Create(PlaneBindingModel model);
        bool Update(PlaneBindingModel model);
        bool Delete(PlaneBindingModel model);
    }
}
