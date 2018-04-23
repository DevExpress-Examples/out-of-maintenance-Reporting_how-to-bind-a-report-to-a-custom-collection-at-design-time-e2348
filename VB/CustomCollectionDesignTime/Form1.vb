Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI
' ...

Namespace CustomCollectionDesignTime
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

			Dim invoices As New List(Of Invoice)(10)

			invoices.Add(New Invoice(0, "Invoice1", 10.0D))
			invoices.Add(New Invoice(1, "Invoice2", 15.0D))
			invoices.Add(New Invoice(2, "Invoice3", 20.0D))

			Dim report As New XtraReport1()
			report.DataSource = invoices

			Dim pt As New ReportPrintTool(report)
			pt.ShowPreviewDialog()
		End Sub
	End Class

	Public Class Invoice
		Private id_Renamed As Integer

		Public Property Id() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				id_Renamed = value
			End Set
		End Property
		Private description_Renamed As String

		Public Property Description() As String
			Get
				Return description_Renamed
			End Get
			Set(ByVal value As String)
				description_Renamed = value
			End Set
		End Property
		Private price_Renamed As Decimal

		Public Property Price() As Decimal
			Get
				Return price_Renamed
			End Get
			Set(ByVal value As Decimal)
				price_Renamed = value
			End Set
		End Property

		Public Sub New(ByVal id As Integer, ByVal description As String, ByVal price As Decimal)
			Me.Id = id
			Me.Description = description
			Me.price_Renamed = price
		End Sub
	End Class

End Namespace
