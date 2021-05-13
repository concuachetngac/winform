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

namespace WinFormsApp1.form.ScoreForm
{
    public partial class AverageGrade : Form
    {
        public AverageGrade()
        {
            InitializeComponent();
        }

        private void AverageGrade_Load(object sender, EventArgs e)
        {
            MY_DB mydb = new MY_DB();
            Score score = new Score();

            SqlCommand cmd = new SqlCommand("SELECT course.label AS Course, AVG(score.student_score) AS 'Avarage Score' FROM course, score WHERE course.id = score.course_id GROUP BY course.label", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(table);

            avgGradeGrid.DataSource = table;
            avgGradeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        
        }
    }
}
