<!-- default file list -->
*Files to look at*:

* [WebDashboardForm.aspx](./CS/WebDashboardForm.aspx) (VB: [WebDashboardForm.aspx](./VB/WebDashboardForm.aspx))
* [WebDashboardForm.aspx.cs](./CS/WebDashboardForm.aspx.cs) (VB: [WebDashboardForm.aspx.vb](./VB/WebDashboardForm.aspx.vb))
<!-- default file list end -->
# ASP.NET Web Forms Dashboard - How to add custom information to the exported Excel document

This example shows how to add a custom header to each sheet for the exported workbook.

The [ASPxDashboard.CustomizeExportDocument](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomizeExportDocument) event allows you to obtain the stream of the exported document using the [Stream](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.CustomizeExportDocumentWebEventArgs.Stream) property and customize the document's layout according to your requirements. For instance, [Excel documents](https://docs.devexpress.com/Dashboard/15181/common-features/printing-and-exporting) can be loaded into the [Workbook](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook) component for further processing.

## Documentation

- [ASPxDashboard.CustomizeExportDocument](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomizeExportDocument)
- [Printing and Exporting](https://docs.devexpress.com/Dashboard/15181/common-features/printing-and-exporting)
