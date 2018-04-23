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


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Namespace WindowsApplication1
	Public NotInheritable Class RTFTextProvider
		Private Shared _TestText As String

		Private Sub New()
		End Sub
		Shared Sub New()
			Dim tr As New StreamReader("..\..\RTFText.rtf")
			_TestText = tr.ReadToEnd()
		End Sub


		Public Shared Function GetRichText(ByVal obj As Object) As Object
			Return _TestText.Replace("TextToReplace", obj.ToString())
		End Function
	End Class
End Namespace
