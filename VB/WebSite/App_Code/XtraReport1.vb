Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports System.Web
Imports System.Collections.Generic

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
	Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
	Private xrLabel1 As XRLabel
	Private xrLabel2 As XRLabel
	Private xrLabel3 As XRLabel
	Private xrPictureBox1 As XRPictureBox
	Private WithEvents xrCheckBox1 As XRCheckBox
	Private dataSet11 As DataSet1
	Private categoriesTableAdapter1 As DataSet1TableAdapters.CategoriesTableAdapter
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
		Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
		Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
		Me.dataSet11 = New DataSet1()
		Me.categoriesTableAdapter1 = New DataSet1TableAdapters.CategoriesTableAdapter()
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCheckBox1, Me.xrPictureBox1, Me.xrLabel3, Me.xrLabel2})
		Me.Detail.Height = 158
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
'		Me.Detail.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.Detail_BeforePrint);
		' 
		' xrCheckBox1
		' 
		Me.xrCheckBox1.Checked = True
		Me.xrCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
		Me.xrCheckBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "Categories.CategoryID", "")})
		Me.xrCheckBox1.Location = New System.Drawing.Point(517, 58)
		Me.xrCheckBox1.Name = "xrCheckBox1"
		Me.xrCheckBox1.Size = New System.Drawing.Size(117, 25)
		Me.xrCheckBox1.Text = "Export this row"
'		Me.xrCheckBox1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrCheckBox1_BeforePrint);
		' 
		' xrPictureBox1
		' 
		Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture", "")})
		Me.xrPictureBox1.Location = New System.Drawing.Point(342, 42)
		Me.xrPictureBox1.Name = "xrPictureBox1"
		Me.xrPictureBox1.Size = New System.Drawing.Size(133, 67)
		' 
		' xrLabel3
		' 
		Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description", "")})
		Me.xrLabel3.Location = New System.Drawing.Point(25, 83)
		Me.xrLabel3.Name = "xrLabel3"
		Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel3.Size = New System.Drawing.Size(233, 25)
		Me.xrLabel3.Text = "xrLabel3"
		' 
		' xrLabel2
		' 
		Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", "")})
		Me.xrLabel2.Location = New System.Drawing.Point(25, 42)
		Me.xrLabel2.Name = "xrLabel2"
		Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel2.Size = New System.Drawing.Size(100, 25)
		Me.xrLabel2.Text = "xrLabel2"
		' 
		' PageHeader
		' 
		Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.PageHeader.Height = 42
		Me.PageHeader.Name = "PageHeader"
		Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrLabel1
		' 
		Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 25F)
		Me.xrLabel1.Location = New System.Drawing.Point(250, 0)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.Size = New System.Drawing.Size(158, 42)
		Me.xrLabel1.StylePriority.UseFont = False
		Me.xrLabel1.Text = "Categories"
		' 
		' PageFooter
		' 
		Me.PageFooter.Height = 30
		Me.PageFooter.Name = "PageFooter"
		Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' dataSet11
		' 
		Me.dataSet11.DataSetName = "DataSet1"
		Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' categoriesTableAdapter1
		' 
		Me.categoriesTableAdapter1.ClearBeforeFill = True
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
		Me.DataAdapter = Me.categoriesTableAdapter1
		Me.DataMember = "Categories"
		Me.DataSource = Me.dataSet11
		Me.Version = "8.2"
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Public Shared IsReportExporting As Boolean

	Public Shared Property SkippedRecords() As List(Of Integer)
		Get
			If HttpContext.Current.Session("skippedRecords") Is Nothing Then
				HttpContext.Current.Session("skippedRecords") = New List(Of Integer)()
			End If

			Return TryCast(HttpContext.Current.Session("skippedRecords"), List(Of Integer))
		End Get
		Set(ByVal value As List(Of Integer))
			HttpContext.Current.Session("skippedRecords") = value
		End Set
	End Property

	Public Shared Sub UpdateRecordsState(ByVal rowId As Integer)
		If XtraReport1.SkippedRecords.Contains(rowId) Then
			XtraReport1.SkippedRecords.Remove(rowId)
		Else
			XtraReport1.SkippedRecords.Add(rowId)
		End If
	End Sub

	Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
		Dim curid As Integer = Convert.ToInt32(GetCurrentColumnValue("CategoryID"))
		Dim shouldNotPrint As Boolean = SkippedRecords.Contains(curid)

		e.Cancel = (XtraReport1.IsReportExporting AndAlso shouldNotPrint)
	End Sub

	Private Sub xrCheckBox1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrCheckBox1.BeforePrint
		Dim checkBox As XRCheckBox = TryCast(sender, XRCheckBox)
		Dim curid As Integer = Convert.ToInt32(GetCurrentColumnValue("CategoryID"))
		Dim shouldNotPrint As Boolean = SkippedRecords.Contains(curid)

		checkBox.NavigateUrl = String.Format("javascript:UpdateReportViewer({0})", curid)
		checkBox.Checked = Not shouldNotPrint
		e.Cancel = XtraReport1.IsReportExporting
	End Sub
End Class
