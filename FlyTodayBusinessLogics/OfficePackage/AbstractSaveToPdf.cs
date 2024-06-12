using FlyTodayBusinessLogics.OfficePackage.HelperEnums;
using FlyTodayBusinessLogics.OfficePackage.HelperModels;

namespace FlyTodayBusinessLogics.OfficePackage
{
    public abstract class AbstractSaveToPdf
    {
        public void CreateDocReportBoardingPasses(PdfInfo info)
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
            CreateTable(new List<string> { "6cm", "3cm", "5cm", "3cm" });
            CreateRow(new PdfRowParameters
            {
                Texts = new List<string> { "ФИО", "Серия документа", "Номер документа", "Место"},
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
                    ParagraphAlignment = PdfParagraphAlignmentType.Left
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
        /// <summary>
        /// Создание doc-файла
        /// </summary>
        /// <param name="info"></param>
        protected abstract void CreatePdf(PdfInfo info);
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
        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="info"></param>
        protected abstract void SavePdf(PdfInfo info);
    }
}
