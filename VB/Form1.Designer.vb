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
Namespace WindowsApplication1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
            Me.riPopup = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
            Me.popupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRichTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.riPopup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupContainerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControl.SuspendLayout()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riPopup, Me.repositoryItemRichTextEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(548, 454)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.gridView2})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.RowAutoHeight = True
            AddHandler Me.gridView1.CustomRowCellEditForEditing, New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(AddressOf Me.gridView1_CustomRowCellEditForEditing)
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "gridColumn1"
            Me.gridColumn1.FieldName = "ID"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "gridColumn2"
            Me.gridColumn2.ColumnEdit = Me.repositoryItemRichTextEdit1
            Me.gridColumn2.FieldName = "Rich"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            ' 
            ' repositoryItemRichTextEdit1
            ' 
            Me.repositoryItemRichTextEdit1.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Rtf
            Me.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1"
            Me.repositoryItemRichTextEdit1.ShowCaretInReadOnly = False
            ' 
            ' riPopup
            ' 
            Me.riPopup.AutoHeight = False
            Me.riPopup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.riPopup.Name = "riPopup"
            Me.riPopup.PopupControl = Me.popupContainerControl
            AddHandler Me.riPopup.QueryResultValue, New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(AddressOf Me.riPopup_QueryResultValue)
            AddHandler Me.riPopup.QueryDisplayText, New DevExpress.XtraEditors.Controls.QueryDisplayTextEventHandler(AddressOf Me.riPopup_QueryDisplayText)
            AddHandler Me.riPopup.QueryPopUp, New System.ComponentModel.CancelEventHandler(AddressOf Me.riPopup_QueryPopUp)
            AddHandler Me.riPopup.CloseUp, New DevExpress.XtraEditors.Controls.CloseUpEventHandler(AddressOf Me.riPopup_CloseUp)
            ' 
            ' popupContainerControl
            ' 
            Me.popupContainerControl.Controls.Add(Me.richEditControl)
            Me.popupContainerControl.Location = New System.Drawing.Point(31, 323)
            Me.popupContainerControl.Name = "popupContainerControl"
            Me.popupContainerControl.Size = New System.Drawing.Size(200, 100)
            Me.popupContainerControl.TabIndex = 1
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.MailMerge.KeepLastParagraph = False
            Me.richEditControl.Size = New System.Drawing.Size(200, 100)
            Me.richEditControl.TabIndex = 2
            Me.richEditControl.Text = "myRichEditControl1"
            ' 
            ' gridView2
            ' 
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(548, 454)
            Me.Controls.Add(Me.popupContainerControl)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRichTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.riPopup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupContainerControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControl.ResumeLayout(False)
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

        Private riPopup As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit

        Private popupContainerControl As DevExpress.XtraEditors.PopupContainerControl

        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    End Class
End Namespace
