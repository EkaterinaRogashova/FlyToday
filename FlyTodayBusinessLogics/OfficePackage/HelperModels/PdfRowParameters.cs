﻿using FlyTodayBusinessLogics.OfficePackage.HelperEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.OfficePackage.HelperModels
{
    public class PdfRowParameters
    {
        public List<string> Texts { get; set; } = new();
        public string Style { get; set; } = string.Empty;
        public PdfParagraphAlignmentType ParagraphAlignment { get; set; }
        public string? IntersectionValue { get; set; } // новое поле
    }
}
