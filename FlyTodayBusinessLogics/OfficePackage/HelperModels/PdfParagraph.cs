﻿using FlyTodayBusinessLogics.OfficePackage.HelperEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.OfficePackage.HelperModels
{
    public class PdfParagraph
    {
        public string Text { get; set; } = string.Empty;
        public string Style { get; set; } = string.Empty;
        public PdfParagraphAlignmentType ParagraphAlignment { get; set; }
    }
}
