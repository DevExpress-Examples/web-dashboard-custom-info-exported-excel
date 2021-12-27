<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebDashboardForm.aspx.cs" Inherits="WebDashboard_CustomizeExport.WebDashboardForm" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title></title>
</head>
<body >
    <form id="form1" runat="server">
        <div style="position:absolute; left:0; right:0; top:0; bottom:0;">
            <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" 
                AllowExportDashboardItems="True" Height="100%" Width="100%" WorkingMode="ViewerOnly"
                OnCustomizeExportDocument="ASPxWebDashboard1_CustomizeExportDocument" 
                OnConfigureDataConnection="ASPxDashboard1_ConfigureDataConnection">
            </dx:ASPxDashboard>
        </div>
    </form>
</body>
</html>
