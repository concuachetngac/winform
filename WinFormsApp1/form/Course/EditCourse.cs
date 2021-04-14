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
    public partial class EditCourse : Form
    {
        MY_DB mydb = new MY_DB();
        public EditCourse()
        {
            InitializeComponent();
        }

        private void EditCourse_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT label FROM course", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.Fill(table);
            for(int i = 0; i < table.Rows.Count; i++)
            {
                selectBox.Items.Add(table.Rows[i].ItemArray[0]);
            }
        }

        private void editCourseButton_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            string label = selectBox.Text;
            int id = Convert.ToInt32(IDBox.Text);
            string newlabel = labelBox.Text;
            int period = Convert.ToInt32(periodNumb.Value);
            string description = descriptionBox.Text;
            try
            {
                if (course.editCourse(id, label, newlabel, period, description))
                {
                    MessageBox.Show("Edit Successfully", "Success");
                }
                else
                {
                    MessageBox.Show("ID or Label is available !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch
            {
                MessageBox.Show("ID or Label is available !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM course WHERE label = @label", mydb.getConnection);
            cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value = selectBox.Text;
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable table = new DataTable();
            adpt.Fill(table);
            IDBox.Text = table.Rows[0].ItemArray[0].ToString();
            labelBox.Text = table.Rows[0].ItemArray[1].ToString();
            periodNumb.Value = Convert.ToInt32(table.Rows[0].ItemArray[2]);
            descriptionBox.Text = table.Rows[0].ItemArray[3].ToString();          
        }
    }
}
