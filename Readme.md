<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128627829/12.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2503)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Display rich text in data cells and edit cell values in a popup window

This example demonstrates how to use different data editors to display and edit cell values. The [RichEditControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl) is used to edit RTF data (it is displayed within a popup window). The [RepositoryItemRichTextEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit) is used to display RTF data in data cells.

The [CustomRowCellEditForEditing](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.CustomRowCellEditForEditing) event is handled to assign a custom RTF editor to a column for in-place editing (to override the default column editor):

```csharp
void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
    if (e.Column.FieldName == "Rich")
        e.RepositoryItem = riPopup;
}
```


## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [RTFTestProvider.cs](./CS/RTFTestProvider.cs) (VB: [RTFTestProvider.vb](./VB/RTFTestProvider.vb))
