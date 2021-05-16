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

namespace WinFormsApp1.form.ScoreForm
{
    public partial class RemoveScore : Form
    {
        MY_DB mydb = new MY_DB();
        User user = new User();
        Course course = new Course();
        Score score = new Score();
        public RemoveScore()
        {
            InitializeComponent();
        }

        private void RemoveScore_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT score.student_id, listUser.fname, listUser.lname, score.course_id, course.label, score.student_score, score.description FROM score, listUser, course WHERE score.student_id = listUser.user_id AND score.course_id = course.id ", mydb.getConnection);
            listUserDataGrid.DataSource = user.getStudents(cmd);
            listUserDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listUserDataGrid.Columns[0].HeaderText = "Student ID";
            listUserDataGrid.Columns[1].HeaderText = "First Name";
            listUserDataGrid.Columns[2].HeaderText = "Last Name";
            listUserDataGrid.Columns[3].HeaderText = "Course ID";
            listUserDataGrid.Columns[4].HeaderText = "Course Label";
            listUserDataGrid.Columns[5].HeaderText = "Score";
            listUserDataGrid.Columns[6].HeaderText = "Description";
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            coursesBox.Text = "";
            coursesBox.Items.Clear();
            try
            {
                DataTable table = user.getSelectedcourse(Convert.ToInt32(IDBox.Text));
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    coursesBox.Items.Add(course.getCourseLabel(Convert.ToInt32(table.Rows[i].ItemArray[0])));
                }
            }
            catch
            {

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int student_id = Convert.ToInt32(IDBox.Text);
            int course_id = course.getCourseId(coursesBox.SelectedItem.ToString());

            if (score.removeScore(student_id, course_id))
            {
                MessageBox.Show("Removed");
            } else {
                MessageBox.Show("There was some error !!!");
            }

            
        }

        private void listUserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDBox.Text = listUserDataGrid.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
