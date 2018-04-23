<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.0.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dxcp" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.0.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>
<%@ Register Assembly="DevExpress.XtraReports.v13.1.Web, Version=13.1.0.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
        function UpdateReportViewer(catid) {
            ASPxCallbackPanel1.PerformCallback(catid);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxcp:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" Width="200px" HideContentOnCallback="False"
            OnCallback="ASPxCallbackPanel1_Callback">
            <PanelCollection>
                <dxp:PanelContent runat="server">
                    <dxxr:ReportToolbar ID="ReportToolbar1" runat="server" Width="286px" ReportViewerID="ReportViewer1">
                        <Styles>
                            <LabelStyle>
                                <Margins MarginLeft="3px" MarginRight="3px" />
                            </LabelStyle>
                        </Styles>
                    </dxxr:ReportToolbar>
                    <dxxr:ReportViewer ID="ReportViewer1" runat="server" ReportName="XtraReport1" ClientInstanceName="ReportViewer1"
                        UseIFrame="False">
                    </dxxr:ReportViewer>
                </dxp:PanelContent>
            </PanelCollection>
        </dxcp:ASPxCallbackPanel>
    </div>
    </form>
</body>
</html>
