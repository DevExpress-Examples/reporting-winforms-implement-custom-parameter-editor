#Region "usings"
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.Parameters
#End Region

Namespace WindowsFormsApp1
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

#Region "implementCustomParameterEditor"
		Private Sub XtraReport1_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As ParametersRequestEventArgs) Handles MyBase.ParametersRequestBeforeShow
			' Create and set up a radio group editor.
			Dim radioGroup = CreateRadioGroup()

			' Find a required parameter by name and assign
			' a custom editor to the Editor property.
			For Each info In e.ParametersInformation
				If info.Parameter.Name = "shape" Then
					info.Editor = radioGroup
					Exit For
				End If
			Next info
		End Sub

		Private Function CreateRadioGroup() As RadioGroup
			Dim radioGroup = New RadioGroup()

			Dim radioGroupItemTitles() As String = {"Circle", "Rectangle", "Ellipse", "Triangle", "Square"}

			For Each item In radioGroupItemTitles
				radioGroup.Properties.Items.Add(New RadioGroupItem(item, item))
			Next item

			radioGroup.Properties.ItemVertAlignment = RadioItemVertAlignment.Top
			radioGroup.MinimumSize = New System.Drawing.Size(0, 100)

			Return radioGroup
		End Function
#End Region
	End Class
End Namespace
