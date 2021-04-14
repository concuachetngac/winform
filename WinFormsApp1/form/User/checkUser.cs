using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;



namespace WinFormsApp1
{
    public partial class printSave : Form
    {
        public printSave()
        {
            InitializeComponent();
        }

        User student = new User();
        MY_DB db = new MY_DB();

        private void getTable(SqlCommand command)
        {
            dataGridViewCheckUser.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewCheckUser.RowTemplate.Height = 80;
            dataGridViewCheckUser.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridViewCheckUser.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewCheckUser.AllowUserToAddRows = false;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            if (allRadio.Checked)
            {
                if (yesRadio.Checked)
                {
                    command = new SqlCommand("SELECT * FROM listUser WHERE birthdate BETWEEN @fday AND @lday", db.getConnection);
                    command.Parameters.Add("@fday", SqlDbType.DateTime).Value = dateFrom.Value;
                    command.Parameters.Add("@lday", SqlDbType.DateTime).Value = dateTo.Value;

                    getTable(command);
                }
                else
                {
                    command = new SqlCommand("SELECT * FROM listUser", db.getConnection);
                    getTable(command);
                }

            }
            else
            {
                string gender = "Female"; // default gender

                //male radio button clicked
                if (maleRadio.Checked)
                {
                    //change gender
                    gender = "Male";
                }

                if (yesRadio.Checked)
                {
                    command = new SqlCommand("SELECT * FROM listUser WHERE gender = @gdr AND birthdate BETWEEN @fday AND @lday", db.getConnection);
                    command.Parameters.Add("@fday", SqlDbType.DateTime).Value = dateFrom.Value;
                    command.Parameters.Add("@lday", SqlDbType.DateTime).Value = dateTo.Value;
                    command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
                    getTable(command);
                }
                else
                {
                    command = new SqlCommand("SELECT * FROM listUser WHERE gender = @gdr", db.getConnection);
                    command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
                    getTable(command);
                }
            }
        }

        private void ToPrinterBtn_Click(object sender, EventArgs e)
        {
            PrintDialog prdi = new PrintDialog();
            prdi.ShowDialog();
            PrintDocument prdo = new PrintDocument();
            prdo.DocumentName = "Print Document";
            prdi.Document = prdo;
            if (prdi.ShowDialog() == DialogResult.OK)
            {
                prdo.Print();
            }
        }

        private void printSave_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM listUser ", db.getConnection);
            getTable(command);
            toPrinterButton.Click += ToPrinterBtn_Click;
            checkButton.Click += CheckBtn_Click;
        }

        public void ExportDataToWord(DataGridView DGV, string filename)
        {
            if(DGV.Rows.Count != 0)
            {
                int rowCount = DGV.Rows.Count;
                int columnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[rowCount + 1, columnCount + 1];

                int r = 0;
                for(int c = 0; c <= columnCount - 1; c++)
                {
                    for(r = 0; r <= rowCount -1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for(r = 0; r <= rowCount - 1; r++)
                {
                    for(int c = 0; c <= columnCount - 1; c++)
                    {
                        oTemp += DataArray[r, c] + "\t";
                    }
                }
                oRange.Text = oTemp;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref rowCount, ref columnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                for(int c = 0; c <= columnCount -1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "your header text";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                for(r=0; r <= rowCount -1; r++)
                {
                    byte[] imgbyte = (byte[])dataGridViewCheckUser.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    Image finalePic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalePic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.InsertParagraph();
                }

                oDoc.SaveAs(filename);
            }
        }

        private void saveToTextFileButton_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportDataToWord(dataGridViewCheckUser, sfd.FileName);
            }
        }
    }
}
