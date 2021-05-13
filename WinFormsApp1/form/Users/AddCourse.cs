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

namespace WinFormsApp1.form.Users
{
    public partial class AddCourse : Form
    {
        Course course = new Course();
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            availableCourseRefresh();
            if(idBox.Text == "")
            {
                addButton.Enabled = false;
            }
        }
        private void availableCourseRefresh()
        {
            availableCourseListBox.Items.Clear();

            User user = new User();
            MY_DB mydb = new MY_DB();

            SqlCommand cmd = new SqlCommand("SELECT * FROM course WHERE semester=@semester", mydb.getConnection);          
            cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semesterBox.Value;
            DataTable allCourseTable = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.Fill(allCourseTable);

            DataTable selectedCourseTable = new DataTable();
            try
            {
                selectedCourseTable = user.getSelectedcourse(Convert.ToInt32(idBox.Text));
                for (int i = 0; i < allCourseTable.Rows.Count; i++)
                {
                    int count = 0;
                    //if Selected Course == All Course count increase
                    for (int j = 0; j < selectedCourseTable.Rows.Count; j++)
                    {
                        if (allCourseTable.Rows[i].ItemArray[0].ToString() == selectedCourseTable.Rows[j].ItemArray[0].ToString())
                        {
                            count++;
                        } 
                    }
                    if(count == 0)
                    {
                        availableCourseListBox.Items.Add(allCourseTable.Rows[i].ItemArray[1].ToString());
                    }
                }
            } catch
            {

            }     
        }

        private void semesterBox_ValueChanged(object sender, EventArgs e)
        {
            availableCourseRefresh();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectedCourseListBox.Items.Add(availableCourseListBox.SelectedItem);
                availableCourseListBox.Items.Remove(availableCourseListBox.SelectedItem);
            } catch
            {
                MessageBox.Show("Please select course !!!");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MY_DB mydb = new MY_DB();
            User user = new User();
            SqlCommand cmd = new SqlCommand("SELECT * FROM listUser WHERE Id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(idBox.Text);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable table = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(table);

            if(table.Rows.Count > 0)
            {
                for (int i = 0; i < selectedCourseListBox.Items.Count; i++)
                {
                    int courseID = course.getCourseId(selectedCourseListBox.Items[i].ToString());
                    if (user.addCourse(Convert.ToInt32(idBox.Text), courseID, 0, ""))
                    {
                        MessageBox.Show("Saved " + selectedCourseListBox.Items[i].ToString());
                    }
                }
                selectedCourseListBox.Items.Clear();
                mydb.closeConnection();
                
            } else {
                MessageBox.Show("This ID is not available!!!", "Error");
                mydb.closeConnection();
            }
            if (user.selectedCourse(Convert.ToInt32(idBox.Text)))
            {
                
            }

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            availableCourseRefresh();
        }


        
    }
}
