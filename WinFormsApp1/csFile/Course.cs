using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace WinFormsApp1
{
    class Course
    {
        MY_DB mydb = new MY_DB();
        public bool removeCourseById(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM course WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        

        public bool insertCourse(int id, string label, int period, int semester, string des)
        {
            SqlCommand command = new SqlCommand("INSERT INTO course (id, label, period, semester, description) VALUES (@id, @label, @period, @semester, @des)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
            command.Parameters.Add("@des", SqlDbType.Text).Value = des;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool checkCourseName(string courseName, int courseId = 0)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE label=@cName And id <> @cID", mydb.getConnection);

            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows.Count <= 0;

        }
        public bool editCourse(int id, string label, string newLabel, int period, int semester, string description)
        {
            SqlCommand cmd = new SqlCommand("UPDATE course SET id = @id, label = @newLabel, period =@period, semester=@semester, description = @des WHERE label = @label", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            cmd.Parameters.Add("@newLabel", SqlDbType.NVarChar).Value = newLabel;
            cmd.Parameters.Add("@period", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
            cmd.Parameters.Add("@des", SqlDbType.NVarChar).Value = description;
            mydb.openConnection();
            if(cmd.ExecuteNonQuery() > 0)
            {
                mydb.closeConnection();
                return true;
            } else {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getAllCourses()
        {
            SqlCommand cmd = new SqlCommand("SELECT label FROM course", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.Fill(table);
            return table;
        }
        public int getCourseId(string label)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM course WHERE label=@label", mydb.getConnection);
            cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            DataTable table = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.Fill(table);

            return Convert.ToInt32(table.Rows[0].ItemArray[0]);
        }

        public string getCourseLabel(int courseID)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT label FROM course WHERE id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = courseID;
            DataTable table = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.Fill(table);

            return table.Rows[0].ItemArray[0].ToString();
        }

    }
}
