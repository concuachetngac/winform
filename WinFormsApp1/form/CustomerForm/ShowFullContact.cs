using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.csFile.CustomerCs;

namespace WinFormsApp1.form.CustomerForm
{
    public partial class ShowFullContact : Form
    {
        Group group = new Group();
        Contact contact = new Contact();

        public ShowFullContact()
        {
            InitializeComponent();
        }

        private void ShowFullContact_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < group.getGroupList().Rows.Count; i++)
            {
                groupListBox.Items.Add(group.getGroupList().Rows[i][0].ToString());
            }

            allContactInfo.DataSource = contact.getAllContactInfo();
            allContactInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)allContactInfo.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
    }
}
