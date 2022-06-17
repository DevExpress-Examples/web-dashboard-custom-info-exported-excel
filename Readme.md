<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580427/21.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T504794)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [WebDashboardForm.aspx](./CS/WebDashboardForm.aspx) (VB: [WebDashboardForm.aspx](./VB/WebDashboardForm.aspx))
* [WebDashboardForm.aspx.cs](./CS/WebDashboardForm.aspx.cs) (VB: [WebDashboardForm.aspx.vb](./VB/WebDashboardForm.aspx.vb))
<!-- default file list end -->

# Dashboard for Web Forms - How to add custom information to the exported Excel document

This example shows how to add a custom header to each sheet for the exported workbook.

The [ASPxDashboard.CustomizeExportDocument](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomizeExportDocument) event allows you to obtain the stream of the exported document using the [Stream](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.CustomizeExportDocumentWebEventArgs.Stream) property and customize the document's layout according to your requirements. For instance, [Excel documents](https://docs.devexpress.com/Dashboard/15181/common-features/printing-and-exporting) can be loaded into the [Workbook](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook) component for further processing.

## Documentation

- [ASPxDashboard.CustomizeExportDocument](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomizeExportDocument)
- [Printing and Exporting](https://docs.devexpress.com/Dashboard/15181/common-features/printing-and-exporting)

## More Examples

- [Dashboard for Web Forms - How to add custom information to the exported dashboard](https://github.com/DevExpress-Examples/web-dashboard-how-to-add-custom-information-to-the-exported-dashboard-t466585)
- [Dashboard for WinForms - How to add custom information to the exported dashboard](https://github.com/DevExpress-Examples/winforms-dashboard-how-to-add-custom-information-to-the-exported-dashboard-t466558)
