using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2.formFile;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM account WHERE username = @User AND password = @Pass", db.getConnection);
            command.Parameters.Add("@User", SqlDbType.NVarChar).Value = textBoxUser.Text;
            command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBoxPass.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Ok, next time will be go to Main Menu of App");
                var menu = new MainMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if(textBoxUser.Text == string.Empty)
            {
                textBoxUser.Focus();
                errorProvider1.SetError(textBoxUser, "Please input username !!!");
            }
            if (textBoxPass.Text == string.Empty)
            {
                textBoxPass.Focus();
                errorProvider1.SetError(textBoxPass, "Please input password !!!");
            }

        }

        private void register_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
