﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            dataGridViewUserList.DataSource = dataTable();
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn = (DataGridViewImageColumn)dataGridViewUserList.Columns[7];
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewUserList.Columns[0].HeaderText = "ID";
            dataGridViewUserList.Columns[1].HeaderText = "First Name";
            dataGridViewUserList.Columns[2].HeaderText = "Last Name";
            dataGridViewUserList.Columns[3].HeaderText = "BirthDate";
            dataGridViewUserList.Columns[4].HeaderText = "Gender";
            dataGridViewUserList.Columns[5].HeaderText = "Phone Number";
            dataGridViewUserList.Columns[6].HeaderText = "Address";
            dataGridViewUserList.Columns[7].HeaderText = "Picture";
            

            
            

        }

        private DataTable dataTable()
        {
            MY_DB db = new MY_DB();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM listUser", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(tb);
            return tb;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridViewUserList.DataSource = dataTable();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var userInfo = new UserInfo();
            userInfo.IDBox.Text = dataGridViewUserList.CurrentRow.Cells[0].Value.ToString();
            userInfo.fnameBox.Text = dataGridViewUserList.CurrentRow.Cells[1].Value.ToString();
            userInfo.lnameBox.Text = dataGridViewUserList.CurrentRow.Cells[2].Value.ToString();
            userInfo.birthDate.Value = (DateTime)dataGridViewUserList.CurrentRow.Cells[3].Value;
            if (dataGridViewUserList.CurrentRow.Cells[4].Value.ToString().Equals("Female"))
            {
                userInfo.femaleRadio.Checked = true;
            }
            else
            {
                userInfo.maleRadio.Checked = true;
            }
            userInfo.phoneNumbBox.Text = dataGridViewUserList.CurrentRow.Cells[5].Value.ToString();
            userInfo.addressBox.Text = dataGridViewUserList.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridViewUserList.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            userInfo.pictureBox.Image = Image.FromStream(picture);
            userInfo.ShowDialog();
        }
    }
}
