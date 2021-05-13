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
using WinFormsApp1;
using WinFormsApp1.form;
using WinFormsApp1.form.CourseForm;
using WinFormsApp1.form.Users;
using WinFormsApp1.form.ScoreForm;
using WinFormsApp1.form.ResultForm;

namespace WindowsFormsApp2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            //User dropdown Item
            addUserToolStrip.Click += addUserStrip_ItemClicked;
            userList.Click += userList_ItemClicked;
            printToolStrip.Click += printUser_ItemClicked;
            editAndRemove.Click += editAndRemove_ItemClicked;
            mangeUser.Click += manageUser_ItemClicked;

            //Course dropdown Item
            addCourse.Click += addCourse_ItemClicked;
            removeCourse.Click += removeCourse_ItemClicked;
            editCourse.Click += editCourse_ItemClicked;
            manageCourse.Click += manageCourse_ItemClicked;
            printCourse.Click += printCourse_ItemClicked;

            //Score dropdown Item
            addScore.Click += addScore_ItemClicked;
            avgScore.Click += avgScore_ItemClicked;
            manageScore.Click += manageScore_ItemClicked;

            //Result dropdown Item
            avgResultToolStrip.Click += avgResult_ItemClicked;
        }

        private void addUserStrip_ItemClicked(object sender, EventArgs e)
        {
            var addUser = new AddUser();
            addUser.Show();
        }

        

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void userList_ItemClicked(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            userList.Show();
        }
        private void printUser_ItemClicked(object sender, EventArgs e)
        {
            CheckUser printSave = new CheckUser();
            printSave.Show();
        }

        private void addCourse_ItemClicked(object sender, EventArgs e)
        {
            AddCourses add = new AddCourses();
            add.Show();
        }

        private void removeCourse_ItemClicked(object sender, EventArgs e)
        {
            RemoveCourse remove = new RemoveCourse();
            remove.Show();
        }
        private void editCourse_ItemClicked(object sender, EventArgs e)
        {
            EditCourse edit = new EditCourse();
            edit.Show();
        }

        private void manageCourse_ItemClicked(object sender, EventArgs e)
        {
            ManageCourses manage = new ManageCourses();
            manage.Show();
        }
        private void editAndRemove_ItemClicked(object sender, EventArgs e)
        {
            UserInfo edit = new UserInfo();
            edit.Show();
        }

        private void manageUser_ItemClicked(object sender, EventArgs e)
        {
            ManageUser manage = new ManageUser();
            manage.Show();
        }

        private void addScore_ItemClicked(object sender, EventArgs e)
        {
            AddScore addScore = new AddScore();
            addScore.Show();
        }

        private void printCourse_ItemClicked(object sender, EventArgs e)
        {
            Print print = new Print();
            print.Show();
        }
        private void avgScore_ItemClicked(object sender, EventArgs e)
        {
            AverageGrade avg = new AverageGrade();
            avg.Show();
        }

        private void manageScore_ItemClicked(object sender, EventArgs e)
        {
            ManageScore manage = new ManageScore();
            manage.Show();
        }

        private void avgResult_ItemClicked(object sender, EventArgs e)
        {
            AvgResult result = new AvgResult();
            result.Show();
        }
    }
}
