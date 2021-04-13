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
        public AddCourses()
        {
            InitializeComponent();
        }
        public bool checkCourseName(string courseName, int courseId = 0)
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE label=@cName And id <> @cID", mydb.getConnection);

            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows.Count <= 0;

        }

        public bool insertCourse(int id, string label, int period, string des)
        {
            SqlCommand command = new SqlCommand("INSERT INTO course (id, label, period, description) VALUES(@id, @label, @period, @des)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@des", SqlDbType.Text).Value = des;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool removeCourseById(int id)
        {
            SqlCommand command = new SqlCommand("DELETE * FROM course WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
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
            int id = Convert.ToInt32(courseIDBox.Text);
            string label = labelBox.Text;
            int period = Convert.ToInt32(periodBox.Text);
            string description = descriptionBox.Text;
            if(insertCourse(id, label, period, description))
            {
                MessageBox.Show("Added");
            } else {
                MessageBox.Show("That was an unknow error !!!");
            }
        }
    }
}
