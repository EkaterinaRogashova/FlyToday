using FlyTodayBusinessLogics.OfficePackage.HelperEnums;
using FlyTodayBusinessLogics.OfficePackage.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.OfficePackage
{
    public abstract class AbstractSaveToExcel
    {
        /// <summary>
        /// Создание отчета
        /// </summary>
        /// <param name="info"></param>
        public void CreateReport(ExcelInfo info)
        {
            CreateExcel(info);

            InsertCellInWorksheet(new ExcelCellParameters
            {
                ColumnName = "A",
                RowIndex = 1,
                Text = info.Title,
                StyleInfo = ExcelStyleInfoType.Title
            });

            uint rowIndex = 2;

            foreach (var employeeSchedule in info.Schedule.GroupBy(x => x.EmployeeFIO))
            {
                InsertCellInWorksheet(new ExcelCellParameters
                {
                    ColumnName = "A",
                    RowIndex = rowIndex,
                    Text = employeeSchedule.Key,
                    StyleInfo = ExcelStyleInfoType.Text
                });

                int columnIndex = 2;
                foreach (var date in info.Schedule.Select(s => s.Date.ToString("dd.MM")).Distinct())
                {
                    var shift = employeeSchedule.FirstOrDefault(s => s.Date.ToString("dd.MM") == date)?.Shift ?? "";

                    InsertCellInWorksheet(new ExcelCellParameters
                    {
                        ColumnName = ExcelHelper.GetColumnName(columnIndex),
                        RowIndex = rowIndex,
                        Text = shift,
                        StyleInfo = ExcelStyleInfoType.TextWithBroder
                    });

                    columnIndex++;
                }

                rowIndex++;
            }

            SaveExcel(info);
        }
        /// <summary>
        /// Создание excel-файла
        /// </summary>
        /// <param name="info"></param>
        protected abstract void CreateExcel(ExcelInfo info);
        /// <summary>
        /// Добавляем новую ячейку в лист
        /// </summary>
        /// <param name="cellParameters"></param>
        protected abstract void InsertCellInWorksheet(ExcelCellParameters
        excelParams);
        /// <summary>
        /// Объединение ячеек
        /// </summary>
        /// <param name="mergeParameters"></param>
        protected abstract void MergeCells(ExcelMergeParameters excelParams);
        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="info"></param>
        protected abstract void SaveExcel(ExcelInfo info);

    }
    public static class ExcelHelper
    {
        public static string GetColumnName(int index)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            index--; // Adjust index to be 0-based, as A1 style columns are 1-based
            string columnName = "";

            while (index >= 0)
            {
                columnName = letters[index % 26] + columnName;
                index = (index / 26) - 1;
            }

            return columnName;
        }
    }
}
