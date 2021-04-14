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

namespace WindowsFormsApp2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            addUserToolStrip.Click += addUserStrip_ItemClicked;
            userList.Click += userList_ItemClicked;
            printToolStrip.Click += print_ItemClicked;
            addCourse.Click += addCourse_ItemClicked;
            removeCourse.Click += removeCourse_ItemClicked;
            editCourse.Click += editCourse_ItemClicked;
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
            var userList = new UserList();
            userList.Show();
        }
        private void print_ItemClicked(object sender, EventArgs e)
        {
            var printSave = new printSave();
            printSave.Show();
        }

        private void addCourse_ItemClicked(object sender, EventArgs e)
        {
            AddCourses add = new AddCourses();
            add.Show();
        }

        private void removeCourse_ItemClicked(object sender, EventArgs e)
        {
            removeCourse remove = new removeCourse();
            remove.Show();
        }
        private void editCourse_ItemClicked(object sender, EventArgs e)
        {
            EditCourse edit = new EditCourse();
            edit.Show();
        }
    }
}
