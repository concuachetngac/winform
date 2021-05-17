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
using WinFormsApp1.csFile.CustomerCs;
using WinFormsApp1.form.CustomerForm.AddEditContact;

namespace WinFormsApp1.form.CustomerForm.CustomerMainMenu
{
    public partial class CustomerMainInterface : Form
    {
        MY_DB mydb = new MY_DB();
        Group group = new Group();
        public CustomerMainInterface()
        {
            InitializeComponent();
        }

        private void CustomerMainInterface_Load(object sender, EventArgs e)
        {
            getCustomerImgAndUsername(Global.UserID);
            refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void getCustomerImgAndUsername(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT username, picture FROM customer WHERE id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            byte[] pic;
            pic = (byte[])table.Rows[0][1];
            MemoryStream picture = new MemoryStream(pic);
            imgPanel.BackgroundImage = Image.FromStream(picture);
            imgPanel.BackgroundImageLayout = ImageLayout.Stretch;
            welcomeLabel.Text += "(" + table.Rows[0][0] + ")";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddContact contact = new AddContact();
            contact.Show();
            contact.TopMost = true;
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            string name = groupNameBox.Text;

            if(groupNameBox.Text != "" && group.checkAvailable(Global.UserID, name))
            {
                if(group.addGroup(name, Global.UserID))
                {
                    MessageBox.Show("Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Please Enter Again !!!");
            }
        }

        private void editGroupButton_Click(object sender, EventArgs e)
        {
            if (newGroupNameBox.Text != "" && editGroupComboBox.Text != "")
            {
                int groupID = group.getGroupId(editGroupComboBox.Text.ToString());
                string newName = newGroupNameBox.Text;

                if (group.editGroup(newName, groupID))
                {
                    MessageBox.Show("Group Edited", "Group Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Group Name !!!");
            }
        }
        public void refresh()
        {
            editGroupComboBox.Items.Clear();
            editGroupComboBox.Text = "";
            removeGroupComboBox.Items.Clear();
            removeGroupComboBox.Text = "";
            
            DataTable groupTable = group.getGroupList();

            for (int i = 0; i < groupTable.Rows.Count; i++)
            {
                editGroupComboBox.Items.Add(groupTable.Rows[i][0].ToString());
                removeGroupComboBox.Items.Add(groupTable.Rows[i][0].ToString());
            }
        }

        private void refreshLabel_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void removeGroupButton_Click(object sender, EventArgs e)
        {
            if (removeGroupComboBox.Text != "")
            {
                int groupID = group.getGroupId(removeGroupComboBox.Text.ToString());

                if (group.removeGroup(groupID))
                {
                    MessageBox.Show("Group Removed", "Group Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Error", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select Group !!!");
            }
        }
    }
}
