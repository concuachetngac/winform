using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using WinFormsApp1.form.Users;

namespace WindowsFormsApp2
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            int id = Convert.ToInt32(IDBox.Text);
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            string gender;
            if(femaleRadio.Checked == true)
            {
                gender = "Female";
            } else
            {
                gender = "Male";
            }
            DateTime bdate = birthDate.Value.Date;
            string phone = phoneNumbBox.Text;
            string adrs = addressBox.Text;
            MemoryStream picture = new MemoryStream();
            pictureBox.Image.Save(picture, pictureBox.Image.RawFormat);
            if(user.editUser(id, fname, lname, bdate, gender, phone, adrs, picture)) {
                MessageBox.Show("The information was changed");
            } else
            {
                MessageBox.Show("There was an error");
            }

        }
        

        private void uploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*png;*gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            if(user.deleteUser(Convert.ToInt32(IDBox.Text)))
            {
                MessageBox.Show("The information was removed");
            } else
            {
                MessageBox.Show("There was an error");
            }
           
        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bdateLabel_Click(object sender, EventArgs e)
        {

        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourse addcourse = new AddCourse();
            addcourse.Show();
        }
    }
}
