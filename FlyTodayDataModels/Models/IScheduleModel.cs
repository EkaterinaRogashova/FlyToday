﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface IScheduleModel : IId
    {
        int EmployeeId { get; }
        DateTime Date { get; }
        string Shift { get; }
        bool Presence { get; }

    }
}
