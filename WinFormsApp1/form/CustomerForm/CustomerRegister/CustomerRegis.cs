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
using WinFormsApp1.csFile;

namespace WinFormsApp1.form.CustomerForm.CustomerRegister
{
    public partial class CustomerRegis : Form
    {
        
        public CustomerRegis()
        {
            InitializeComponent();
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

        private void CustomerRegis_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            int id = Convert.ToInt32(IDBox.Text);
            string lname = lnameBox.Text;
            string fname = fnameBox.Text;
            string password = passWordBox.Text;
            string username = userNameBox.Text;

            MemoryStream pic = new MemoryStream();
            try
            {
                if (customer.checkExist(username)) {
                    if (verif())
                    {
                        pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                        if (customer.insertCustomer(id, fname, lname, username, password, pic))
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
                } else {
                    MessageBox.Show("Username Available !!!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("This username too long or ID available !!!");
            }


            bool verif()
            {
                if ((lnameBox.Text == "")
                    || (fnameBox.Text == "")
                        || (userNameBox.Text == "")
                        || (passWordBox.Text == "")
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

        private void backToLoginLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
