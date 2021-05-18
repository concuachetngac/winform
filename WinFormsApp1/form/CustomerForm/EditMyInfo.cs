using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using WinFormsApp1.csFile;

namespace WinFormsApp1.form.CustomerForm
{
    public partial class EditMyInfo : Form
    {
        MY_DB mydb = new MY_DB();
        Customer customer = new Customer();
        public EditMyInfo()
        {
            InitializeComponent();
        }

        private void EditMyInfo_Load(object sender, EventArgs e)
        {
            DataTable customerInfo = customer.getCustomerInfo(Global.CustomerID);
            fnameBox.Text = customerInfo.Rows[0][1].ToString();
            lnameBox.Text = customerInfo.Rows[0][2].ToString();
            userNameBox.Text = customerInfo.Rows[0][3].ToString();
            passWordBox.Text = customerInfo.Rows[0][4].ToString();
            byte[] pic;
            pic = (byte[])customerInfo.Rows[0][5];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox.Image = Image.FromStream(picture);

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

        private void editButton_Click(object sender, EventArgs e)
        {
            DataTable customerInfo = customer.getCustomerInfo(Global.CustomerID);
            string fname = customerInfo.Rows[0][1].ToString();
            string lname = customerInfo.Rows[0][2].ToString();
            string username = customerInfo.Rows[0][3].ToString();
            string password = customerInfo.Rows[0][4].ToString();

            MemoryStream pic = new MemoryStream();

            try
            {
                if (verif())
                {
                    pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                    if (customer.editCustomer(Global.CustomerID, fname, lname, username, password, pic))
                    {
                        MessageBox.Show("Customer Edited", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("This Id is available !!!");
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
    }
}

