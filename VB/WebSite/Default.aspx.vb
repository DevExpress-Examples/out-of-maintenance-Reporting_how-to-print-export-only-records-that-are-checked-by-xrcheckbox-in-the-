Imports Microsoft.VisualBasic
Imports System
Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
		XtraReport1.IsReportExporting = (Page.Request("__EVENTARGUMENT") IsNot Nothing AndAlso (Page.Request("__EVENTARGUMENT").IndexOf("saveToDisk") <> -1 OrElse Request("__EVENTARGUMENT").IndexOf("saveToWindow") <> -1))
	End Sub

	Protected Sub ASPxCallbackPanel1_Callback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
		XtraReport1.UpdateRecordsState(System.Convert.ToInt32(e.Parameter))
	End Sub
End Class