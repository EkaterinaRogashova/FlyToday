﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class ReportBoardingPassBindingModel
    {
        public string FileName { get; set; } = string.Empty;
        public int BoardingPassId { get; set; }
    }
}
