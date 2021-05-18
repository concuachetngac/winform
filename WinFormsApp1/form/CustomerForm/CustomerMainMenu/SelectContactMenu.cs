using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WinFormsApp1.form.CustomerForm.CustomerMainMenu
{
    public partial class SelectContactMenu : Form
    {
        MY_DB mydb = new MY_DB();
        public SelectContactMenu()
        {
            InitializeComponent();
        }

        private void SelectContactMenu_Load(object sender, EventArgs e)
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
            CustomerMainInterface menu = new CustomerMainInterface();
            menu.IDBox.Text = selectContactView.CurrentRow.Cells[0].Value.ToString();
            menu.Show();
        }
    }
}
