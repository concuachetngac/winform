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

namespace WinFormsApp1.form.CourseForm
{
    public partial class CourseStdList : Form
    {
        MY_DB mydb = new MY_DB();
        Course course = new Course();

        public string courseName = "";
        public string semester = "";
        public int id;
        public CourseStdList()
        {
            InitializeComponent();
        }

        private void toPrinterButton_Click(object sender, EventArgs e)
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

        private void courseStdList_Load(object sender, EventArgs e)
        {
            courseNameBox.Text = courseName;
            semesterLabel.Text += " " + semester;
            SqlCommand cmd = new SqlCommand("SELECT row_number() OVER (ORDER BY listUser.lname, listUser.fname) STT, listUser.user_id, listUser.fname, listUser.lname FROM score, listUser WHERE listUser.user_id = score.student_id AND score.course_id = @course_id", mydb.getConnection);
            cmd.Parameters.Add("@course_id", SqlDbType.Int).Value = course.getCourseId(courseName);
            DataTable table = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(table);
            table.Columns.Add("DoB");
            listStudentView.DataSource = table;
            listStudentView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
