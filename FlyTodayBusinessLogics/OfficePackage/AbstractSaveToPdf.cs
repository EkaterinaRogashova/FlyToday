using FlyTodayBusinessLogics.OfficePackage.HelperEnums;
using FlyTodayBusinessLogics.OfficePackage.HelperModels;
using MigraDoc.Rendering;

namespace FlyTodayBusinessLogics.OfficePackage
{
    public abstract class AbstractSaveToPdf
    {
        public void CreateDoc(PdfInfo info)
        {
            CreateAlbumPdf(info);
            CreateParagraph(new PdfParagraph
            {
                Text = info.Title,
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            CreateParagraph(new PdfParagraph
            {
                Text = $"с {info.DateFrom.Date} по {info.DateTo.Date}",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            List<string> columnWidths = new List<string> { "4cm" }; // первая колонка для сотрудников
            List<string> uniqueDates = info.Schedule.Select(x => x.Date.ToString("dd.MM")).Distinct().ToList(); // получаем уникальные даты

            foreach (var date in uniqueDates)
            {
                columnWidths.Add("1.5cm"); // добавляем колонку для каждой уникальной даты
            }

            CreateTable(columnWidths);
            CreateRow(new PdfRowParameters
            {
                Texts = new List<string> { "" }.Concat(uniqueDates).ToList(), // добавляем пустую ячейку и уникальные даты
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });

            foreach (var employeeSchedule in info.Schedule.GroupBy(x => x.EmployeeFIO))
            {
                var rowTexts = new List<string> { employeeSchedule.Key }; // добавляем имя сотрудника

                // заполнение оставшихся ячеек сменами по датам
                foreach (var date in uniqueDates)
                {
                    var shift = employeeSchedule.FirstOrDefault(s => s.Date.ToString("dd.MM") == date)?.Shift ?? "";

                    if (!string.IsNullOrEmpty(shift))
                    {
                        rowTexts.Add(shift.Substring(0, 1));
                    }
                    else
                    {
                        rowTexts.Add("");
                    }
                }

                CreateRow(new PdfRowParameters
                {
                    Texts = rowTexts,
                    Style = "Normal",
                    ParagraphAlignment = PdfParagraphAlignmentType.Center
                });
            }
            SavePdf(info);
        }
        public void CreateDocReportForEmployee(PdfInfo info)
        {
            CreatePdf(info);

            CreateParagraph(new PdfParagraph
            {
                Text = info.Title,
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });

            CreateParagraph(new PdfParagraph
            {
                Text = $"Сотрудник: {info.EmployeeFIO}",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            foreach (var scheduleForEmployee in info.ScheduleForEmployee)
            {
                foreach (var schedule in scheduleForEmployee.Schedule) 
                {
                    CreateParagraph(new PdfParagraph
                    {
                        Text = $"{schedule.Item1.ToShortDateString()} - {schedule.Item2}",
                        Style = "Normal",
                        ParagraphAlignment = PdfParagraphAlignmentType.Left
                    });
                }
            }
            SavePdf(info);
        }
        public void CreateDocReportBoardingPasses(PdfInfo info) {
            CreatePdf(info);
            CreateParagraph(new PdfParagraph
            {
                Text = info.Title,
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            CreateParagraph(new PdfParagraph
            {
                Text = $"на рейс {info.Direction} {info.DepartureDate}",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            CreateTable(new List<string> { "6cm", "3cm", "5cm", "3cm" });
            CreateRow(new PdfRowParameters
            {
                Texts = new List<string> { "ФИО", "Серия документа", "Номер документа", "Место" },
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            foreach (var boardingPass in info.BoardingPasses)
            {
                CreateRow(new PdfRowParameters
                {
                    Texts = new List<string> { boardingPass.FIO,
                    boardingPass.Seria, boardingPass.Number, boardingPass.Place },
                    Style = "Normal",
                    ParagraphAlignment = PdfParagraphAlignmentType.Center
                });
            }
            CreateParagraph(new PdfParagraph
            {
                Text = $"\nИтого: {info.BoardingPasses.Count()}\t",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Right
            });
            SavePdf(info);
        }
        public void CreateDocReportBoardingPass(PdfInfo info)
        {
            CreatePdf(info);

            CreateParagraph(new PdfParagraph
            {
                Text = info.Title,
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });

            CreateParagraph(new PdfParagraph
            {
                Text = $"на рейс {info.Direction} {info.DepartureDate}",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });

            CreateParagraph(new PdfParagraph
            {
                Text = $"Информация о самолете: {info.Plane}",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Left
            });

            CreateTable(new List<string> { "6cm", "3cm", "5cm", "3cm" });

            CreateRowWhiteTable(new PdfRowParameters
            {
                Texts = new List<string> { "ФИО", "Серия документа", "Номер документа", "Место" },
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });

            foreach (var boardingPass in info.BoardingPass)
            {
                CreateRowWhiteTable(new PdfRowParameters
                {
                    Texts = new List<string> { boardingPass.FIO, boardingPass.Seria, boardingPass.Number, boardingPass.Place },
                    Style = "Normal",
                    ParagraphAlignment = PdfParagraphAlignmentType.Center
                });
            }

            SavePdf(info);
        }

        public void CreateDocStatisticTickets(PdfInfo info)
        {
            CreatePdf(info);
            CreateParagraph(new PdfParagraph
            {
                Text = info.Title,
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            CreateParagraph(new PdfParagraph
            {
                Text = $"с {info.DateFrom.Date} по {info.DateTo.Date}",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            CreateParagraph(new PdfParagraph
            {
                Text = "Статистика проданных билетов по полу (мужчины/женщины):",
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Left
            });
            CreateParagraph(new PdfParagraph
            {
                Text = $"Женщины {info.Female}, мужчины {info.Male}",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Left
            });
            CreateParagraph(new PdfParagraph
            {
                Text = "Статистика проданных билетов по наличию дополнительного багажа:",
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Left
            });
            CreateParagraph(new PdfParagraph
            {
                Text = $"C багажом {info.WithBags}, без багажа {info.NotWithBags}",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Left
            });
            CreateParagraph(new PdfParagraph
            {
                Text = "Статистика проданных билетов по возрасту пассажира:",
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Left
            });
            CreateParagraph(new PdfParagraph
            {
                Text = $"Дети до 18 лет - {info.Children}, взрослые от 18 до 65 - {info.People} и пенсионеры от 65 - {info.OlderPeople}",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Left
            });
            SavePdf(info);
        }

        public void CreateDocStatisticDirections(PdfInfo info)
        {
            CreatePdf(info);

            CreateParagraph(new PdfParagraph
            {
                Text = info.Title,
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            CreateTable(new List<string> { "8cm", "4cm", "4cm"});
            CreateRowWhiteTable(new PdfRowParameters
            {
                Texts = new List<string> { "Направление", "Кол-во проданных билетов", "Процент" },
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });

            foreach (var direction in info.Directions)
            {
                CreateRowWhiteTable(new PdfRowParameters
                {
                    Texts = new List<string> { direction.Direction, direction.TicketsCount.ToString(), direction.Percent.ToString() + " %"},
                    Style = "Normal",
                    ParagraphAlignment = PdfParagraphAlignmentType.Center
                });
            }

            SavePdf(info);
        }

        /// <summary>
        /// Создание doc-файла
        /// </summary>
        /// <param name="info"></param>
        protected abstract void CreatePdf(PdfInfo info);
        protected abstract void CreateAlbumPdf(PdfInfo info);
        /// <summary>
        /// Создание параграфа с текстом
        /// </summary>
        /// <param name="title"></param>
        /// <param name="style"></param>
        protected abstract void CreateParagraph(PdfParagraph paragraph);
        /// <summary>
        /// Создание таблицы
        /// </summary>
        /// <param name="title"></param>
        /// <param name="style"></param>
        protected abstract void CreateTable(List<string> columns);
        /// <summary>
        /// Создание и заполнение строки
        /// </summary>
        /// <param name="rowParameters"></param>
        protected abstract void CreateRow(PdfRowParameters rowParameters);
        protected abstract void CreateRowWhiteTable(PdfRowParameters rowParameters);
        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="info"></param>
        protected abstract void SavePdf(PdfInfo info);
    }
}
