Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxFormLayout
Imports DevExpress.Web.ASPxEditors

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim baseItem As LayoutItemBase = TryCast(layout.FindItemOrGroupByName(ASPxComboBox1.Value.ToString()), LayoutItemBase)
        If baseItem IsNot Nothing Then
            baseItem.Caption = ASPxComboBox1.Value.ToString() & " item found!"
            If TypeOf baseItem Is LayoutItem Then
                Dim layoutItem = (TryCast(baseItem, LayoutItem))
                For Each control In layoutItem.Controls
                    Dim editor As ASPxEdit = TryCast(control, ASPxEdit)
                    If editor IsNot Nothing Then
                        editor.Value = Date.Now
                    End If
                Next control
            End If
        End If

    End Sub
End Class