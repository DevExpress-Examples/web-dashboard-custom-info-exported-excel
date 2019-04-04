<!-- default file list -->
*Files to look at*:

* [WebDashboardForm.aspx](./CS/WebDashboardForm.aspx) (VB: [WebDashboardForm.aspx](./VB/WebDashboardForm.aspx))
* [WebDashboardForm.aspx.cs](./CS/WebDashboardForm.aspx.cs) (VB: [WebDashboardForm.aspx.vb](./VB/WebDashboardForm.aspx.vb))
<!-- default file list end -->
# Web Dashboard - How to add custom information to the exported Excel document


The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboard_CustomizeExportDocumenttopic">ASPxDashboard.CustomizeExportDocument</a> event allows you to obtain the stream of the exported document using the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebCustomizeExportDocumentWebEventArgs_Streamtopic">Stream</a> property and customize the document's layout according to your requirements. For instance, <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument15181">Excel documents</a> may be loaded into the <a href="https://documentation.devexpress.com/#DocumentServer/clsDevExpressSpreadsheetWorkbooktopic">Workbook</a> component for further processing.<br>This example shows how to add a custom header to each sheet for the exported workbook.<br><br>

<br/>


