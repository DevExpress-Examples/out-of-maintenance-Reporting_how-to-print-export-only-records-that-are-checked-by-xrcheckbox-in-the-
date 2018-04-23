<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.0.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dxcp" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.0.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.0.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <script type="text/javascript">
        function UpdateReportViewer(catid) {
            ASPxCallbackPanel1.PerformCallback(catid);
        }
    </script>
    <title>Untitled Page</title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
        <dxcp:ASPxCallbackPanel ID="ASPxCallbackPanel1" ClientInstanceName="ASPxCallbackPanel1"
            runat="server" Width="100%" HideContentOnCallback="False" OnCallback="ASPxCallbackPanel1_Callback">
            <PanelCollection>
                <dxp:PanelContent runat="server">
                    <dx:ASPxDocumentViewer ID="DocumentViewer1" runat="server" ReportTypeName="XtraReport1"
                        ClientInstanceName="DocumentViewer1">
                        <SettingsReportViewer UseIFrame="False" />
                    </dx:ASPxDocumentViewer>
                </dxp:PanelContent>
            </PanelCollection>
        </dxcp:ASPxCallbackPanel>
        </div>
    </form>
</body>
</html>
