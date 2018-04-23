Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxFormLayout

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim item As LayoutItemBase = TryCast(layout.FindItemByPath(pathTextBox.Text), LayoutItemBase)
		UpdateItem(item)
	End Sub
	Private Sub UpdateItem(ByVal item As LayoutItemBase)
		If TypeOf item Is LayoutItem Then
			SetValue(TryCast(item, LayoutItem))
		Else
			If TypeOf item Is LayoutGroupBase Then
				TryCast(item, LayoutGroupBase).ForEach(AddressOf IterateNestedControls)
			Else
				pathTextBox.IsValid = False
				pathTextBox.ValidationSettings.ErrorText = "There is no available group for this path"
			End If
		End If
	End Sub
	Private Sub IterateNestedControls(ByVal item As LayoutItemBase)
		For Each c As LayoutItemBase In item.Collection
			If TypeOf c Is LayoutGroup Then
				TryCast(c, LayoutGroup).ForEach(AddressOf IterateNestedControls)
			End If
			If TypeOf c Is LayoutItem Then
				SetValue(TryCast(c, LayoutItem))
			End If
		Next c
	End Sub
	Private Shared Sub SetValue(ByVal c As LayoutItem)
		For Each control As Control In c.LayoutItemNestedControlContainer.Controls
			Dim editor As ASPxEdit = TryCast(control, ASPxEdit)
			If editor IsNot Nothing Then
				editor.Value = DateTime.Now.ToString()
			End If
		Next control
	End Sub
End Class