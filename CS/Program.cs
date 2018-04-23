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
using System.Windows.Forms;

namespace WindowsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}