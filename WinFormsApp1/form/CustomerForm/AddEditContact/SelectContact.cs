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

namespace WinFormsApp1.form.CustomerForm.AddEditContact
{
    public partial class SelectContact : Form
    {

        MY_DB mydb = new MY_DB();
        Contact contact = new Contact();
        public SelectContact()
        {
            InitializeComponent();
        }

        private void SelectContact_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT id, lname, fname, userid FROM mycontact", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            selectContactView.DataSource = table;
            selectContactView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void selectContactView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Group group = new Group();
            EditContact edit = new EditContact();
            int contactID = Convert.ToInt32(selectContactView.CurrentRow.Cells[0].Value.ToString());
            edit.Show();

            DataTable contactInfo = contact.getContactInfo(contactID);
            edit.IDBox.Text = contactInfo.Rows[0][0].ToString();
            edit.fnameBox.Text = contactInfo.Rows[0][1].ToString();
            edit.lnameBox.Text = contactInfo.Rows[0][2].ToString();
            edit.groupComboBox.Text = group.getGroupName(Convert.ToInt32(contactInfo.Rows[0][3]));
            edit.phoneBox.Text = contactInfo.Rows[0][4].ToString();
            edit.emailBox.Text = contactInfo.Rows[0][5].ToString();
            edit.addressBox.Text = contactInfo.Rows[0][6].ToString();
            byte[] pic;
            pic = (byte[])contactInfo.Rows[0][7];
            MemoryStream picture = new MemoryStream(pic);
            edit.pictureBox.Image = Image.FromStream(picture);
        }
    }
}
