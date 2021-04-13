using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2.formFile
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("INSERT INTO account (username, password, Id) VALUES (@username, @password, @id)", db.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = Convert.ToInt32(IDBox.Text);
            cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar).Value = textBoxUser.Text;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = textBoxPass.Text;
            db.openConnection();
            if(cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("You Have Sign Up Successfully");
                db.closeConnection();
            } else
            {
                db.closeConnection();
            }
            
        }

        private void userNameLab_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
