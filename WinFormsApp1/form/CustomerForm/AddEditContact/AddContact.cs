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
using WinFormsApp1.csFile.CustomerCs;

namespace WinFormsApp1.form.CustomerForm.AddEditContact
{
    public partial class AddContact : Form
    {
        Contact contact = new Contact();
        Group group = new Group();
        public AddContact()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(IDBox.Text);
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            int groupID = group.getGroupId(groupComboBox.Text);
            string phone = phoneBox.Text;
            string email = emailBox.Text;
            string address = addressBox.Text;
            MemoryStream pic = new MemoryStream();

            try
            {
                if (verif())
                {
                    pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                    if (contact.addContact(userID, fname, lname, groupID, phone, email, address, pic))
                    {
                        MessageBox.Show("Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void AddContact_Load(object sender, EventArgs e)
        {
            DataTable groupTable = group.getGroupList();

            for (int i = 0; i < groupTable.Rows.Count; i++)
            {
                groupComboBox.Items.Add(groupTable.Rows[i][0].ToString());
            }
        }
    }
}
