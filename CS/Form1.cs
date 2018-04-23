// Developer Express Code Central Example:
// How to display rich text in GridView's cells, but edit their content in a popup window
// 
// This example demonstrates how to provide different editors for displaying and
// editing data. In this scenario, cells values can be edited using the
// RichEditControl located in the popup window. However, the
// RepositoryItemRichTextEdit is used to display cells content when their in-place
// editor is closed.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2503

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
           
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("Rich", typeof(string));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i), RTFTextProvider.GetRichText(i) });
            return tbl;
        }

        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20);
            gridView1.OptionsView.RowAutoHeight = false;
            gridView1.RowHeight = 30;
            gridColumn1.Width = 20;
            riPopup.PopupFormMinSize = new Size(400, 400);
        }

        void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "Rich")
                e.RepositoryItem = riPopup;
        }


        void riPopup_QueryPopUp(object sender, CancelEventArgs e)
        {
            richEditControl.Document.RtfText = (sender as BaseEdit).EditValue.ToString();
        }

        void riPopup_QueryDisplayText(object sender, QueryDisplayTextEventArgs e)
        {
            e.DisplayText = richEditControl.Document.Text;
        }

        void riPopup_QueryResultValue(object sender, QueryResultValueEventArgs e)
        {
            e.Value = richEditControl.Document.RtfText;
        }

        private void riPopup_CloseUp(object sender, CloseUpEventArgs e) {
            if(!e.AcceptValue) {
                PopupContainerEdit pSender = sender as PopupContainerEdit;
                RichEditControl rEdit = pSender.Properties.PopupControl.Controls[0] as RichEditControl;
                rEdit.Document.RtfText = e.Value.ToString();
            }
        }

    }

}