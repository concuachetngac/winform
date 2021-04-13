using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.form
{
    public partial class removeCourse : Form
    {
        public removeCourse()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            AddCourses course = new AddCourses();
            try
            {
                int id = Convert.ToInt32(enterIDBox.Text);
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
        }

        private void removeCourse_Load(object sender, EventArgs e)
        {
            
        }
    }
}
