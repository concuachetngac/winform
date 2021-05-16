using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using WinFormsApp1;
using WinFormsApp1.csFile;

namespace WindowsFormsApp2
{
    class User
    {
        MY_DB mydb = new MY_DB();
        public bool insertUser(int Id, string fname, string lname, DateTime birthDate, string gender, int phone, string address, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO listUser (user_id, fname, lname, birthdate, gender, phone, picture, address) VALUES (@id, @fname, @lname, @birthdate, @gender, @phone, @picture, @address)", mydb.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@birthdate", System.Data.SqlDbType.DateTime).Value = birthDate;
            cmd.Parameters.Add("@gender", System.Data.SqlDbType.NVarChar).Value = gender;
            cmd.Parameters.Add("@phone", System.Data.SqlDbType.Int).Value = phone;
            cmd.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if((cmd.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            } else {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable userList()
        {
            MY_DB db = new MY_DB();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT user_id, fname, lname, birthdate, gender, phone, address, picture, selected_courses FROM listUser", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(tb);
            return tb;
        }
        public bool deleteUser(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM listUser WHERE user_id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            mydb.openConnection();
            if((cmd.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool editUser(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE listUser SET fname = @fname, lname = @lname, birthdate = @bdate, gender = @gender, phone = @phone, address = @adrs, picture = @picture WHERE user_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", System.Data.SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gender", System.Data.SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phone", System.Data.SqlDbType.Int).Value = Convert.ToInt32(phone);
            command.Parameters.Add("@adrs", System.Data.SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
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


        public bool addCourse(int studentID, int courseID, float score, string description)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO score (student_id, course_id) VALUES (@student_id, @course_id)", mydb.getConnection);
            cmd.Parameters.Add("@student_id", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@course_id", SqlDbType.Int).Value = courseID;

            mydb.openConnection();
            
            if(cmd.ExecuteNonQuery() > 0)
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getSelectedcourse(int studentID)
        {
            SqlCommand cmd = new SqlCommand("SELECT course_id FROM score WHERE student_id = @student_id", mydb.getConnection);
            cmd.Parameters.Add("@student_id", SqlDbType.Int).Value = studentID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public bool selectedCourse(int id)
        {
            Course course = new Course();
            string selectedCourse ="";
            DataTable table = getSelectedcourse(id);

            for(int i = 0; i < table.Rows.Count - 1; i++)
            {
                selectedCourse += course.getCourseLabel(Convert.ToInt32(table.Rows[i].ItemArray[0])) + "\n";
            }
            selectedCourse += course.getCourseLabel(Convert.ToInt32(table.Rows[table.Rows.Count - 1].ItemArray[0])) + ". ";
            SqlCommand cmd = new SqlCommand("UPDATE listUser SET selected_courses = @selected WHERE user_id=@id", mydb.getConnection);
            cmd.Parameters.Add("@selected", SqlDbType.NVarChar).Value = selectedCourse;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();

            if(cmd.ExecuteNonQuery() > 0)
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getScore(int id)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT course_id, student_score FROM score WHERE student_id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(table);
            return table;
        }
        public DataTable getScoreByFname(string fname)
        {
            Result result = new Result();
            Course course = new Course();

            
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT user_id FROM listUser WHERE fname = @fname", mydb.getConnection);
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(table);
            if (table.Rows.Count > 0)
            {
                return getScore(Convert.ToInt32(table.Rows[0][0]));
            }
            else
            {
                return result.getResultTable(course.getAllCourses());
            }
              
        }


        public float getAvgScore(int id) 
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT AVG(student_score) AS avg FROM score WHERE student_id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(table);

            return float.Parse(table.Rows[0][0].ToString());

        }
    }
}
