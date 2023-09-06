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
Imports System.Drawing
Imports System.IO

Namespace WindowsApplication1

    Public Module RTFTextProvider

        Private _TestText As String

        Sub New()
            Dim tr As StreamReader = New StreamReader("..\..\RTFText.rtf")
            _TestText = tr.ReadToEnd()
        End Sub

        Public Function GetRichText(ByVal obj As Object) As Object
            Return _TestText.Replace("TextToReplace", obj.ToString())
        End Function
    End Module
End Namespace
