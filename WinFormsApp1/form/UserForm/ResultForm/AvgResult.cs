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
using WinFormsApp1.csFile;

namespace WinFormsApp1.form.ResultForm
{
    public partial class AvgResult : Form
    {
        MY_DB mydb = new MY_DB();
        User user = new User();
        Score score = new Score();
        Result result = new Result();
        public AvgResult()
        {
            InitializeComponent();
        }

        private void listUserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDBox.Text = listUserDataGrid.CurrentRow.Cells[0].Value.ToString();
            fnameBox.Text = listUserDataGrid.CurrentRow.Cells[1].Value.ToString();
            lnameBox.Text = listUserDataGrid.CurrentRow.Cells[2].Value.ToString();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            DataTable courseTable = course.getAllCourses();
            DataTable table = result.getResultTable(courseTable);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataTable userScore = user.getScore(Convert.ToInt32(table.Rows[i].ItemArray[0]));
                for (int j = 3; j < courseTable.Rows.Count + 3; j++)
                {
                    for(int k = 0; k < userScore.Rows.Count; k++)
                    {
                        if(course.getCourseLabel(Convert.ToInt32(userScore.Rows[k].ItemArray[0])) == table.Columns[j].ColumnName)
                        {
                            table.Rows[i][j] = userScore.Rows[k].ItemArray[1];
                        }
                    }
                }
            }

            listUserDataGrid.DataSource = table;
            listUserDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataTable courseTable = course.getAllCourses();
            try
            {
                DataTable table = result.searchUserTable(courseTable, searchBox.Text);


                DataTable userScore = user.getScore(Convert.ToInt32(searchBox.Text));
                for (int j = 3; j < courseTable.Rows.Count + 3; j++)
                {
                    for (int k = 0; k < userScore.Rows.Count; k++)
                    {
                        if (course.getCourseLabel(Convert.ToInt32(userScore.Rows[k].ItemArray[0])) == table.Columns[j].ColumnName)
                        {
                            table.Rows[0][j] = userScore.Rows[k].ItemArray[1];
                        }
                    }
                }
                listUserDataGrid.DataSource = table;
                listUserDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            } catch
            {
                try
                {
                    DataTable table = result.searchUserTable(courseTable, searchBox.Text);

                    DataTable userScore = user.getScoreByFname(searchBox.Text);
                    for (int j = 3; j < courseTable.Rows.Count + 3; j++)
                    {
                        for (int k = 0; k < userScore.Rows.Count; k++)
                        {
                            if (course.getCourseLabel(Convert.ToInt32(userScore.Rows[k].ItemArray[0])) == table.Columns[j].ColumnName)
                            {
                                table.Rows[0][j] = userScore.Rows[k].ItemArray[1];
                            }
                        }
                    }
                    listUserDataGrid.DataSource = table;
                    listUserDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                } catch
                {

                }
            }


        }

        private void printButton_Click(object sender, EventArgs e)
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
