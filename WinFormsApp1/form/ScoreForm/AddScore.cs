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

namespace WinFormsApp1.form.ScoreForm
{
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddScore_Load(object sender, EventArgs e)
        {
            MY_DB mydb = new MY_DB();
            User user = new User();
            SqlCommand cmd = new SqlCommand("SELECT Id, fname, lname FROM listUser", mydb.getConnection);

            listUserDataGrid.DataSource = user.getStudents(cmd);
            listUserDataGrid.RowHeadersWidth = 7;
            listUserDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
    }
}
