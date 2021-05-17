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
using WinFormsApp1.csFile;

namespace WinFormsApp1.form.ResultForm
{
    public partial class StaticResult : Form
    {
        public StaticResult()
        {
            InitializeComponent();
        }

        private void staticResult_Load(object sender, EventArgs e)
        {
            Result result = new Result();
            MY_DB mydb = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT label, avg_grade FROM course", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);
            int locationX = 39;
            int locationY = 141;

            for(int i = 0; i < table.Rows.Count; i++)
            {
                Label course = new Label();
                course.Text = table.Rows[i][0].ToString() + ": " + table.Rows[i][1].ToString();
                course.Font = new Font("Microsoft Sans Serif", 20);
                course.ForeColor = Color.White;
                course.Location = new Point(locationX, locationY);
                locationY += 40;
                course.Size = new Size(400, 40);
                Controls.Add(course);
            }

            passLabel.Text += " " + result.getPassPercent() + "%";
            failLabel.Text += " " + (100 - result.getPassPercent()) + "%";
        }
    }
}
