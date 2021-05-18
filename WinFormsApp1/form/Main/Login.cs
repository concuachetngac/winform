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
using WinFormsApp1.form.CustomerForm.CustomerRegister;
using WinFormsApp1.form.CustomerForm.CustomerMainMenu;
using WinFormsApp1.csFile;


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

        private void login_Load(object sender, EventArgs e)
        {
            customerRadio.Checked = true;
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userRadio.Checked)
            {
                MY_DB db = new MY_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM [account] WHERE username = @User AND password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.NVarChar).Value = textBoxUser.Text;
                command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBoxPass.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Ok, next time will be go to Main Menu of App");
                    MainMenu menu = new MainMenu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (textBoxUser.Text == string.Empty)
                {
                    textBoxUser.Focus();
                    errorProvider1.SetError(textBoxUser, "Please input username !!!");
                }
                if (textBoxPass.Text == string.Empty)
                {
                    textBoxPass.Focus();
                    errorProvider1.SetError(textBoxPass, "Please input password !!!");
                }
            } else
            {
                MY_DB db = new MY_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM [customer] WHERE username = @user AND password = @pass", db.getConnection);
                command.Parameters.Add("@user", SqlDbType.NVarChar).Value = textBoxUser.Text;
                command.Parameters.Add("pass", SqlDbType.NVarChar).Value = textBoxPass.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Ok, next time will be go to Main Menu of App");
                    CustomerMainInterface customer = new CustomerMainInterface();
                    Global.setCustomerID(Convert.ToInt32(table.Rows[0][0]));
                    customer.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (textBoxUser.Text == string.Empty)
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

        }

        private void register_Click_1(object sender, EventArgs e)
        {
            if(userRadio.Checked)
            {
                Register register = new Register();
                register.ShowDialog();
            } else
            {
                CustomerRegis customer = new CustomerRegis();
                customer.ShowDialog();
            }
            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
