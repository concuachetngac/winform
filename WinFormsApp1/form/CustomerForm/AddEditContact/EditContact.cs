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
using WinFormsApp1.csFile.CustomerCs;

namespace WinFormsApp1.form.CustomerForm.AddEditContact
{
    public partial class EditContact : Form
    {
        
        Contact contact = new Contact();
        Group group = new Group();
        public EditContact()
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

        private void EditContact_Load(object sender, EventArgs e)
        {
            DataTable groupTable = group.getGroupList();

            for (int i = 0; i < groupTable.Rows.Count; i++)
            {
                groupComboBox.Items.Add(groupTable.Rows[i][0].ToString());
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDBox.Text);
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            int groupID = group.getGroupId(groupComboBox.SelectedItem.ToString());
            string phone = phoneBox.Text;
            string email = emailBox.Text;
            string address = addressBox.Text;

            MemoryStream pic = new MemoryStream();

            try
            {
                if (verif())
                {
                    pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                    if (contact.editContact(id, fname, lname, groupID, phone, email, address, pic))
                    {
                        MessageBox.Show("Contact Edited", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        || (IDBox.Text == "")
                        || (phoneBox.Text == "")
                        || (emailBox.Text == "")
                        || (addressBox.Text == "")
                        || (groupComboBox.Text == "")
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectContactButton_Click(object sender, EventArgs e)
        {
            SelectContact select = new SelectContact();
            this.Close();
            select.Show();
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
