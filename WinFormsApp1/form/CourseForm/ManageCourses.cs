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

namespace WinFormsApp1.form.CourseForm
{
    public partial class ManageCourses : Form
    {
        Course course = new Course();

        public ManageCourses()
        {
            InitializeComponent();
        }

        private void ManageCourses_Load(object sender, EventArgs e)
        {
            refreshCourseListBox();
            

        }

        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM course WHERE label = @label", mydb.getConnection);
            cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value = courseListBox.SelectedItem.ToString();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable table = new DataTable();
            adpt.Fill(table);
            IDBox.Text = table.Rows[0].ItemArray[0].ToString();
            labelBox.Text = table.Rows[0].ItemArray[1].ToString();
            periodNumb.Value = Convert.ToInt32(table.Rows[0].ItemArray[2]);
            descriptionBox.Text = table.Rows[0].ItemArray[3].ToString();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            courseListBox.SelectedIndex = 0;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (course.getAllCourses().Rows.Count - 1 != courseListBox.SelectedIndex)
            {
                courseListBox.SelectedIndex += 1;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (courseListBox.SelectedIndex > 0)
            {
                courseListBox.SelectedIndex -= 1;
            } 

        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            courseListBox.SelectedIndex = course.getAllCourses().Rows.Count - 1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            
          

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            
        }
        public void refreshCourseListBox()
        {
            courseListBox.Items.Clear();
            for (int i = 0; i < course.getAllCourses().Rows.Count; i++)
            {
                courseListBox.Items.Add(course.getAllCourses().Rows[i].ItemArray[0]);
            }
            totalCourselLabel.Text = "Total Course: " + course.getAllCourses().Rows.Count;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Course course = new Course();

            int id = Convert.ToInt32(IDBox.Text);
            try
            {
                if (MessageBox.Show("Are You Sure You Want To Delete This Course?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.removeCourseById(id))
                    {
                        MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refreshCourseListBox();
        }
    }
}
