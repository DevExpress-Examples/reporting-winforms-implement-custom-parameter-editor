Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApp1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim report = New XtraReport1()
			report.ShowPreview()
		End Sub
	End Class
End Namespace
