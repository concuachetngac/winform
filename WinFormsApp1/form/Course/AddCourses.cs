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

namespace WinFormsApp1.form
{
    public partial class AddCourses : Form
    {
        MY_DB mydb = new MY_DB();
        Course course = new Course();
        public AddCourses()
        {
            InitializeComponent();
        }
        
  
        private void period_TextChanged(object sender, EventArgs e)
        {

        }

        private void Courses_Load(object sender, EventArgs e)
        {

        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(courseIDBox.Text);
                string label = labelBox.Text;
                int period = Convert.ToInt32(periodBox.Text);
                string description = descriptionBox.Text;
                if (course.insertCourse(id, label, period, description))
                {
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("That was an unknow error !!!");
                }
            } catch
            {
                MessageBox.Show("ID or Label is available !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
