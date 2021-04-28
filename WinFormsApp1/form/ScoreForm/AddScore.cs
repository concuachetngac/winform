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

namespace WinFormsApp1.form.ScoreForm
{
    public partial class AddScore : Form
    {
        MY_DB mydb = new MY_DB();
        User user = new User();
        Course course = new Course();
        public AddScore()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddScore_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id, fname, lname FROM listUser", mydb.getConnection);

            listUserDataGrid.DataSource = user.getStudents(cmd);
            listUserDataGrid.RowHeadersWidth = 7;
            listUserDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            coursesBox.Items.Clear();
            try
            {
                DataTable table = user.getSelectedcourse(Convert.ToInt32(IDBox.Text));
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    coursesBox.Items.Add(course.getCourseLabel(Convert.ToInt32(table.Rows[i].ItemArray[0])));
                }
            } catch
            {
                
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
