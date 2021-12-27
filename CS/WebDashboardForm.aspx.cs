using System;
using System.IO;
using System.Drawing;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.Spreadsheet;

namespace WebDashboard_CustomizeExport {
    public partial class WebDashboardForm : System.Web.UI.Page {
        DashboardFileStorage fileStorage = new DashboardFileStorage("App_Data/Dashboards");

        protected void Page_Load(object sender, EventArgs e) {
            ASPxDashboard1.SetDashboardStorage(fileStorage);
        }

        protected void ASPxWebDashboard1_CustomizeExportDocument(object sender, CustomizeExportDocumentWebEventArgs e) {
            if (e.ExportAction == DashboardExportAction.ExportToExcel) {
                MemoryStream ms = new MemoryStream();
                e.Stream.Position = 0;

                Workbook workbook = new Workbook();
                if (e.ExcelExportOptions.Format == ExcelFormat.Xlsx)
                    workbook.LoadDocument(e.Stream, DocumentFormat.Xlsx);
                else if (e.ExcelExportOptions.Format == ExcelFormat.Xls)
                    workbook.LoadDocument(e.Stream, DocumentFormat.Xls);
                else if (e.ExcelExportOptions.Format == ExcelFormat.Csv)
                    workbook.LoadDocument(e.Stream, DocumentFormat.Csv);
                foreach (Worksheet sheet in workbook.Worksheets) {
                    // Export to CSV without images, cell merging and coloring. 
                    if (e.ExcelExportOptions.Format == ExcelFormat.Csv) {
                        sheet.Rows.Insert(0);
                        Cell textCell = sheet.Cells[0, 0];
                        textCell.Value = "Custom Document Header";
                    }
                    // Export to the Excel workbook with images, cell merging and coloring.
                    else {
                        sheet.Rows.Insert(0, 3);
                        sheet.Pictures.AddPicture(Properties.Resources.dxLogo, sheet.Range.FromLTRB(0, 0, 5, 2), true);
                        Cell textCell = sheet.Cells[0, 5];
                        textCell.Value = "Custom Document Header";

                        sheet.MergeCells(sheet.Range.FromLTRB(5, 0, 8, 0));
                        Formatting formatting = textCell.BeginUpdateFormatting();
                        formatting.Fill.BackgroundColor = Color.LightBlue;
                        textCell.EndUpdateFormatting(formatting);
                        textCell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    }
                }
                if (e.ExcelExportOptions.Format == ExcelFormat.Xlsx)
                    workbook.SaveDocument(ms, DocumentFormat.Xlsx);
                else if (e.ExcelExportOptions.Format == ExcelFormat.Xls)
                    workbook.SaveDocument(ms, DocumentFormat.Xls);
                else if (e.ExcelExportOptions.Format == ExcelFormat.Csv)
                    workbook.SaveDocument(ms, DocumentFormat.Csv);
                e.Stream = ms;
            }
        }

        protected void ASPxDashboard1_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
            if (e.ConnectionName == "sqlConn") {
                Access97ConnectionParameters connectionParams = new Access97ConnectionParameters();
                connectionParams.FileName = Server.MapPath(@"~/App_Data/nwind.mdb");
                e.ConnectionParameters = connectionParams;
            }
        }
    }
}