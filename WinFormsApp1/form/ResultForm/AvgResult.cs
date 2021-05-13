using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        Course course = new Course();
        Score score = new Score();
        public AvgResult()
        {
            InitializeComponent();
        }

        private void listUserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id, fname, lname FROM listUser", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);
            DataTable courseTable = course.getAllCourses();

            for (int i = 0; i < courseTable.Rows.Count; i++)
            {
                table.Columns.Add(courseTable.Rows[i].ItemArray[0].ToString(), typeof(float));
            }

            for(int i = 0; i < table.Rows.Count; i++)
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
            table.Columns.Add("Avarage Score",typeof(float));

            table.Columns.Add("Result", typeof(string));

            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i][table.Columns.Count - 2] = user.getAvgScore(Convert.ToInt32(table.Rows[i][0]));
                if (user.getAvgScore(Convert.ToInt32(table.Rows[i][0])) >= 5)
                {
                    table.Rows[i][table.Columns.Count - 1] = "pass";
                } else {
                    table.Rows[i][table.Columns.Count - 1] = "fail";
                }
            }



            listUserDataGrid.DataSource = table;
            listUserDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
