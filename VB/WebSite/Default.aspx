<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dxcp" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
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