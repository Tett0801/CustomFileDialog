using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Dialogs.Controls;
using System.IO;

namespace CustomFileDialog
{
    class Importer
    {
        public string GetfilePath(out int commentNumColumn)
        {
            var filePath = "";
            CommentNums commentNum = 0;
            commentNumColumn = 0;
            var commentNumEnum = 0;

            // OpenFileDialogのインスタンスを生成
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            // Create instance of comboBox used in the common file dialog.  
            CommonFileDialogComboBox comboBox = new CommonFileDialogComboBox();

            for (int i= 1; i<=10; i++ )
            {
                // Add contents that showed in the comboBox
                comboBox.Items.Add(new CommonFileDialogComboBoxItem("Label" + i));
            }

            // TODO
            comboBox.SelectedIndex = 0;
            // Add the comboBox control to the file dialog.
            dialog.Controls.Add(comboBox);

            // TODO
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                filePath = dialog.FileName;
                commentNumEnum= (int)commentNum = comboBox.Items[comboBox.SelectedIndex].Text;
                commentNumColumn = (int)commentNum;

                //DayOfWeek列挙体に変換する
                commentNumEnum = (CommentNums)Enum.Parse(typeof(CommentNums), commentNum);
            }

            return filePath;
        }

        public List<ImportContents> ReadCsvFile(string filePath, )
        {
            var importContents = new List<ImportContents>();

            string[] lines = File.ReadAllLines(filePath);


            return importContents;
        }

        public enum CommentNums
        {
            Label1 = 1,
            Label2 = 2,
            Label3 = 3,
            Label4 = 4,
            Label5 = 5,
            Label6 = 6,
            Label7 = 7,
            Label8 = 8,
            Label9 = 9,
            Label10 = 10,
        }

    }
}
