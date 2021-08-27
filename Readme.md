<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602432/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1739)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* **[Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))**
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to print/export only records that are checked by XRCheckBox in the detail band
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1739/)**
<!-- run online end -->


<p>This example demonstrates how to conditionally include rows into a printed/exported web report. To select rows, the XRCheckBox is used. Once the user clicks on the corresponding XRCheckBox, the client script is executed (it is defined via the XRCheckBox.NavigateUrl property within the XRCheckBox.BeforePrint event handler), and a callback is sent to the server to update the internal storage (in the Session variable) of the skipped rows and regenerate a report in the ReportViewer accordingly. </p><p>Note that by inspecting the Page.Request["__EVENTARGUMENT"] parameter, you can determine whether the print/export command is initiated via the ReportToolbar button. If so, you should handle the XRControl.BeforePrint event for the DetailBand and XRCheckBox, and set the e.Cancel parameter to true based on your logic to skip unnecessary report content elements.</p>

<br/>


