using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WinFormsApp1
{
    public partial class printSave : Form
    {
        public printSave()
        {
            InitializeComponent();
        }

        User student = new User();
        MY_DB db = new MY_DB();

        private void getTable(SqlCommand command)
        {
            dataGridViewCheckUser.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewCheckUser.RowTemplate.Height = 80;
            dataGridViewCheckUser.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridViewCheckUser.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewCheckUser.AllowUserToAddRows = false;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            if (allRadio.Checked)
            {
                if (yesRadio.Checked)
                {
                    command = new SqlCommand("SELECT * FROM listUser WHERE birthdate BETWEEN @fday AND @lday", db.getConnection);
                    command.Parameters.Add("@fday", SqlDbType.DateTime).Value = dateFrom.Value;
                    command.Parameters.Add("@lday", SqlDbType.DateTime).Value = dateTo.Value;

                    getTable(command);
                }
                else
                {
                    command = new SqlCommand("SELECT * FROM listUser", db.getConnection);
                    getTable(command);
                }

            }
            else
            {
                string gender = "Female"; // default gender

                //male radio button clicked
                if (maleRadio.Checked)
                {
                    //change gender
                    gender = "Male";
                }

                if (yesRadio.Checked)
                {
                    command = new SqlCommand("SELECT * FROM listUser WHERE gender = @gdr AND birthdate BETWEEN @fday AND @lday", db.getConnection);
                    command.Parameters.Add("@fday", SqlDbType.DateTime).Value = dateFrom.Value;
                    command.Parameters.Add("@lday", SqlDbType.DateTime).Value = dateTo.Value;
                    command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
                    getTable(command);
                }
                else
                {
                    command = new SqlCommand("SELECT * FROM listUser WHERE gender = @gdr", db.getConnection);
                    command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
                    getTable(command);
                }
            }
        }

        private void ToPrinterBtn_Click(object sender, EventArgs e)
        {
            PrintDialog prdi = new PrintDialog();
            prdi.ShowDialog();
            PrintDocument prdo = new PrintDocument();
            prdo.DocumentName = "Print Document";
            prdi.Document = prdo;
            if (prdi.ShowDialog() == DialogResult.OK)
            {
                prdo.Print();
            }
        }

        private void printSave_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM listUser ", db.getConnection);
            getTable(command);
            toPrinterButton.Click += ToPrinterBtn_Click;
            checkButton.Click += CheckBtn_Click;
        }
    }
}
