' Developer Express Code Central Example:
' How to display rich text in GridView's cells, but edit their content in a popup window
' 
' This example demonstrates how to provide different editors for displaying and
' editing data. In this scenario, cells values can be edited using the
' RichEditControl located in the popup window. However, the
' RepositoryItemRichTextEdit is used to display cells content when their in-place
' editor is closed.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2503
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Private Function CreateTable(ByVal RowCount As Integer) As DataTable
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("Name", GetType(String))
            tbl.Columns.Add("ID", GetType(Integer))
            tbl.Columns.Add("Number", GetType(Integer))
            tbl.Columns.Add("Date", GetType(Date))
            tbl.Columns.Add("Rich", GetType(String))
            For i As Integer = 0 To RowCount - 1
                tbl.Rows.Add(New Object() {String.Format("Name{0}", i), i, 3 - i, Date.Now.AddDays(i), GetRichText(i)})
            Next

            Return tbl
        End Function

        Public Sub New()
            InitializeComponent()
            gridControl1.DataSource = CreateTable(20)
            gridView1.OptionsView.RowAutoHeight = True
            gridView1.RowHeight = 30
            gridColumn1.Width = 20
            riPopup.PopupFormMinSize = New Size(400, 400)
        End Sub

        Private Sub gridView1_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs)
            If Equals(e.Column.FieldName, "Rich") Then e.RepositoryItem = riPopup
        End Sub

        Private Sub riPopup_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim editor As BaseEdit = CType(sender, BaseEdit)
            richEditControl.Document.RtfText = editor.EditValue.ToString()
        End Sub

        Private Sub riPopup_QueryDisplayText(ByVal sender As Object, ByVal e As QueryDisplayTextEventArgs)
            e.DisplayText = richEditControl.Document.Text
        End Sub

        Private Sub riPopup_QueryResultValue(ByVal sender As Object, ByVal e As QueryResultValueEventArgs)
            e.Value = richEditControl.Document.RtfText
        End Sub

        Private Sub riPopup_CloseUp(ByVal sender As Object, ByVal e As CloseUpEventArgs)
            If Not e.AcceptValue Then
                Dim pSender As PopupContainerEdit = CType(sender, PopupContainerEdit)
                Dim rEdit As RichEditControl = CType(pSender.Properties.PopupControl.Controls(0), RichEditControl)
                rEdit.Document.RtfText = e.Value.ToString()
            End If
        End Sub
    End Class
End Namespace
