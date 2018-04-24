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

Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace WindowsApplication1
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace