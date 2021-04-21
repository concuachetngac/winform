using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void uploadPic_Button(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*png;*gif";
            if((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
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
                if(user.insertUser(id, fname, lname, bdate, gender, phone, address, pic))
                {
                    MessageBox.Show("User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } else {
                    MessageBox.Show("Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Empty Field", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bool verif()
            {
                if ((lnameBox.Text == "")
                    || (fnameBox.Text == "")
                        || (addressBox.Text == "")
                        || (phoneNumbBox.Text == "")
                        || (pictureBox.Image == null)) {
                    return false;
                } else
                {
                    return true;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void birthDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
