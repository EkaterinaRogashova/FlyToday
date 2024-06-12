using FlyTodayBusinessLogics.OfficePackage.HelperEnums;
using FlyTodayBusinessLogics.OfficePackage.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.OfficePackage
{
    public abstract class AbstractSaveToPdf
    {
        public void CreateDoc(PdfInfo info)
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
                Text = $"с {info.DateFrom.ToShortDateString()} по {info.DateTo.ToShortDateString()}",
                Style = "Normal",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            //CreateTable(new List<string> { "6cm", "3cm", "6cm" });
            //CreateRow(new PdfRowParameters
            //{
            //    Texts = new List<string> { "Дата создания рецепта", "Доза", "Способ применения" },
            //    Style = "NormalTitle",
            //    ParagraphAlignment = PdfParagraphAlignmentType.Center
            //});
            //foreach (var recipe in info.Recipes)
            //{
            //    CreateRow(new PdfRowParameters
            //    {
            //        Texts = new List<string> {
            //        recipe.Date.ToShortDateString(), recipe.Dose, recipe.ModeofApplication },
            //        Style = "Normal",
            //        ParagraphAlignment = PdfParagraphAlignmentType.Left
            //    });
            //}
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
