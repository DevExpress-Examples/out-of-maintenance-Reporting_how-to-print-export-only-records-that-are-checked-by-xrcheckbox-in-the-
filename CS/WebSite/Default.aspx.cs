public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, System.EventArgs e) {
        XtraReport1.IsReportExporting = (Page.Request["__EVENTARGUMENT"] != null && (Page.Request["__EVENTARGUMENT"].IndexOf("saveToDisk") != -1 || Request["__EVENTARGUMENT"].IndexOf("saveToWindow") != -1));
    }

    protected void ASPxCallbackPanel1_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e) {
        XtraReport1.UpdateRecordsState(System.Convert.ToInt32(e.Parameter));
    }
}