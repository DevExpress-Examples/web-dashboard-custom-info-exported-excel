Imports System.IO
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.Spreadsheet

Namespace WebDashboard_CustomizeExport
    Partial Public Class WebDashboardForm
        Inherits System.Web.UI.Page

        Private fileStorage As New DashboardFileStorage("App_Data/Dashboards")
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxDashboard1.SetDashboardStorage(fileStorage)
        End Sub

        Protected Sub ASPxWebDashboard1_CustomizeExportDocument(ByVal sender As Object, ByVal e As CustomizeExportDocumentWebEventArgs)
            If e.ExportAction = DashboardExportAction.ExportToExcel Then
                Dim ms As New MemoryStream()
                e.Stream.Position = 0

                Dim workbook As New Workbook()
                If e.ExcelExportOptions.Format = ExcelFormat.Xlsx Then
                    workbook.LoadDocument(e.Stream, DocumentFormat.Xlsx)
                ElseIf e.ExcelExportOptions.Format = ExcelFormat.Xls Then
                    workbook.LoadDocument(e.Stream, DocumentFormat.Xls)
                ElseIf e.ExcelExportOptions.Format = ExcelFormat.Csv Then
                    workbook.LoadDocument(e.Stream, DocumentFormat.Csv)
                End If
                For Each sheet As Worksheet In workbook.Worksheets
                    ' Export to CSV without images, cell merging and coloring. 
                    If e.ExcelExportOptions.Format = ExcelFormat.Csv Then
                        sheet.Rows.Insert(0)
                        Dim textCell As Cell = sheet.Cells(0, 0)
                        textCell.Value = "Custom Document Header"
                    ' Export to the Excel workbook with images, cell merging and coloring.
                    Else
                        sheet.Rows.Insert(0, 3)
                        sheet.Pictures.AddPicture(My.Resources.dxLogo, sheet.Range.FromLTRB(0, 0, 5, 2), True)
                        Dim textCell As Cell = sheet.Cells(0, 5)
                        textCell.Value = "Custom Document Header"

                        sheet.MergeCells(sheet.Range.FromLTRB(5, 0, 8, 0))
                        Dim formatting As Formatting = textCell.BeginUpdateFormatting()
                        formatting.Fill.BackgroundColor = Color.LightBlue
                        textCell.EndUpdateFormatting(formatting)
                        textCell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
                    End If

                Next sheet
                If e.ExcelExportOptions.Format = ExcelFormat.Xlsx Then
                    workbook.SaveDocument(ms, DocumentFormat.Xlsx)
                ElseIf e.ExcelExportOptions.Format = ExcelFormat.Xls Then
                    workbook.SaveDocument(ms, DocumentFormat.Xls)
                ElseIf e.ExcelExportOptions.Format = ExcelFormat.Csv Then
                    workbook.SaveDocument(ms, DocumentFormat.Csv)
                End If
                e.Stream = ms
            End If
        End Sub

        Protected Sub ASPxDashboard1_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
            If e.ConnectionName = "sqlConn" Then
                Dim connectionParams As New Access97ConnectionParameters()
                connectionParams.FileName = Server.MapPath("~/App_Data/nwind.mdb")
                e.ConnectionParameters = connectionParams
            End If
        End Sub
    End Class
End Namespace
