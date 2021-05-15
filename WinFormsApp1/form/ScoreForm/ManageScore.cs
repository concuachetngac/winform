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
    public partial class ManageScore : Form
    {
        MY_DB mydb = new MY_DB();
        User user = new User();
        Course course = new Course();
        Score score = new Score();
        public ManageScore()
        {
            InitializeComponent();
        }

        private void avgScoreButton_Click(object sender, EventArgs e)
        {
            AverageGrade avgGrade = new AverageGrade();
            avgGrade.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int stdID = Convert.ToInt32(IDBox.Text);
                int courseID = Convert.ToInt32(course.getCourseId(coursesBox.SelectedItem.ToString()));
                float stdScore = float.Parse(scoreBox.Text);
                string des = descriptionBox.Text;
                if (score.addScore(stdID, courseID, stdScore, des))
                {
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("There was an error !!!");
                    course.avgGrade();
                }
            }
            catch
            {
                MessageBox.Show("Your score is not valid !!!");
            }
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

        private void showStudentButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id, fname, lname, birthdate FROM listUser", mydb.getConnection);

            listUserDataGrid.DataSource = user.getStudents(cmd);
            listUserDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listUserDataGrid.Columns[0].HeaderText = "ID";
            listUserDataGrid.Columns[1].HeaderText = "First Name";
            listUserDataGrid.Columns[2].HeaderText = "Last Name";
            listUserDataGrid.Columns[3].HeaderText = "BirthDate";
        }

        private void ManageScore_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id, fname, lname, birthdate FROM listUser", mydb.getConnection);

            listUserDataGrid.DataSource = user.getStudents(cmd);
            listUserDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listUserDataGrid.Columns[0].HeaderText = "ID";
            listUserDataGrid.Columns[1].HeaderText = "First Name";
            listUserDataGrid.Columns[2].HeaderText = "Last Name";
            listUserDataGrid.Columns[3].HeaderText = "BirthDate";
        }

        private void showScoreButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT score.student_id, listUser.fname, listUser.lname, score.course_id, course.label, score.student_score, score.description FROM score, listUser, course WHERE score.student_id = listUser.Id AND score.course_id = course.id ", mydb.getConnection);
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

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveScore remove = new RemoveScore();
            remove.Show();
        }

        private void listUserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDBox.Text = listUserDataGrid.CurrentRow.Cells[0].Value.ToString();
                descriptionBox.Text = listUserDataGrid.CurrentRow.Cells[6].Value.ToString();
                scoreBox.Text = listUserDataGrid.CurrentRow.Cells[5].Value.ToString();
            } catch
            {

            }
        }
    }
}
