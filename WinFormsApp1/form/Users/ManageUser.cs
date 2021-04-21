using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WinFormsApp1.form.Users
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            int id = Convert.ToInt32(IDBox.Text);
            string lname = lnameBox.Text;
            string fname = fnameBox.Text;
            int phone = Convert.ToInt32(phoneNumbBox.Text);
            string address = addressBox.Text;
            DateTime bdate = birthDate.Value;
            string gender = "Female";
            if (maleRadio.Checked)
            {
                gender = "Male";

            }
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                if (user.insertUser(id, fname, lname, bdate, gender, phone, address, pic))
                {
                    MessageBox.Show("User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bool verif()
            {
                if ((lnameBox.Text == "")
                    || (fnameBox.Text == "")
                        || (addressBox.Text == "")
                        || (phoneNumbBox.Text == "")
                        || (pictureBox.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            int id = Convert.ToInt32(IDBox.Text);
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            string gender;
            if (femaleRadio.Checked == true)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }
            DateTime bdate = birthDate.Value;
            string phone = phoneNumbBox.Text;
            string adrs = addressBox.Text;
            MemoryStream picture = new MemoryStream();
            pictureBox.Image.Save(picture, pictureBox.Image.RawFormat);
            if (user.editUser(id, fname, lname, bdate, gender, phone, adrs, picture))
            {
                MessageBox.Show("The information was changed");
            }
            else
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
            if (user.deleteUser(Convert.ToInt32(IDBox.Text)))
            {
                MessageBox.Show("The information was removed");
            }
            else
            {
                MessageBox.Show("There was an error");
            }
        }
    }
}
