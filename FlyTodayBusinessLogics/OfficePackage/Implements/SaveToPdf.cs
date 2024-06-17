using FlyTodayBusinessLogics.OfficePackage.HelperEnums;
using FlyTodayBusinessLogics.OfficePackage.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using DocumentFormat.OpenXml.Office2010.PowerPoint;

namespace FlyTodayBusinessLogics.OfficePackage.Implements
{
    public class SaveToPdf : AbstractSaveToPdf
    {
        private Document? _document;
        private MigraDoc.DocumentObjectModel.Section? _section;
        private Table? _table;
        private static ParagraphAlignment
       GetParagraphAlignment(PdfParagraphAlignmentType type)
        {
            return type switch
            {
                PdfParagraphAlignmentType.Center => ParagraphAlignment.Center,
                PdfParagraphAlignmentType.Left => ParagraphAlignment.Left,
                PdfParagraphAlignmentType.Right => ParagraphAlignment.Right,
                _ => ParagraphAlignment.Justify,
            };
        }
        /// <summary>
        /// Создание стилей для документа
        /// </summary>
        /// <param name="document"></param>
        private static void DefineStyles(Document document)
        {
            var style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 14;
            style = document.Styles.AddStyle("NormalTitle", "Normal");
            style.Font.Bold = true;
        }
        private static void DefineStylesAlbum(Document document)
        {
            var style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 10;
            style = document.Styles.AddStyle("NormalTitle", "Normal");
            style.Font.Bold = true;
        }
        protected override void CreatePdf(PdfInfo info)
        {
            _document = new Document();
            DefineStyles(_document);
            _section = _document.AddSection();
        }
        protected override void CreateAlbumPdf(PdfInfo info)
        {
            _document = new Document();
            _document.DefaultPageSetup.Orientation = Orientation.Landscape;
            DefineStylesAlbum(_document);
            _section = _document.AddSection();
        }
        protected override void CreateParagraph(PdfParagraph pdfParagraph)
        {
            if (_section == null)
            {
                return;
            }
            var paragraph = _section.AddParagraph(pdfParagraph.Text);
            paragraph.Format.SpaceAfter = "1cm";
            paragraph.Format.Alignment =
           GetParagraphAlignment(pdfParagraph.ParagraphAlignment);
            paragraph.Style = pdfParagraph.Style;
        }
        protected override void CreateTable(List<string> columns)
        {
            if (_document == null)
            {
                return;
            }
            _table = _document.LastSection.AddTable();
            foreach (var elem in columns)
            {
                _table.AddColumn(elem);
            }
        }
        protected override void CreateRow(PdfRowParameters rowParameters)
        {
            if (_table == null)
            {
                return;
            }
            var row = _table.AddRow();
            for (int i = 0; i < rowParameters.Texts.Count; ++i)
            {
                row.Cells[i].AddParagraph(rowParameters.Texts[i]);
                if (!string.IsNullOrEmpty(rowParameters.Style))
                {
                    row.Cells[i].Style = rowParameters.Style;
                }
                Unit borderWidth = 0.5;
                row.Cells[i].Borders.Left.Width = borderWidth;
                row.Cells[i].Borders.Right.Width = borderWidth;
                row.Cells[i].Borders.Top.Width = borderWidth;
                row.Cells[i].Borders.Bottom.Width = borderWidth;
                row.Cells[i].Format.Alignment =
               GetParagraphAlignment(rowParameters.ParagraphAlignment);
                row.Cells[i].VerticalAlignment = VerticalAlignment.Center;
            }
        }

        protected override void CreateRowWhiteTable(PdfRowParameters rowParameters)
        {
            if (_table == null)
            {
                return;
            }
            var row = _table.AddRow();
            for (int i = 0; i < rowParameters.Texts.Count; ++i)
            {
                row.Cells[i].AddParagraph(rowParameters.Texts[i]);
                if (!string.IsNullOrEmpty(rowParameters.Style))
                {
                    row.Cells[i].Style = rowParameters.Style;
                }
                // Set border color to white
                row.Cells[i].Borders.Left.Color = Color.FromArgb(0, 255, 255, 255);
                row.Cells[i].Borders.Right.Color = Color.FromArgb(0, 255, 255, 255); ;
                row.Cells[i].Borders.Top.Color = Color.FromArgb(0, 255, 255, 255); ;
                row.Cells[i].Borders.Bottom.Color = Color.FromArgb(0, 255, 255, 255); ;

                // You can keep the width if you want a visible border 
                // row.Cells[i].Borders.Left.Width = borderWidth;
                // row.Cells[i].Borders.Right.Width = borderWidth;
                // row.Cells[i].Borders.Top.Width = borderWidth;
                // row.Cells[i].Borders.Bottom.Width = borderWidth;

                row.Cells[i].Format.Alignment =
               GetParagraphAlignment(rowParameters.ParagraphAlignment);
                row.Cells[i].VerticalAlignment = VerticalAlignment.Center;
            }
        }

        protected override void SavePdf(PdfInfo info)
        {
            var renderer = new PdfDocumentRenderer(true)
            {
                Document = _document
            };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(info.FileName);
        }
    }
}

